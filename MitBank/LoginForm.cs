using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MitBank
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButtonOK_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(this.username.Text + " " + this.passwd.Text);
            Kitchen.tryConnect(this.username.Text, this.passwd.Text);
        }
    }
}
