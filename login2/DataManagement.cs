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
        static string csName = "login2.Properties.Settings.MitBankDBConnectionString";
        private static bool tryConnection()
        {
            try
            {
                using (var puppetConnection = new SqlConnection(ConfigurationManager.ConnectionStrings[csName].ConnectionString))
                {
                    var querry = "SELECT 1";
                    var command = new SqlCommand(querry, puppetConnection);
                    puppetConnection.Open();
                    command.ExecuteScalar();
                }
            }
            catch
            {
                return false;
            }

            return true;
        }

        public static bool updateConnectionString(string username, string password)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            string newCs = "Persist Security Info=False;User ID=" + username + ";Password=" + password + ";Initial Catalog=MitBankDB;Server=.";
            connectionStringsSection.ConnectionStrings[csName].ConnectionString = newCs;
            config.Save();
            ConfigurationManager.RefreshSection("connectionStrings");

            // trying connection to SQL Server
            return tryConnection();
        }



        public static Page getDashboardInfo()
        {
            var context = new MitBankDBDataContext();
            var userObj = (from user in context.IndividualsViews
                           select user).FirstOrDefault();

            Page ret = new Page();
            ret.Data = userObj.ID + "\n"
                + userObj.FirstName + "\n"
                + userObj.LastName + "\n"
                + userObj.CNP + "\n"
                + userObj.Email + "\n";
            return ret;
        }
        public static Page getLastName()
        {
            var context = new MitBankDBDataContext();
            var userObj = (from user in context.IndividualsViews
                           select user).FirstOrDefault();

            Page ret = new Page();
            ret.Data = userObj.LastName;
                
            return ret;
        }


    }
}
