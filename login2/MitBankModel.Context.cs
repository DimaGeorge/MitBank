﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace login2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class MitBankDBEntities1 : DbContext
    {
        public MitBankDBEntities1()
            : base("name=MitBankDBEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<CompaniesView> CompaniesViews { get; set; }
        public DbSet<CustomersView> CustomersViews { get; set; }
        public DbSet<HistoryTransactionView> HistoryTransactionViews { get; set; }
        public DbSet<IndividualsView> IndividualsViews { get; set; }
        public DbSet<UserAccountsView> UserAccountsViews { get; set; }
        public DbSet<UsernamesView> UsernamesViews { get; set; }
        public DbSet<AccountType> AccountTypes { get; set; }
        public DbSet<BankAdmin> BankAdmins { get; set; }
        public DbSet<BankingPacket> BankingPackets { get; set; }
        public DbSet<ComisionStatu> ComisionStatus { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerType> CustomerTypes { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<HistoryTransaction> HistoryTransactions { get; set; }
        public DbSet<IndividualCustomer> IndividualCustomers { get; set; }
        public DbSet<Individual> Individuals { get; set; }
        public DbSet<NormalUser> NormalUsers { get; set; }
        public DbSet<TypeBankingPacket> TypeBankingPackets { get; set; }
        public DbSet<TypesTransaction> TypesTransactions { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }
        public DbSet<Username> Usernames { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
    
        public virtual int AddBankAdmin(Nullable<int> iDemployee, string username, string password)
        {
            var iDemployeeParameter = iDemployee.HasValue ?
                new ObjectParameter("IDemployee", iDemployee) :
                new ObjectParameter("IDemployee", typeof(int));
    
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddBankAdmin", iDemployeeParameter, usernameParameter, passwordParameter);
        }
    
        public virtual int AddNormalUser(Nullable<int> iDcustomer, string username, string password)
        {
            var iDcustomerParameter = iDcustomer.HasValue ?
                new ObjectParameter("IDcustomer", iDcustomer) :
                new ObjectParameter("IDcustomer", typeof(int));
    
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddNormalUser", iDcustomerParameter, usernameParameter, passwordParameter);
        }
    
        public virtual ObjectResult<Nullable<short>> getUandPProcedure(string username, string password)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<short>>("getUandPProcedure", usernameParameter, passwordParameter);
        }
    }
}