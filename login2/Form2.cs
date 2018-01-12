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
    public partial class Form2 : Form
    {
        static Panel lastMenupanel = new Panel();
        List<Label> ibanList = new List<Label>();
        Label exchangeLabel;

        public Form2()
        {
            InitializeComponent();
            panelMainDashboard.BackColor = Color.FromArgb(100, 100, 40);
            panelMainPaySomething.BackColor = Color.FromArgb(100, 100, 40);
            panelMainSendMail.BackColor = Color.FromArgb(100, 100, 40);
            panelMainSettings.BackColor = Color.FromArgb(100, 100, 40);
            panelMainTransfer.BackColor = Color.FromArgb(100, 100, 40);

            panelMainDashboard.Visible = true;
            panelMainPaySomething.Visible = false;
            panelMainSendMail.Visible = false;
            panelMainTransfer.Visible = false;
            panelMainSettings.Visible = false;

            pictureFailed.Visible = false;
            pictureValid.Visible = false;

            lastMenupanel = panelMainDashboard;
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

            panelMainDashboard.Controls.Add(UIDashboardAccountFrame.getExchangeTable());
        }

        private void label11_Click(object sender, EventArgs e)
        {
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
                    labelExchangeValue.Text = (Val / getToConvert).ToString();

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
                    labelExchangeValue.Text = (Val * getToConvertFrom / getToConvertTo).ToString();

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

                    double valToTransfer = 0;

                    valToTransfer = double.Parse(labelExchangeValue.Text);
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

                                }
                                else if (comboBoxSelectTransfer.SelectedItem.ToString() == "Anyone else account")
                                {
                                    var result = context.transferMoney(comboBoxIBAN.SelectedItem.ToString(),
                                        textBoxWriteIBAN.Text, ((ValWithouComiss + comiss)),
                                        valToTransfer);
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
                MessageBox.Show("Put all informations!");
            }
            
                
                


            }
        }
}

