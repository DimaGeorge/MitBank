using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    public static class UIDashboardAccountFrame
    {
        private static int top = 100;
        private static int left = 250;
        private static int height = 100;
        private static int width = 620;

        public static Label createFrame(string iban, int pos)
        {
            Label lb = new Label();
            lb.Text = iban;
            
            lb.Top = top + 120 * pos;         
            lb.Left = left;
            lb.AutoSize = false;
            lb.Size = new Size(width, height);
            lb.BackColor = Color.Orange;
            lb.Visible = true;
            lb.BringToFront();
            return lb;
        }

    }
}
