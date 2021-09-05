using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Threading;

namespace RawDataSender4
{
    public partial class ClientForm : Form
    {
        public TcpClient ConnectedTcpClient;

        public ClientForm()
        {
            InitializeComponent();
            toolStripStatusLabelConnection.Text = "Connecting";
        }

        private bool IsLoaded = false;
        private CancellationTokenSource readerTaskCancellation = new CancellationTokenSource();
        private Task readerTask = null;
        private void ClientForm_Load(object sender, EventArgs e)
        {
            this.Width = int.Parse(AppConfiguration.GetAppConfig("ClientWindowW", this.Width));
            this.Height = int.Parse(AppConfiguration.GetAppConfig("ClientWindowH", this.Height));
            this.splitContainerTop.SplitterDistance =
                int.Parse(AppConfiguration.GetAppConfig(
                "ClientVerticalSplitterPosition",
                splitContainerTop.SplitterDistance));
            this.splitContainerHex.SplitterDistance =
                int.Parse(AppConfiguration.GetAppConfig(
                "ClientHorizontalLeftSplitterPosition",
                splitContainerHex.SplitterDistance));
            this.splitContainerText.SplitterDistance =
                int.Parse(AppConfiguration.GetAppConfig(
                "ClientHorizontalRightSplitterPosition",
                splitContainerText.SplitterDistance));

            IsLoaded = true;

            var cancellationToken = readerTaskCancellation.Token;
            readerTask = Task.Run(async () =>
            {
                var buffer = new byte[64];
                try
                {
                    while (!cancellationToken.IsCancellationRequested)
                    {
                        var stream = ConnectedTcpClient.GetStream();
                        var readBytes = await stream.ReadAsync(buffer, 0, 64, cancellationToken);
                        var asText = Encoding.UTF8.GetString(buffer, 0, readBytes);
                        var asHex = BytesToHexstring(buffer, 0, readBytes);

                        Invoke(new MethodInvoker(() =>
                        {
                            richTextBoxIncomingText.AppendText(asText);
                            richTextBoxIncomingHex.AppendText(asHex + " ");
                        }));
                    }
                }
                catch (Exception)
                {
                    DisconnectnClose();
                }
            }, cancellationToken);
        }

        public void UpdateConnectionStatus()
        {
            if (ConnectedTcpClient.Connected)
                toolStripStatusLabelConnection.Text = "Connected";
            else
                toolStripStatusLabelConnection.Text = "Closed";
        }

        private void ClientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            readerTaskCancellation.Cancel();
            ConnectedTcpClient.Close();
            ConnectedTcpClient.Dispose();
            e.Cancel = true;
            this.Hide();
        }

        private void DisconnectnClose()
        {
            ConnectedTcpClient.Close();
            Invoke(new MethodInvoker(() =>
            {
                UpdateConnectionStatus();
            }));
        }

        private void SendData(byte[] buf)
        {
            var stream = ConnectedTcpClient.GetStream();
            try
            {
                stream.Write(buf, 0, buf.Length);
            }
            catch
            {
                DisconnectnClose();
            }
        }

        private void textBoxOutgoingHex_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            if (e.Shift)
                return;

            e.SuppressKeyPress = true;

            if (ConnectedTcpClient == null || !ConnectedTcpClient.Connected)
                return;

            if (textBoxOutgoingHex.Text == "")
                return;

            byte[] asBytes = null;
            try
            {
                asBytes = HexstringToBytes(textBoxOutgoingHex.Text.Replace(" ", ""));
                richTextBoxOutgoingHex.AppendText(BytesToHexstring(asBytes, 0, asBytes.Length));
                richTextBoxOutgoingHex.AppendText(" ");
                richTextBoxOutgoingText.AppendText(Encoding.UTF8.GetString(asBytes));
            }
            catch { }

            textBoxOutgoingHex.Text = "";
            textBoxOutgoingText.Text = "";

            if (asBytes != null)
                SendData(asBytes);
        }

        private void textBoxOutgoingText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            if (e.Shift)
                return;

            e.SuppressKeyPress = true;
            
            if (ConnectedTcpClient == null || !ConnectedTcpClient.Connected)
                return;

            if (textBoxOutgoingText.Text == "")
                return;

            byte[] asBytes = null;
            try
            {
                asBytes = Encoding.UTF8.GetBytes(textBoxOutgoingText.Text);
                richTextBoxOutgoingHex.AppendText(BytesToHexstring(asBytes, 0, asBytes.Length));
                richTextBoxOutgoingHex.AppendText(" ");
                richTextBoxOutgoingText.AppendText(textBoxOutgoingText.Text);
            }
            catch { }

            textBoxOutgoingHex.Text = "";
            textBoxOutgoingText.Text = "";

            if (asBytes != null)
                SendData(asBytes);
        }

        private static string BytesToHexstring(byte[] dat, int offset, int length)
        {
            var asHex = BitConverter.ToString(dat, offset, length);
            return asHex.Replace("-", " ");
        }

        private static byte[] HexstringToBytes(string hex)
        {
            byte[] buf = new byte[hex.Length / 2];

            for (int i = 0; i < buf.Length; i++)
                buf[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);

            return buf;
        }

        private bool noTextChangeEvent = false;
        private void textBoxOutgoingHex_TextChanged(object sender, EventArgs e)
        {
            if (noTextChangeEvent)
                return;
            noTextChangeEvent = true;

            try
            {
                var asBytes = HexstringToBytes(textBoxOutgoingHex.Text.Replace(" ", ""));
                textBoxOutgoingText.Text = Encoding.UTF8.GetString(asBytes);
            }
            catch { }

            noTextChangeEvent = false;
        }

        private void textBoxOutgoingText_TextChanged(object sender, EventArgs e)
        {
            if (noTextChangeEvent)
                return;
            noTextChangeEvent = true;

            try
            {
                var bytes = Encoding.UTF8.GetBytes(textBoxOutgoingText.Text);
                textBoxOutgoingHex.Text = BytesToHexstring(bytes, 0, bytes.Length);
            }
            catch { }

            noTextChangeEvent = false;
        }

        private void textBoxOutgoingHex_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void textBoxOutgoingText_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void textBoxOutgoingHex_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        }

        private void textBoxOutgoingText_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        }

        private void ClientForm_Resize(object sender, EventArgs e)
        {
            if (!IsLoaded)
                return;
            if (this.WindowState == FormWindowState.Normal)
            {
                AppConfiguration.SetAppConfig("WindowW", this.Width);
                AppConfiguration.SetAppConfig("WindowH", this.Height);
            }
        }

        private void splitContainerTop_SplitterMoved(object sender, SplitterEventArgs e)
        {
            AppConfiguration.SetAppConfig("ClientVerticalSplitterPosition",
                splitContainerTop.SplitterDistance);
        }

        private void splitContainerHex_SplitterMoved(object sender, SplitterEventArgs e)
        {
            AppConfiguration.SetAppConfig("ClientHorizontalLeftSplitterPosition",
                splitContainerHex.SplitterDistance);
        }

        private void splitContainerText_SplitterMoved(object sender, SplitterEventArgs e)
        {
            AppConfiguration.SetAppConfig("ClientHorizontalRightSplitterPosition",
                splitContainerText.SplitterDistance);
        }
    }
}
