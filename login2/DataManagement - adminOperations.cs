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

        public static string getPass(string pass)
        {
            byte[] data = System.Text.Encoding.ASCII.GetBytes(pass);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            MessageBox.Show(System.Text.Encoding.GetEncoding("windows-1252").GetString(data));
            string g = System.Text.Encoding.GetEncoding("windows-1252").GetString(data);

            return g;
        }

        public static void addIndividualCustomer(Individual individ, string username, string password)
        {
            // Detached Entities
            //

            using (var context = new MitBankDBEntities2())
            {

               using (var transaction = context.Database.BeginTransaction())
               {
                    try
                    {
                        var verificat = from entry in context.Individuals
                                        where entry.CNP == individ.CNP
                                        select entry;

                        if (!verificat.Any())
                        {
                            context.Individuals.Add(individ);


                            var customer = new Customer
                            {
                                CustomerType = 1
                            };
                            context.Customers.Add(customer);


                            var individualCustomer = new IndividualCustomer
                            {
                                Customer = customer,
                                Individual = individ
                            };
                            context.IndividualCustomers.Add(individualCustomer);
                            context.SaveChanges();

                            var uname = new Username
                            {
                                UserType = 1,
                                Username1 = username,
                                Pass = password
                            };
                            context.Usernames.Add(uname);

                            var normalu = new NormalUser
                            {
                                Username = uname,
                                Customer = customer
                            };
                            context.NormalUsers.Add(normalu);
                            context.SaveChanges();
                           
                        }
                        else
                        {
                            throw new MitException("CNP deja existent in baza de date");
                        }

                    transaction.Commit();
                    }
                    catch (MitException e)
                    {
                        MessageBox.Show(e.Message);
                        transaction.Rollback();
                    }

                    catch (Exception e)
                    {
                        MessageBox.Show("Eroare netratata:" + e.Message);
                        MessageBox.Show(e.InnerException.GetBaseException().Message);
                        transaction.Rollback();
                    }
                }
            }
        }

        public static void addCompany(Individual individ, Company company, string username, string password)
        {
            // Detached Entities
            //

            using (var context = new MitBankDBEntities2())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var verificat = from entry in context.Individuals
                                        where entry.CNP == individ.CNP
                                        select entry;

                        if (!verificat.Any())
                        {
                            context.Individuals.Add(individ);

                            var customer = new Customer
                            {
                                CustomerType = 1
                            };
                            context.Customers.Add(customer);


                            company.Individual = individ;
                            company.Customer = customer;

                            context.Companies.Add(company);
                            context.SaveChanges();

                            var uname = new Username
                            {
                                UserType = 1,
                                Username1 = username,
                                Pass = password
                            };
                            context.Usernames.Add(uname);

                            var normalu = new NormalUser
                            {
                                Username = uname,
                                Customer = customer
                            };
                            context.NormalUsers.Add(normalu);
                            context.SaveChanges();
                        }
                        else
                        {
                            throw new MitException("CNP deja existent in baza de date");
                        }

                        transaction.Commit();
                    }
                    catch (MitException e)
                    {
                        MessageBox.Show(e.Message);
                        transaction.Rollback();
                    }

                    catch (Exception e)
                    {
                        MessageBox.Show("Eroare netratata:" + e.Message);
                        transaction.Rollback();
                    }
                }
            }
        }

    }
}
