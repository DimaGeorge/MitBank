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
    }
}
