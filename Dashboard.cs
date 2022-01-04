using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        public bool pingStatus()
        {
            bool pingStatus = false;
            string hostNameOrAddress = "127.0.0.1";

            using (Ping p = new Ping())
            {
                string data = "aaaaaaaaaaaaaaaa";
                byte[] buffer = Encoding.ASCII.GetBytes(data);
                int timeout = 1000;


                try
                {
                    PingReply reply = p.Send(hostNameOrAddress, timeout, buffer);
                    pingStatus = (reply.Status == IPStatus.Success);
                }
                catch (Exception)
                {
                    pingStatus = false;
                }
                return pingStatus;
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pingStatus() == true)
            {
                picBoxStatus.Image = Properties.Resources.icons8_online_30;
                lblStatus.Text = "Server Online";
                lblStatus.ForeColor = Color.FromArgb(0, 255, 0);
            }
            else
            {
                picBoxStatus.Image = Properties.Resources.icons8_offline_30;
                lblStatus.Text = "Server Offline";
                lblStatus.ForeColor = Color.FromArgb(204, 0, 0);
            }
        }
    }
}
