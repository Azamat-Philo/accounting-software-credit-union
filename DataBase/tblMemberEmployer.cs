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
    
    public partial class tblMemberEmployer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblMemberEmployer()
        {
            this.tblLoans = new HashSet<tblLoan>();
        }
    
        public int memberEmployerId { get; set; }
        public short employerId { get; set; }
        public Nullable<int> memberId { get; set; }
        public byte[] dateEntry { get; set; }
        public Nullable<System.DateTime> dateLeft { get; set; }
        public string position { get; set; }
        public string comment { get; set; }
    
        public virtual tblEmployer tblEmployer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblLoan> tblLoans { get; set; }
        public virtual tblMember tblMember { get; set; }
    }
}
