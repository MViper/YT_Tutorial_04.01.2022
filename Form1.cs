using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Net;
using System.Security.Principal;
using System.Management;
using System.Diagnostics;
using System.Text;


namespace Tutorial
{
   
    public partial class Form1 : Form
    {

         private bool dragging = false;
            private Point startPoint = new Point(0, 0);

        public Form1()
        {
            InitializeComponent();

            lblwinuser.Text = "Hallo " + System.Environment.UserName;

            lbltitle.Text = "Tutorial";

            lbltime.Text = DateTime.Now.ToLongTimeString();
            lbldate.Text = DateTime.Now.ToLongDateString();


            lbltitle.Text = "Tutorial";
            Dashboard Dashboard_vrb = new Dashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Dashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.FormLoader.Controls.Add(Dashboard_vrb);
            Dashboard_vrb.Show();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            lbltitle.Text = "Tutorial";
            this.FormLoader.Controls.Clear();
            Dashboard Dashboard_vrb = new Dashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Dashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.FormLoader.Controls.Add(Dashboard_vrb);
            Dashboard_vrb.Show();
        }

        private void btnCalender_Click(object sender, EventArgs e)
        {
            lbltitle.Text = "Calender";
            this.FormLoader.Controls.Clear();
            Calender Calender_vrb = new Calender() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Calender_vrb.FormBorderStyle = FormBorderStyle.None;
            this.FormLoader.Controls.Add(Calender_vrb);
            Calender_vrb.Show();
        }

        private void btnsocial_Click(object sender, EventArgs e)
        {
            lbltitle.Text = "Social";
            this.FormLoader.Controls.Clear();
            Social Social_vrb = new Social() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Social_vrb.FormBorderStyle = FormBorderStyle.None;
            this.FormLoader.Controls.Add(Social_vrb);
            Social_vrb.Show();
        }

        private void lblContact_Click(object sender, EventArgs e)
        {
            lbltitle.Text = "Contact";
            this.FormLoader.Controls.Clear();
            Contact Contact_vrb = new Contact() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Contact_vrb.FormBorderStyle = FormBorderStyle.None;
            this.FormLoader.Controls.Add(Contact_vrb);
            Contact_vrb.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lbltitle.Text = "Settings";
            this.FormLoader.Controls.Clear();
            Settings Settings_vrb = new Settings() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Settings_vrb.FormBorderStyle = FormBorderStyle.None;
            this.FormLoader.Controls.Add(Settings_vrb);
            Settings_vrb.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            lbltitle.Text = "Info";
            this.FormLoader.Controls.Clear();
            Info Info_vrb = new Info() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Info_vrb.FormBorderStyle = FormBorderStyle.None;
            this.FormLoader.Controls.Add(Info_vrb);
            Info_vrb.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
