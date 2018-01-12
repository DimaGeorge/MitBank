using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace login2
{

    public static partial class DataManagement
    {
        static int IDSession;   
        public static bool tryConnection(string username,string password)
        {
            using (var context = new MitBankDBEntities2())
            {
                if(context.getUandPProcedure(username, password).FirstOrDefault().HasValue)
                {
                    IDSession = context.getUandPProcedure(username, password).FirstOrDefault().Value;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static int getIdUsername()
        {
            return IDSession;
        }

        public static List<string> getDashboardInfo()
        {
            List<string> list = new List<string>();
            using (var context = new MitBankDBEntities2())
            {
                var conturi = context.showAllMyAccounts(IDSession).ToArray();
                foreach (var item in conturi)
                {
                    list.Add(item.ToString());
                }
            }
            return list;
        }
        public static Page getComision(string accNr)
        {

            Page pg = new Page();
            using (var context = new MitBankDBEntities2())
            {
                if (IDSession != 0&&accNr!="")
                {

                    var result = context.takeComision(4, accNr).ToArray();
                    
                    foreach (var item in result)
                    {
                        if (item.HasValue==true)
                            pg.Data = item.ToString();
                        else
                            pg.Data = ""; 
                    }
                }
            }



            return pg;
        }

        public static List<Page> getIbanList()
        {
            List<Page> listIban = new List<Page>();

            using (var context = new MitBankDBEntities2())
            {
                if (IDSession != 0)
                {

                    var result = context.showAllMyAccounts(IDSession).ToArray();
                    foreach (var item in result)
                    {
                        Page pg = new Page();
                        pg.Data = item.ToString();
                        listIban.Add(pg);
                    }
                }
            }
            
            return listIban;

        }

        public static Page getSold(string iban)
        {

            using (var context = new MitBankDBEntities2())
            {
                Page pg = new Page();
                if (IDSession != 0)
                {

                    var result = context.showIBANInformations(iban).ToArray();
                    foreach (var item in result)
                    {

                        pg.Data = item.Sold.ToString();

                    }
                }
                return pg;
            }
        }


        public static Page getCurrency(string iban)
        {

            using (var context = new MitBankDBEntities2())
            {
                Page pg = new Page();
                if (IDSession != 0)
                {

                    var result = context.showIBANInformations(iban).ToArray();
                    foreach (var item in result)
                    {

                        pg.Data = item.Currency.ToString();

                    }
                }
                return pg;
            }
        }


        public static Page getCurrencyAnyone(string iban)
        {

            using (var context = new MitBankDBEntities2())
            {
                Page pg = new Page();
                if (IDSession != 0)
                {

                    var result = context.getAnyoneCurrency(iban);
                    foreach (var item in result)
                    {

                        pg.Data = item.ToString();

                    }
                }
                return pg;
            }
        }


        public static Page getLastName()
        {

            Page ret = new Page();
            ret.DataLastName = "Guest";
            /*
            using (var context = new MitBankDBEntities())
            {
                var rez = from c in context.IndividualsViews
                          select c;

                foreach (var c in rez)
                {

                    ret.DataLastName = c.LastName;
                }
            }*/
            return ret;
        }

        public static double getCurrencyValueBuy(string curr)
        {
            
            using (var context = new MitBankDBEntities2())
            {
                var exchInfo = from c in context.CurrentCurrencies
                               select c;
                foreach (var item in exchInfo)
                {
                    if (item.CurrencyName == curr)
                    {
                        return item.ValueBuy;
                    }
                }
            }
            return 0;
        }
        public static double getCurrencyValueSell(string curr)
        {
         
            using (var context = new MitBankDBEntities2())
            {
                var exchInfo = from c in context.CurrentCurrencies
                               select c;
                foreach (var item in exchInfo)
                {
                    if (item.CurrencyName == curr)
                    {
                        return item.ValueSel;
                    }
                }
            }
            return 0;
        }
        public static void addOnHistory(string userAccountIban,
                    string toWichAccount,int TypeTransaction,double val)
        {
            using (var context= new MitBankDBEntities2())
            {
                var result = context.addHistoryTransaction(IDSession, userAccountIban
                    , toWichAccount, TypeTransaction, val, DateTime.Now.ToString());
            }

        }


    }
}
