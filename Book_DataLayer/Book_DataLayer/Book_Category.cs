//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Book_DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book_Category
    {
        public int ID { get; set; }
        public Nullable<int> book_ID { get; set; }
        public Nullable<int> category_ID { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual Category Category { get; set; }
    }
}
