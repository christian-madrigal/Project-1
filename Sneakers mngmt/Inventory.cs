//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sneakers_mngmt
{
    using System;
    using System.Collections.Generic;
    
    public partial class Inventory
    {
        public int ItemID { get; set; }
        public byte[] ShoePic { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public decimal Size { get; set; }
        public int Qty { get; set; }
        public decimal Price { get; set; }
        public string Sku { get; set; }
    
        public virtual Customer Customer { get; set; }
    }
}