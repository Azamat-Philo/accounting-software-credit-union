﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataBase
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblAccount> tblAccounts { get; set; }
        public virtual DbSet<tblAccountMember> tblAccountMembers { get; set; }
        public virtual DbSet<tblAccountType> tblAccountTypes { get; set; }
        public virtual DbSet<tblBeneficiary> tblBeneficiaries { get; set; }
        public virtual DbSet<tblComiteeMember> tblComiteeMembers { get; set; }
        public virtual DbSet<tblEmployer> tblEmployers { get; set; }
        public virtual DbSet<tblEmployerAddress> tblEmployerAddresses { get; set; }
        public virtual DbSet<tblForm> tblForms { get; set; }
        public virtual DbSet<tblLoan> tblLoans { get; set; }
        public virtual DbSet<tblLoanType> tblLoanTypes { get; set; }
        public virtual DbSet<tblMember> tblMembers { get; set; }
        public virtual DbSet<tblMemberAddress> tblMemberAddresses { get; set; }
        public virtual DbSet<tblMemberDoc> tblMemberDocs { get; set; }
        public virtual DbSet<tblMemberEmployer> tblMemberEmployers { get; set; }
        public virtual DbSet<tblPermission> tblPermissions { get; set; }
        public virtual DbSet<tblTransaction> tblTransactions { get; set; }
        public virtual DbSet<tblUser> tblUsers { get; set; }
        public virtual DbSet<tblUserPermission> tblUserPermissions { get; set; }
        public virtual DbSet<tblLoanDoc> tblLoanDocs { get; set; }
        public virtual DbSet<tblLoanSurety> tblLoanSureties { get; set; }
    }
}
