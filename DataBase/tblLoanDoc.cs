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
    
    public partial class tblLoanDoc
    {
        public int loanId { get; set; }
        public Nullable<byte> type { get; set; }
        public byte[] doc { get; set; }
        public System.DateTime dateUpload { get; set; }
    
        public virtual tblLoan tblLoan { get; set; }
    }
}