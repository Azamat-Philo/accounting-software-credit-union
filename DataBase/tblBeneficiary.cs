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
    
    public partial class tblBeneficiary
    {
        public int beneficiaryId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string nic { get; set; }
        public Nullable<System.DateTime> dateCreated { get; set; }
        public string comments { get; set; }
        public int createdBy { get; set; }
        public bool active { get; set; }
    }
}