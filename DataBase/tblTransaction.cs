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
    
    public partial class tblTransaction
    {
        public long transactionId { get; set; }
        public bool action { get; set; }
        public int accountId { get; set; }
        public int amount { get; set; }
        public System.DateTime dateTransaction { get; set; }
        public byte[] timeTransaction { get; set; }
        public int transactionDoneBy { get; set; }
        public string comment { get; set; }
    
        public virtual tblAccount tblAccount { get; set; }
    }
}
