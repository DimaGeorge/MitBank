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
        private static int x = 100;
        private static int y = 500;
        private static int width = 700;

        public static Label createFrame(Page info)
        {
            Label lb = new Label();
            lb.Text = info.Data;
            
            lb.Top = x;
            x += 100;
            
            lb.Left = y;
            lb.Size = new Size(200, 200);
            lb.BackColor = Color.Aqua;
            lb.Width = 100;
            lb.Visible = true;
            lb.BringToFront();
            return lb;
        }

    }
}
