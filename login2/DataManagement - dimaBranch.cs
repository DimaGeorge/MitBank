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
        public static string getIbanCurrency(string iban)
        {
            using (var context = new MitBankDBEntities2())
            {
                var result = context.showIBANInformations(iban).FirstOrDefault();
                return result.Currency.ToString();
            }
        }

        public static string getIbanSold(string iban)
        {
            using (var context = new MitBankDBEntities2())
            {
                var result = context.showIBANInformations(iban).FirstOrDefault();
                return result.Sold.ToString();
            }
        }

        public static string getIbanDate(string iban)
        {
            using (var context = new MitBankDBEntities2())
            {
                var result = context.showIBANInformations(iban).FirstOrDefault();
                return result.ValabilityUntil.ToString();
            }
        }

        public static string getIbanPacket(string iban)
        {
            using (var context = new MitBankDBEntities2())
            {
                var ibanInfo = context.showIBANInformations(iban).FirstOrDefault();
                TypeBankingPacket packet = (from c in context.TypeBankingPackets
                                            where c.ID == ibanInfo.BankPacket
                                            select c).First();
                return packet.NameTypePacket.ToString();
            }
        }

    }
}
