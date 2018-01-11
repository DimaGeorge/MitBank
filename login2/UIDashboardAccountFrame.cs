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
        private static int top = 20;
        private static int left = 20;
        private static int height = 100;
        private static int width = 620;

        public static Label createFrame(string iban, int pos)
        {
            Label lb = new Label();
            // text
            lb.Text = iban;
            lb.ForeColor = Color.FromArgb(255, 255, 240);
            lb.Font = new Font("Century Ghotic", 15, FontStyle.Bold);
            //position
            lb.Top = top + 120 * pos;         
            lb.Left = left;
            lb.AutoSize = false;
            lb.Size = new Size(width, height);
            
            
            lb.BackColor = Color.FromArgb(30, 35, 35);
            
            lb.Visible = true;
            lb.BringToFront();
            return lb;
        }

    }
}
