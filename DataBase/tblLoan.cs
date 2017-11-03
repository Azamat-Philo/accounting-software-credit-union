//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class tblLoan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblLoan()
        {
            this.tblLoanDocs = new HashSet<tblLoanDoc>();
            this.tblLoanSureties = new HashSet<tblLoanSurety>();
        }
    
        public int loanId { get; set; }
        public short loanTypeId { get; set; }
        public System.DateTime createdDate { get; set; }
        public Nullable<int> memberEmployerId { get; set; }
        public int memberId { get; set; }
        public int loanAmount { get; set; }
        public Nullable<System.DateTime> approvedDate { get; set; }
        public Nullable<System.DateTime> refuseDate { get; set; }
        public Nullable<bool> approved { get; set; }
        public Nullable<int> basicSalary { get; set; }
        public Nullable<bool> refuse { get; set; }
        public Nullable<System.DateTime> repaymentBegin { get; set; }
        public Nullable<System.DateTime> repaymentEnd { get; set; }
        public string reasonRefused { get; set; }
        public Nullable<System.DateTime> earlyRepayment { get; set; }
        public bool paid { get; set; }
    
        public virtual tblLoanType tblLoanType { get; set; }
        public virtual tblMember tblMember { get; set; }
        public virtual tblMemberEmployer tblMemberEmployer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblLoanDoc> tblLoanDocs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblLoanSurety> tblLoanSureties { get; set; }
    }
}
