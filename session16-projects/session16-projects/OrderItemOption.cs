//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace session16_projects
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderItemOption
    {
        public long Id { get; set; }
        public Nullable<System.Guid> StoreId { get; set; }
        public long OrderItemId { get; set; }
        public int ProductOptionId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    
        public virtual OrderItem OrderItem { get; set; }
        public virtual ProductOption ProductOption { get; set; }
    }
}
