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
        private static int width = 500;

        private static Label getPacketLabel(string iban)
        {
            Label date = new Label();
            date.Text = DataManagement.getIbanPacket(iban);
            
            switch (date.Text.Trim())
            {
                case "STUDENT PE+":
                    date.Font = new Font("Comic Sans MS", 12, FontStyle.Regular);
                    date.ForeColor = Color.YellowGreen;
                    break;

                case "GOLD PE+":
                    date.Font = new Font("Times New Roman", 12, FontStyle.Regular);
                    date.ForeColor = Color.Yellow;
                    break;

                default:
                    date.Font = new Font("Century Ghotic", 10, FontStyle.Regular);
                    break;
            }

            

            //position
            date.Top = 30;
            date.Left = 10;
            date.AutoSize = false;
            date.Size = new Size(200, 50);

            return date;
        }

        private static Label getDateLabel(string iban)
        {
            Label date = new Label();
            date.Text = "Valid until ";
            date.Text += DataManagement.getIbanDate(iban).Substring(0,9);
            date.ForeColor = Color.FromArgb(255, 255, 240);
            date.Font = new Font("Century Ghotic", 8, FontStyle.Italic);

            //position
            date.Top = 70;
            date.Left = 10;
            date.AutoSize = false;
            date.Size = new Size(200, 50);

            return date;
        }

        private static Label getSoldLabel(string iban)
        {
            Label sold = new Label();
            sold.Text = DataManagement.getIbanSold(iban);
            sold.ForeColor = Color.FromArgb(255, 255, 240);
            sold.Font = new Font("Century Ghotic", 18, FontStyle.Bold);
            sold.TextAlign = ContentAlignment.TopRight;

            //position
            sold.Top = 47;
            sold.Left = 250;
            sold.AutoSize = false;
            sold.Size = new Size(150, 50);

            return sold;
        }

        private static Label getCurrencyLabel(string iban)
        {
            Label currency = new Label();
            currency.Text = DataManagement.getIbanCurrency(iban);
            currency.ForeColor = Color.Yellow;
            currency.Font = new Font("Century Ghotic", 25, FontStyle.Bold);

            //position
            currency.Top = 40;
            currency.Left = 400;
            currency.AutoSize = false;
            currency.Size = new Size(200, 50);

            return currency;
        }

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
            lb.Controls.Add(getCurrencyLabel(iban));
            lb.Controls.Add(getPacketLabel(iban));
            lb.Controls.Add(getSoldLabel(iban));
            Label date = getDateLabel(iban);
            lb.Controls.Add(date);
            date.BringToFront();
            return lb;
        }

        private static Label getLabelInTable(int top, int left, string txt)
        {
            Label lb = new Label();
            // text
            lb.Text = txt;

            switch (txt)
            {
                case "BUY":
                    lb.ForeColor = Color.LightGreen;
                    break;
                case "SELL":
                    lb.ForeColor = Color.LightPink;
                    break;
                case "EUR":
                    lb.ForeColor = Color.Yellow;
                    break;
                case "GBH":
                    lb.ForeColor = Color.Yellow;
                    break;
                case "USD":
                    lb.ForeColor = Color.Yellow;
                    break;
                default:
                    lb.ForeColor = Color.FromArgb(255, 255, 240);
                    break;
            }

            
            lb.Font = new Font("Century Ghotic", 10, FontStyle.Regular);
            //position
            int width = 44;
            int height = 30;
            int space = 10;

            lb.Top = space * top + height *(top - 1);
            lb.Left = space * left + width * (left - 1);
            lb.AutoSize = false;
            lb.Size = new Size(width, height);
            lb.BackColor = Color.FromArgb(30, 35, 35);

            return lb;
        }

        public static Label getExchangeTable()
        {
            Label lb = new Label();
            // text
            lb.ForeColor = Color.FromArgb(255, 255, 240);
            lb.Font = new Font("Century Ghotic", 15, FontStyle.Bold);

            //position
            lb.Top = 20;
            lb.Left = 540;
            lb.AutoSize = false;
            lb.Size = new Size(170, 170);
            lb.BackColor = Color.FromArgb(30, 35, 35);

            List<string> list = DataManagement.getExchange().Split(' ').ToList();
            lb.Controls.Add(getLabelInTable(1, 2, "BUY"));
            lb.Controls.Add(getLabelInTable(1, 3, "SELL"));
            int top = 2, left = 1;
            foreach (string str in list)
            {
                lb.Controls.Add(getLabelInTable(top, left, str));
                left++;
                if (left > 3)
                {
                    left = 1;
                    top++;
                }
            }
            return lb;
        }

        public static void generateDashboard(List<Label> ibanList, Panel panelMainDashboard, Label exchangeTbl)
        {
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

            exchangeTbl = UIDashboardAccountFrame.getExchangeTable();
            panelMainDashboard.Controls.Add(exchangeTbl);
        }
    }
}
