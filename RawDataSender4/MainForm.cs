using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace RawDataSender4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private bool IsLoaded = false;
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Left = int.Parse(AppConfiguration.GetAppConfig("WindowX", this.Left));
            this.Top = int.Parse(AppConfiguration.GetAppConfig("WindowY", this.Top));
            this.Width = int.Parse(AppConfiguration.GetAppConfig("WindowW", this.Width));
            this.Height = int.Parse(AppConfiguration.GetAppConfig("WindowH", this.Height));
            IsLoaded = true;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AppConfiguration.SetAppConfig("WindowX", this.Left);
            AppConfiguration.SetAppConfig("WindowY", this.Top);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (!IsLoaded)
                return;
            if (this.WindowState == FormWindowState.Normal)
            {
                AppConfiguration.SetAppConfig("WindowW", this.Width);
                AppConfiguration.SetAppConfig("WindowH", this.Height);
            }
        }

        private void listenerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var lf = new ListenerForm();
            lf.MdiParent = this;
            lf.Show();
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var csf = new ClientSettingsForm();
            if (csf.ShowDialog() == DialogResult.OK)
            {
                var tc = new TcpClient();
                try
                {
                    var cf = new ClientForm
                    {
                        Text = string.Format("Active Connection: {0}:{1}", csf.RemoteIP, csf.RemotePort),
                        ConnectedTcpClient = tc,
                        MdiParent = this
                    };

                    _ = Task.Run(async () =>
                    {
                        await tc.ConnectAsync(csf.RemoteIP, csf.RemotePort);
                        Invoke(new MethodInvoker(() =>
                        {
                            if (!cf.Disposing && !cf.IsDisposed)
                                cf.UpdateConnectionStatus();
                        }));
                    });

                    cf.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void binderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void reportBugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:babol@live.co.kr");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var child in MdiChildren)
            {
                child.Close();
            }

            _ = Task.Run(async () =>
            {
                bool childAlive = true;
                while (childAlive)
                {
                    childAlive = false;
                    Invoke(new MethodInvoker(() =>
                    {
                        foreach (var child in MdiChildren)
                        {
                            if (child.Visible)
                                childAlive = true;
                        }
                    }));

                    await Task.Delay(100);
                }

                Invoke(new MethodInvoker(() =>
                {
                    this.Close();
                }));
            });
        }
    }
}
