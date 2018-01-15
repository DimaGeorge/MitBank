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
    public partial class FormAdmin : Form
    {
        static Panel lastMenupanel = new Panel();
        public FormAdmin()
        {
            InitializeComponent();

            panelDashboard.BackColor = System.Drawing.Color.FromArgb(100, 100, 40);
            panelAddUser.BackColor = System.Drawing.Color.FromArgb(100, 100, 40);
            panelChangeCurrency.BackColor = System.Drawing.Color.FromArgb(100, 100, 40);
            panelCashStore.BackColor = System.Drawing.Color.FromArgb(100, 100, 40);
            //panelSettings.BackColor = System.Drawing.Color.FromArgb(100, 100, 40);


            panelDashboard.Visible = true;
            panelAddUser.Visible = false;
            panelChangeCurrency.Visible = false;
            panelCashStore.Visible = false;
            //panelSettings.Visible = false;

            lastMenupanel = panelDashboard;
            for(int i = 1; i < 32; i++)
            {
                this.comboDay.Items.Add(i.ToString());
            }

            for (int i = 1; i < 13; i++)
            {
                this.comboMonth.Items.Add(i.ToString());
            }

            for (int i = 1900; i < 2019; i++)
            {
                this.comboYear.Items.Add(i.ToString());
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure?", "Info",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //using (var context = new MitBankDBEntities2())
                //{
                //    var result2 = context.insertLastLogin(DataManagement.getIdUsername(), DateTime.Now.ToString());

                //}
                this.Hide();
                this.Refresh();
                this.Invalidate();
                Form1 frm = new Form1();
                frm.Refresh();
                frm.Invalidate();
                frm.Show();

            }
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            lastMenupanel.Visible = false;
            panelAddUser.Visible = true;
            lastMenupanel.SendToBack();
            lastMenupanel = panelAddUser;
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            lastMenupanel.Visible = false;
            panelDashboard.Visible = true;
            lastMenupanel.SendToBack();
            lastMenupanel = panelDashboard;
        }

        private void buttonAddCashStore_Click(object sender, EventArgs e)
        {
            lastMenupanel.Visible = false;
            panelCashStore.Visible = true;
            lastMenupanel.SendToBack();
            lastMenupanel = panelCashStore;
        }

        private void buttonChangeCurrencyValues_Click(object sender, EventArgs e)
        {
            lastMenupanel.Visible = false;
            panelChangeCurrency.Visible = true;
            lastMenupanel.SendToBack();
            lastMenupanel = panelChangeCurrency;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddInd_Click(object sender, EventArgs e)
        {
            if (textPassword.Text != textPassword2.Text)
            {
                MessageBox.Show("parolele nu coincid!");
                return;
            }
            
            string username = this.textUsername.Text;
            string password = this.textPassword.Text;     

            if (radioIndivid.Checked)
            {
                var individ = new Individual
                {
                    FirstName = this.textFirstName.Text,
                    LastName = this.textLastName.Text,
                    Email = this.textEmail.Text,
                    Birthday = new DateTime(
                                Int32.Parse(this.comboYear.Text),
                                Int32.Parse(this.comboMonth.Text),
                                Int32.Parse(this.comboDay.Text)
                                ),
                    CNP = this.textCNP.Text,
                };


                DataManagement.addIndividualCustomer(individ, username, password);
            }
            else
            {
                var individ = new Individual
                {
                    FirstName = this.textFirstName.Text,
                    LastName = this.textLastName.Text,
                    Email = this.textEmail.Text,
                    Birthday = new DateTime(
                                Int32.Parse(this.comboYear.Text),
                                Int32.Parse(this.comboMonth.Text),
                                Int32.Parse(this.comboDay.Text)
                                ),
                    CNP = this.textCNP.Text,
                };

                var company = new Company
                {
                    CIF = Int32.Parse(this.textCif.Text),
                    Name = this.textCompany.Text,
                    Address = this.textAddress.Text
                };
                DataManagement.addCompany(individ, company, username, password);

            }
        }

        private void panelAddUser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioIndivid_CheckedChanged(object sender, EventArgs e)
        {
            if (radioIndivid.Checked)
            {
                this.labelCompanyName.Hide();
                this.labelCif.Hide();
                this.labelAddress.Hide();
                this.textAddress.Hide();
                this.textCif.Hide();
                this.textCompany.Hide();
            }
        }

        private void radioComp_CheckedChanged(object sender, EventArgs e)
        {
            if (radioComp.Checked)
            {
                this.labelCompanyName.Show();
                this.labelCif.Show();
                this.labelAddress.Show();
                this.textAddress.Show();
                this.textCif.Show();
                this.textCompany.Show();
            }
        }
    }
}
