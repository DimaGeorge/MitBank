using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;

namespace login2
{


    public partial class Form1 : Form
    {
        public static bool isAdmin = false;
        
        public Form1()
        {
            InitializeComponent();
            registrationPanel.Visible = false;
            this.AutoSize = true;
            codeTxtbox.Visible = false;
            acceptTermsCheckBox.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            registrationPanel.Visible = false;
            logInPanel.Visible = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            registrationPanel.Visible = false;
            logInPanel.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            registrationPanel.Visible = true;
            logInPanel.Visible = false;
        }
        int okCode = 0;
        private void loginButon_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();

            string pass = DataManagement.getPass(passwordLoginTxtbox.Text);

            if (DataManagement.tryConnection(usernameLoginTxtbox.Text, pass))
            {
                this.Visible = false;
                this.Hide();
                
                if (isAdmin)
                {
               
                    FormAdmin frm = new FormAdmin();
                    frm.Show();
                    isAdmin = false;
                }
                else
                {
                    
                    Form2 frm = new Form2();
                    frm.Show();
                }
                

            }
            else
            {
                MessageBox.Show("Conexiunea nu se poate stabili!");
            }


           


        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
