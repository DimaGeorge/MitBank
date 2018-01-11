using System;
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
        List<Label> ibanList = new List<Label>();
        Label exchangeLabel;

        public Form2()
        {
            InitializeComponent();
            panelMainDashboard.BackColor = Color.FromArgb(100, 100, 40);
            panelMainPaySomething.BackColor = Color.FromArgb(100, 100, 40);
            panelMainSendMail.BackColor = Color.FromArgb(100, 100, 40);
            panelMainSettings.BackColor = Color.FromArgb(100, 100, 40);
            panelMainTransfer.BackColor = Color.FromArgb(100, 100, 40);
            
            panelMainDashboard.Visible = true;
            panelMainPaySomething.Visible = false;
            panelMainSendMail.Visible = false;
            panelMainTransfer.Visible = false;
            panelMainSettings.Visible = false;

            lastMenupanel = panelMainDashboard;
            ibanList.Clear();
            int i = 0;
            List<string> list = DataManagement.getDashboardInfo();
            foreach (string iban in list)
            {
                var context = new MitBankDBEntities2();
     
                Label lb = UIDashboardAccountFrame.createFrame(iban, i);
                i++;
                ibanList.Add(lb);
            }

            foreach (Label lb in ibanList)
            {
                panelMainDashboard.Controls.Add(lb);
                lb.BringToFront();
            }

            panelMainDashboard.Controls.Add(UIDashboardAccountFrame.getExchangeTable());
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
            
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            lastMenupanel.Visible = false;
            panelMainPaySomething.Visible = true;
            lastMenupanel.SendToBack();
            lastMenupanel = panelMainPaySomething;

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            lastMenupanel.Visible = false;
            panelMainTransfer.Visible = true;
            lastMenupanel.SendToBack();
            lastMenupanel = panelMainTransfer;


            using (var context =new MitBankDBEntities2())
            {


                List<Page> listIban = new List<Page>();
                listIban = DataManagement.getIbanList();
                foreach (var item in listIban)
                {
                    int index = -1;
                    index = comboBoxIBAN.FindString(item.Data.ToString());

                    if (index==-1)
                    {
                        comboBoxIBAN.Items.Add(item.Data.ToString());
                    }
                    
                }
                if(listIban.Count()!=0)
                {
                    comboBoxIBAN.SelectedIndex = 0;
                    comboBoxSelectTransfer.SelectedIndex = 0;
                }
                
                
                 
            }




        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            lastMenupanel.Visible = false;
            panelMainSendMail.Visible = true;
            lastMenupanel.SendToBack();
            lastMenupanel = panelMainSendMail;

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            lastMenupanel.Visible = false;
            panelMainSettings.Visible = true;
            lastMenupanel.SendToBack();
            lastMenupanel = panelMainSettings;

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panelMainTransfer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            
            var result = MessageBox.Show("Are you sure?","Info",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Form1 frm = new Form1();
                this.Refresh();
                this.Invalidate();
                frm.Refresh();
                frm.Invalidate();
                frm.Show();
            }
        }

        private void comboBoxIBAN_SelectedIndexChanged(object sender, EventArgs e)
        {
            Page pg = DataManagement.getSold(comboBoxIBAN.SelectedItem.ToString());
            labelshowsold.Text = pg.Data;


            Page pg2 = DataManagement.getCurrency(comboBoxIBAN.SelectedItem.ToString());
            labelshowcurrency.Text = pg2.Data;

            comboBoxToTransferMyIBAN.Refresh();
            comboBoxSelectTransfer.SelectedIndex = -1;
        }

        private void comboBoxSelectTransfer_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboBoxToTransferMyIBAN.Items.Clear();
            if (comboBoxSelectTransfer.Text.ToString() == "My another account")
            {
                label12.Visible = false;
                textBoxWriteIBAN.Visible = false;
                comboBoxToTransferMyIBAN.Visible = true;

                List<Page> lp = new List<Page>();
                lp = DataManagement.getIbanList();

                foreach (var item in lp)
                {
                    int index = -1;
                    index = comboBoxToTransferMyIBAN.FindString(item.Data.ToString());

                    if (index ==-1 && item.Data.ToString()!=comboBoxIBAN.Text.ToString())
                    {
                        comboBoxToTransferMyIBAN.Items.Add(item.Data.ToString());
                    }

                }
                



            }
            else
            {
                label12.Visible = true;
                comboBoxToTransferMyIBAN.Visible = false;
                textBoxWriteIBAN.Visible = true;
            }

        }

        private void textoxValueToTransfer_OnValueChanged(object sender, EventArgs e)
        {
            //labelComisionValue.Visible = true;
            //labelComisionValue.Text = "-";

            string fromIBAN = comboBoxIBAN.Text;
            Page pg = new Page();

            ///////////////////make txt for numberrs
            int parsedValue;
            if (!int.TryParse(textoxValueToTransfer.Text, out parsedValue))
            {
                MessageBox.Show("Ups! Only numbers");
                textoxValueToTransfer.Text = "0";
            }

            if (pg.Data != "" && comboBoxIBAN.SelectedIndex != -1)
            {
                pg = DataManagement.getComision(fromIBAN.ToString());
            }
            

            double Val = 0;
            if (textoxValueToTransfer.Text != "" && comboBoxIBAN.SelectedIndex != -1)
            {
                Val = double.Parse(textoxValueToTransfer.Text);

                double comVal = 0;

                comVal = double.Parse(pg.Data);

                labelComisionValue.Text = (Val * comVal / 100).ToString();
            }else
            {
                labelComisionValue.Text = "-";
            }
            


        }
    }
}
