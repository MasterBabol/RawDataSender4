using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RawDataSender4
{
    public partial class ListenerForm : Form
    {
        private TcpListener Listener;

        public ListenerForm()
        {
            InitializeComponent();
            isListening = false;
        }

        private bool isListening;
        private Task listenTask;
        private CancellationTokenSource cancelSource;
        private void StartListen()
        {
            try
            {
                IPAddress bindIp = IPAddress.Parse(textBoxIp.Text);
                int bindPort = int.Parse(textBoxPort.Text);
                Listener = new TcpListener(bindIp, bindPort);

                buttonListenStop.Text = "Stop";

                Listener.Start();
                cancelSource = new CancellationTokenSource();
                isListening = true;
                listenTask = Task.Run(async () => {
                    while (!cancelSource.IsCancellationRequested)
                    {
                        try
                        {
                            var tc = await Listener.AcceptTcpClientAsync();
                            Invoke(new MethodInvoker(delegate ()
                            {
                                richTextBoxLog.AppendText(string.Format("Accepted a new connection from: {0}\n", tc.Client.RemoteEndPoint.ToString()));
                                var cf = new ClientForm
                                {
                                    Text = string.Format("Active Connection: {0}", tc.Client.RemoteEndPoint.ToString()),
                                    ConnectedTcpClient = tc,
                                    MdiParent = this.ParentForm
                                };
                                cf.UpdateConnectionStatus();
                                cf.Show();
                            }));
                        }
                        catch
                        {
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task StopListen()
        {
            buttonListenStop.Enabled = false;
            cancelSource.Cancel();
            Listener.Stop();
            await listenTask;

            Invoke(new MethodInvoker(delegate ()
            {
                buttonListenStop.Text = "Listen";
                buttonListenStop.Enabled = true;
            }));
            isListening = false;
        }

        private async void buttonListenStop_Click(object sender, EventArgs e)
        {
            if (!isListening)
            {
                AppConfiguration.SetAppConfig("LastListenIP", textBoxIp.Text);
                AppConfiguration.SetAppConfig("LastListenPort", textBoxPort.Text);
                StartListen();
            }
            else
            {
                await StopListen();
            }
        }

        private void ListenerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Task.Run(async () =>
            {
                try
                {
                    await StopListen();
                }
                catch { }
            });
        }

        private bool IsLoaded = false;
        private void ListenerForm_Load(object sender, EventArgs e)
        {
            this.Width = int.Parse(AppConfiguration.GetAppConfig("ListenerWindowW", this.Width));
            this.Height = int.Parse(AppConfiguration.GetAppConfig("ListenerWindowH", this.Height));
            textBoxIp.Text = AppConfiguration.GetAppConfig("LastListenIP", "0.0.0.0");
            textBoxPort.Text = AppConfiguration.GetAppConfig("LastListenPort", "0");
            IsLoaded = true;
        }

        private void ListenerForm_Resize(object sender, EventArgs e)
        {
            if (!IsLoaded)
                return;
            if (this.WindowState == FormWindowState.Normal)
            {
                AppConfiguration.SetAppConfig("ListenerWindowW", this.Width);
                AppConfiguration.SetAppConfig("ListenerWindowH", this.Height);
            }
        }
    }
}
