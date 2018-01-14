using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using MigraDoc.DocumentObjectModel;
using System.Diagnostics;

namespace login2
{
    public partial class Form2 : Form
    {
        static Panel lastMenupanel = new Panel();
        List<Label> ibanList = new List<Label>();
        Label exchangeTbl;
        public Form2()
        {
            InitializeComponent();
            panelMainDashboard.BackColor = System.Drawing.Color.FromArgb(100, 100, 40);
            panelMainPaySomething.BackColor = System.Drawing.Color.FromArgb(100, 100, 40);
            panelMainSendMail.BackColor = System.Drawing.Color.FromArgb(100, 100, 40);
            panelMainSettings.BackColor = System.Drawing.Color.FromArgb(100, 100, 40);
            panelMainTransfer.BackColor = System.Drawing.Color.FromArgb(100, 100, 40);

            panelMainDashboard.Visible = true;
            panelMainPaySomething.Visible = false;
            panelMainSendMail.Visible = false;
            panelMainTransfer.Visible = false;
            panelMainSettings.Visible = false;

            pictureFailed.Visible = false;
            pictureValid.Visible = false;
            lastMenupanel = panelMainDashboard;

            UIDashboardAccountFrame.generateDashboard(ibanList, panelMainDashboard, exchangeTbl);
            labelLastName.Text = DataManagement.getLastName();
            using (var context = new MitBankDBEntities2())
            {
                var result2 = context.getLastLogin(DataManagement.getIdUsername());
                foreach ( var item in result2)
                {
                    labelLastLogin.Text = item.ToString();
                }
            }

        }

        private void label11_Click(object sender, EventArgs e)
        {
            using (var context = new MitBankDBEntities2())
            {
                var result = context.insertLastLogin(DataManagement.getIdUsername(), DateTime.Now.ToString());

            }
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

            UIDashboardAccountFrame.generateDashboard(ibanList, panelMainDashboard, exchangeTbl);

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


            using (var context = new MitBankDBEntities2())
            {


                List<Page> listIban = new List<Page>();
                listIban = DataManagement.getIbanList();
                foreach (var item in listIban)
                {
                    int index = -1;
                    index = comboBoxIBAN.FindString(item.Data.ToString());

                    if (index == -1)
                    {
                        comboBoxIBAN.Items.Add(item.Data.ToString());
                    }

                }
                if (listIban.Count() != 0)
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

            var result = MessageBox.Show("Are you sure?", "Info",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (var context = new MitBankDBEntities2())
                {
                    var result2 = context.insertLastLogin(DataManagement.getIdUsername(), DateTime.Now.ToString());

                }
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

                    if (index == -1 && item.Data.ToString() != comboBoxIBAN.Text.ToString())
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
                labelcurrencyToIban.Text = "-";

            }

        }

        private void textoxValueToTransfer_OnValueChanged(object sender, EventArgs e)
        {

            int parsedValue;
            if (!int.TryParse(textoxValueToTransfer.Text, out parsedValue))
            {
                if (textoxValueToTransfer.Text != "")
                {
                    MessageBox.Show("Ups! Only numbers");
                    textoxValueToTransfer.Text = "0";
                }

            }


            double Val = 0;
            if (labelshowcurrency.Text != labelcurrencyToIban.Text
                && labelcurrencyToIban.Text != "-" && textoxValueToTransfer.Text != "")
            {
                if (labelshowcurrency.Text == "RON")
                {
                    double getToConvert = DataManagement.getCurrencyValueBuy(labelcurrencyToIban.Text);
                    Val = double.Parse(textoxValueToTransfer.Text);
                    double exch = Math.Round(Val / getToConvert, 4);
                    labelExchangeValue.Text = exch.ToString();

                    labelshowToCurrency.Text = labelcurrencyToIban.Text;
                    labelshowFromCurrency.Text = labelshowcurrency.Text;
                }
                else if (labelcurrencyToIban.Text == "RON")
                {
                    double getToConvert = DataManagement.getCurrencyValueBuy(labelshowcurrency.Text);
                    Val = double.Parse(textoxValueToTransfer.Text);
                    labelExchangeValue.Text = (Val * getToConvert).ToString();

                    labelshowToCurrency.Text = labelcurrencyToIban.Text;
                    labelshowFromCurrency.Text = labelshowcurrency.Text;
                }
                else if (labelcurrencyToIban.Text != "RON" && labelshowcurrency.Text != "RON")
                {
                    double getToConvertFrom = DataManagement.getCurrencyValueBuy(labelshowcurrency.Text);
                    double getToConvertTo = DataManagement.getCurrencyValueBuy(labelcurrencyToIban.Text);

                    Val = double.Parse(textoxValueToTransfer.Text);
                    double exch = Math.Round(Val * getToConvertFrom / getToConvertTo, 2);
                    labelExchangeValue.Text = exch.ToString();

                    labelshowToCurrency.Text = labelcurrencyToIban.Text;
                    labelshowFromCurrency.Text = labelshowcurrency.Text;

                }
            }

            string fromIBAN = comboBoxIBAN.Text;
            Page pg = new Page();

            ///////////////////make txt for numberrs


            if (pg.Data != "" && comboBoxIBAN.SelectedIndex != -1)
            {
                pg = DataManagement.getComision(fromIBAN.ToString());
            }



            if (textoxValueToTransfer.Text != "" && comboBoxIBAN.SelectedIndex != -1)
            {
                Val = double.Parse(textoxValueToTransfer.Text);

                double comVal = 0;

                comVal = double.Parse(pg.Data);

                labelComisionValue.Text = (Val * comVal / 100).ToString();
            }
            else
            {
                labelComisionValue.Text = "-";
            }




        }

        private void comboBoxToTransferMyIBAN_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currencyFromIBAN = "-";
            string currencyToIBAN = "-";

            using (var context = new MitBankDBEntities2())
            {

                if (comboBoxToTransferMyIBAN.SelectedIndex != -1)
                {
                    var result = context.getAnyoneCurrency(comboBoxToTransferMyIBAN.Text).ToArray();
                    foreach (var item in result)
                    {
                        currencyToIBAN = item.ToString();
                    }
                    labelcurrencyToIban.Text = currencyToIBAN;
                }



            }
        }



        private void textBoxWriteIBAN_OnValueChanged(object sender, EventArgs e)
        {
            string getIBANfromTextBox = textBoxWriteIBAN.Text;
            Page pg = new Page();
            using (var context = new MitBankDBEntities2())
            {

                var result = context.getAnyoneCurrency(getIBANfromTextBox).ToArray();
                if (result.Length != 0)
                {


                    pictureValid.Visible = true;
                    pictureFailed.Visible = false;
                    var result2 = context.getAnyoneCurrency(getIBANfromTextBox.ToString()).ToArray();
                    foreach (var item in result2)
                    {
                        labelcurrencyToIban.Text = item.ToString();
                    }
                }
                else
                {
                    pictureFailed.Visible = true;
                    pictureValid.Visible = false;
                    labelcurrencyToIban.Text = "-";
                }


            }
        }

        private void buttonSubmitTransfer_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo);
            try
            {
                if (dialogResult == DialogResult.Yes)
                {
                    double ValWithouComiss = 0;

                    ValWithouComiss = double.Parse(textoxValueToTransfer.Text);

                    double comiss = 0;

                    comiss = double.Parse(labelComisionValue.Text);

                    double valToTransfer = 1;
                    if (labelExchangeValue.Text != "-")
                    {
                        valToTransfer = double.Parse(labelExchangeValue.Text);
                    }
                    
                    double getsold = 0;
                    if (labelComisionValue.Text != "-")
                    {
                        using (var context = new MitBankDBEntities2())
                        {
                            var result = DataManagement.getSold(comboBoxIBAN.SelectedItem.ToString());

                            getsold = double.Parse(result.Data);

                        }
                        if (getsold > (ValWithouComiss + comiss))
                        {
                            using (var context = new MitBankDBEntities2())
                            {
                                if (comboBoxSelectTransfer.SelectedItem.ToString() == "My another account")
                                {
                                    
                                    var result = context.transferMoney(comboBoxIBAN.SelectedItem.ToString(),
                                        comboBoxToTransferMyIBAN.SelectedItem.ToString(), ((ValWithouComiss + comiss)),
                                        valToTransfer);
                                    DataManagement.addOnHistory(comboBoxIBAN.SelectedItem.ToString(),
                                        comboBoxToTransferMyIBAN.SelectedItem.ToString(), 4, (ValWithouComiss + comiss));

                                }
                                else if (comboBoxSelectTransfer.SelectedItem.ToString() == "Anyone else account")
                                {
                                    var result = context.transferMoney(comboBoxIBAN.SelectedItem.ToString(),
                                        textBoxWriteIBAN.Text, ((ValWithouComiss + comiss)),
                                        valToTransfer);

                                    DataManagement.addOnHistory(comboBoxIBAN.SelectedItem.ToString(),
                                      textBoxWriteIBAN.Text, 4, (ValWithouComiss + comiss));

                                }
                                labelComisionValue.Text = "-";
                                labelExchangeValue.Text = "-";
                                MessageBox.Show("Done!");

                            }

                        }
                        else
                        {
                            MessageBox.Show("You dont have enought money!!!");
                        }
                    }
                }
            }catch (Exception )
            {
                MessageBox.Show("Put all informations or something wrong!");
            }
            
                
                


            }

        private void buttonHistoryTransaction_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            this.Width = 1200;
=======



        }

        private void button1_Click(object sender, EventArgs e)
        {
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Account request informations";

            // Create an empty page
            PdfPage page = document.AddPage();

            // Get an XGraphics object for drawing
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Create a font
            XFont font = new XFont("Verdana", 11, XFontStyle.Regular);

            // Draw the text
            string infoBank = "MITBank Society, Military Technical Academy";
            string infoBank2 = "Sucursala Bucuresti, Sector 4";
            string text1 = "Extras de cont din "+ DateTime.Now.ToString() ;
            string text2 = "      Conform dispozitiilor in vigoare, va instiintăm ca, in evidenţele";
            string text3 = "noastre contabile, la data de ............., unitatea dvs. figurează";
            string text4 = "cu următoarele conturi................................................";
            string text5 = "Conturi curente ";

            gfx.DrawString(infoBank, font, XBrushes.Black,
              new XRect(10, 0, page.Width, page.Height),
              XStringFormats.TopLeft);

            gfx.DrawString(infoBank2, font, XBrushes.Black,
              new XRect(10, 12, page.Width, page.Height),
              XStringFormats.TopLeft);

            gfx.DrawString(text1, font, XBrushes.Black,
              new XRect(10, 32, page.Width, page.Height),
              XStringFormats.TopCenter);

            gfx.DrawString(text2, font, XBrushes.Black,
              new XRect(10, 60, page.Width, page.Height),
              XStringFormats.TopLeft);

            gfx.DrawString(text3, font, XBrushes.Black,
              new XRect(10, 72, page.Width, page.Height),
              XStringFormats.TopLeft);

            gfx.DrawString(text4, font, XBrushes.Black,
              new XRect(10, 84, page.Width, page.Height),
              XStringFormats.TopLeft);
            gfx.DrawString(text5, font, XBrushes.Black,
              new XRect(10, 100, page.Width, page.Height),
              XStringFormats.TopCenter);



            List<string> lc= new List<string>();
            lc = DataManagement.getAllInfoAccunts();
            
            
            string text11 = "ID" + "       " + "IBAN" + "                                       "
                + "Bank Packet" + "              " + "VALABILITY" + "              " + "SOLD" + "       " + "CURRENCY";
            gfx.DrawString(text11, font, XBrushes.Black,
                new XRect(30, 130, page.Width, page.Height),
                XStringFormats.TopLeft);

            int x = 160;
            foreach (string c in lc)
            {
                string text0 = c.ToString();
                
                gfx.DrawString(text0, font, XBrushes.Black,
                new XRect(30, x, page.Width, page.Height),
                XStringFormats.TopLeft);
                x += 20;
            }

            string text12 = "Pentru mai multe informatii, contactati-ne la 0722222222, director adjunct SSSSSSS  SSS";

            gfx.DrawString(text12, font, XBrushes.Black,
                new XRect(30, 300, page.Width, page.Height),
                XStringFormats.TopLeft);

            // Save the document...
            string filename = "Account request " + DataManagement.getLastName() ;
            document.Save(filename);
            // ...and start a viewer.
            Process.Start(filename);
>>>>>>> scriban-branch-1


        }
    }
}

