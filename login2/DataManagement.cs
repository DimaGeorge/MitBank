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
        static string csName = "MitBankDBEntities1";
        
        private static bool tryConnection(string username,string password)
        {

            using (var context = new MitBankDBEntities1())
            {
                

                int id = context.getUandPProcedure.SqlQuery(
                                            "getUandPProcedure @Username, @Password", username, password
                                          );
            }


            return true;
        }

        public static bool updateConnectionString(string username, string password)
        {
            //var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");

            //string newCs = "data source=.;initial catalog=MitBankDB;User ID=dbo" + ";Password=";
            //string completeCs = "metadata=res://*/MitBankModel.csdl|res://*/MitBankModel.ssdl|res://*/MitBankModel.msl;provider=System.Data.SqlClient;provider connection string=\"data source=.;initial catalog=MitBankDB;integrated security=false;MultipleActiveResultSets=true;User ID=" + username + ";Password=" + password + ";App=EntityFramework\"";

            //connectionStringsSection.ConnectionStrings[csName].ConnectionString = completeCs;
            //config.Save();
            //ConfigurationManager.RefreshSection("connectionStrings");

            //trying connection to SQL Server
            return tryConnection(username, password);
        }



        public static Page getDashboardInfo()
        {
            Page ret = new Page();
            ret.Data = "-";
            using (var context = new MitBankDBEntities1())
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
            using (var context = new MitBankDBEntities1())
            {
                var rez = from c in context.IndividualsViews
                          select c;

                foreach (var c in rez)
                {

                    ret.DataLastName = c.LastName;
                }
            }
            return ret;
        }


    }
}
