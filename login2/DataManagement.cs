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


        public static Page getDashboardInfo()
        {
            Page ret = new Page();
            ret.Data = "-";
            using (var context = new MitBankDBEntities2())
            {
                
                var rez = from c in context.Usernames
                          select c;
                
                foreach (var c in rez)
                {
                    MessageBox.Show(c.Username1);
                    ret.Data = c.Pass;

                }
                
            }
            
            return ret;
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
