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
    
    public partial class tblTransactionItem
    {
        public int TransactionItemID { get; set; }
        public int TransactionID { get; set; }
        public int ProductID { get; set; }
        public int TableID { get; set; }
    
        public virtual tblTable tblTable { get; set; }
        public virtual tblTransaction tblTransaction { get; set; }
        public virtual tblProduct tblProduct { get; set; }
    }
}