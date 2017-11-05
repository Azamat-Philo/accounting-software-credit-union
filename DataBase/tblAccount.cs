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
    
    public partial class tblAccount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblAccount()
        {
            this.tblTransactions = new HashSet<tblTransaction>();
            this.tblMembers = new HashSet<tblMember>();
        }
    
        public int accountId { get; set; }
        public int accountTypeId { get; set; }
        public Nullable<System.DateTime> dateAccountOpened { get; set; }
        public Nullable<System.DateTime> dateAccountClosed { get; set; }
        public int amount { get; set; }
        public bool closed { get; set; }
        public bool suspend { get; set; }
        public string accountRef { get; set; }
        public bool relatedToMember { get; set; }
    
        public virtual tblAccountType tblAccountType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTransaction> tblTransactions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMember> tblMembers { get; set; }
    }
}