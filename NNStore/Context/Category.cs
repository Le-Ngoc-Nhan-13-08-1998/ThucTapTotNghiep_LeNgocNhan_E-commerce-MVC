//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NNStore.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class Category
    {
        public int Id { get; set; }
        public string Img { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public Nullable<int> ParentId { get; set; }
        public Nullable<int> Orders { get; set; }
        public string MetaDesc { get; set; }
        public Nullable<bool> ShowOnHomePage { get; set; }
        public string MetaKey { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedAt { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<int> Status { get; set; }
    }
}
