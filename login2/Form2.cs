﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login2
{
    public partial class Form2 : Form
    {
        static Panel lastMenupanel = new Panel();

        public Form2()
        {
            InitializeComponent();
            panelMainDashboard.BackColor = Color.FromArgb(100, 100, 40);
           /* panelMainPaySomething.BackColor = Color.FromArgb(100, 100, 40);
            panelMainSendMail.BackColor = Color.FromArgb(100, 100, 40);
            panelMainSettings.BackColor = Color.FromArgb(100, 100, 40);
            panelMainTransfer.BackColor = Color.FromArgb(100, 100, 40);
            */
            panelMainDashboard.Visible = true;
           // panelMainPaySomething.Visible = false;
          //  panelMainSendMail.Visible = false;
          //  panelMainTransfer.Visible = false;
          //  panelMainSettings.Visible = false;

            lastMenupanel = panelMainDashboard;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            lastMenupanel.Visible = false;
            panelMainDashboard.Visible = true;
            lastMenupanel.SendToBack();
            lastMenupanel = panelMainDashboard;

            Page pg = DataManagement.getDashboardInfo();
            label2.Text = pg.Data;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            lastMenupanel.Visible = false;
            //panelMainPaySomething.Visible = true;
            lastMenupanel.SendToBack();
            //lastMenupanel = panelMainPaySomething;

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            lastMenupanel.Visible = false;
           // panelMainTransfer.Visible = true;
            lastMenupanel.SendToBack();
           // lastMenupanel = panelMainTransfer;

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            lastMenupanel.Visible = false;
           // panelMainSendMail.Visible = true;
            lastMenupanel.SendToBack();
         //   lastMenupanel = panelMainSendMail;

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            lastMenupanel.Visible = false;
          //  panelMainSettings.Visible = true;
            lastMenupanel.SendToBack();
         //   lastMenupanel = panelMainSettings;

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panelMainTransfer_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}