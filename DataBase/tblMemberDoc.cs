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
    
    public partial class tblMemberDoc
    {
        public int memberDocId { get; set; }
        public int memberId { get; set; }
        public string documentCategory { get; set; }
        public byte[] memberDocument { get; set; }
        public System.DateTime addedDate { get; set; }
        public byte addedBy { get; set; }
        public Nullable<System.DateTime> deleteDate { get; set; }
        public Nullable<byte> deletedBy { get; set; }
    
        public virtual tblMember tblMember { get; set; }
    }
}