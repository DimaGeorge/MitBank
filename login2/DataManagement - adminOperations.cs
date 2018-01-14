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
        public static void cashDeposit()
        {
            using (var context = new MitBankDBEntities2())
            {
                // exemplu de utilizare tranzactie din Entity Framework
                //
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        string iban = "RO93MITB0410120579132411";
                        int sum = -123;
                        if (sum < 1)
                        {
                            throw new MitException("Poti depune cel putin o unitate monetara");
                        }

                        var account = context.UserAccounts.Single(obj => obj.AccountNumber.Trim() == iban);
                        if (account != null)
                        {
                            account.Sold += sum;
                        }
                        else
                        {
                            throw new MitException("Cont negasit!");
                        }

                        transaction.Commit();
                        MessageBox.Show("depunereNumerar");
                    }

                    catch (Exception e)
                    {
                        transaction.Rollback();
                        MessageBox.Show(e.Message);
                    }

                }
            }
        }


        public static void addNewIndividual()
        {
            var individ = new Individual
            {
                FirstName = "Aureliu",
                LastName = "Alexandru",
                Email = "aalexandru@mail.com",
                Birthday = new DateTime(2000, 5, 25),
                CNP = "1234567890129",
                
            };

            using (var context = new MitBankDBEntities2())
            {
                try
                {
                    var verificat = from entry in context.Individuals
                                    where entry.CNP == individ.CNP
                                    select entry;
                    
                    if (!verificat.Any())
                    {
                        context.Individuals.Add(individ);
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new MitException("CNP deja existent in baza de date");
                    }
                }
                catch (MitException e)
                {
                    MessageBox.Show(e.Message);
                }

                catch (Exception e)
                {
                    MessageBox.Show("Eroare netratata:" + e.Message);
                }
            }
        }

    }
}
