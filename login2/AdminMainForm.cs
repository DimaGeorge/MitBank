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
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
            
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void ButonDepunereNumerar_Click(object sender, EventArgs e)
        {
            DataManagement.cashDeposit();
            DataManagement.addNewIndividual();
        }


    }
}
