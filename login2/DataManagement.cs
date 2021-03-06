﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.Entity.Core.Objects;

namespace login2
{

    public static partial class DataManagement
    {
        static int IDSession;   
        public static bool tryConnection(string username,string password)
        {

            using (var context = new MitBankDBEntities())
            {
                if (context.getUandPProcedure(username, password).FirstOrDefault().HasValue)
                {
                    IDSession = context.getUandPProcedure(username, password).FirstOrDefault().Value;
                    
                    // exemplu de intoarcere parametru din procedura stocata
                    //
                    ObjectParameter output = new ObjectParameter("result", typeof(bool));
                    context.IsAdmin(IDSession, output);
                    if (Convert.ToBoolean(output.Value))
                    {
                        Form1.isAdmin = true;
                    }
                    //
                    
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
            using (var context = new MitBankDBEntities())
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
            using (var context = new MitBankDBEntities())
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

            using (var context = new MitBankDBEntities())
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

            using (var context = new MitBankDBEntities())
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

            using (var context = new MitBankDBEntities())
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

            using (var context = new MitBankDBEntities())
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


        public static string getLastName()
        {
            string lastName="Guest";


            using (var context = new MitBankDBEntities())
            {

                var result = context.selectOnIndividuals(IDSession);

                foreach ( var item in result)
                {
                    lastName = item.LastName.ToString();
                }

            }
            return lastName;
            
        }

        public static double getCurrencyValueBuy(string curr)
        {
            
            using (var context = new MitBankDBEntities())
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
         
            using (var context = new MitBankDBEntities())
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
            using (var context= new MitBankDBEntities())
            {
                var result = context.addHistoryTransaction(IDSession, userAccountIban
                    , toWichAccount, TypeTransaction, -val, DateTime.Now.ToString());

                var result2 = context.addHistoryTransaction(IDSession, toWichAccount, userAccountIban
                    ,TypeTransaction, +val, DateTime.Now.ToString());
            }

        }

        public static List<string> getAllInfoAccunts()
        {
            List<string> lc = new List<string>();

            using (var context = new MitBankDBEntities())
            {
                var result = context.showAllMyAccounts(IDSession);

                foreach (var item in result)
                {
                    
                    var result2 = context.showIBANInformations(item.ToString()).ToArray();
                    
                    foreach(var item2 in result2)
                    {
                        string info = item.ToString();

                        info = item2.ID + "       "+info + "       " + "       " + item2.BankPacket + "       " + item2.ValabilityUntil +
                            "       " + item2.Sold + "       " + item2.Currency;
                        lc.Add(info);

                    }
                }
            }


            return lc;
        }

    }
}
