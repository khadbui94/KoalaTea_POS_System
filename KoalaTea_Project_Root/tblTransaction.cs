//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KoalaTea_Project_Root
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblTransaction
    {
        public tblTransaction()
        {
            this.tblTransactionItems = new HashSet<tblTransactionItem>();
        }
    
        public int TransactionID { get; set; }
        public Nullable<System.DateTime> TransactionDate { get; set; }
    
        public virtual ICollection<tblTransactionItem> tblTransactionItems { get; set; }
    }
}
