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

    public static class DataManagement
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


    }
}
