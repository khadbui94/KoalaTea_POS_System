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
    
    public partial class tblProduct
    {
        public tblProduct()
        {
            this.tblTransactionItems = new HashSet<tblTransactionItem>();
        }
    
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public byte[] Image { get; set; }
        public byte[] selectedImage { get; set; }
    
        public virtual ICollection<tblTransactionItem> tblTransactionItems { get; set; }
        public virtual tblCategory tblCategory { get; set; }
    }
}