using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RawDataSender4
{
    public partial class ClientSettingsForm : Form
    {
        public IPAddress RemoteIP
        {
            get
            {
                return IPAddress.Parse(textBoxIp.Text);
            }
        }

        public int RemotePort
        {
            get
            {
                return int.Parse(textBoxPort.Text);
            }
        }

        public ClientSettingsForm()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            AppConfiguration.SetAppConfig("LastClientIP", textBoxIp.Text);
            AppConfiguration.SetAppConfig("LastClientPort", textBoxPort.Text);
            DialogResult = DialogResult.OK;
        }

        private void textBoxPort_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonConnect.PerformClick();
        }

        private void textBoxIp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonConnect.PerformClick();
        }

        private void ClientSettingsForm_Load(object sender, EventArgs e)
        {
            textBoxIp.Text = AppConfiguration.GetAppConfig("LastClientIP", "0.0.0.0");
            textBoxPort.Text = AppConfiguration.GetAppConfig("LastClientPort", "0");
        }
    }
}
