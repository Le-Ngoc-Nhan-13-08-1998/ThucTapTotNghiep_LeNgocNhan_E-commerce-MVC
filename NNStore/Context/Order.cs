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
    
    public partial class Order
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string RecciverName { get; set; }
        public string RecciverPhone { get; set; }
        public string RecciverEmail { get; set; }
        public string RecciverAdress { get; set; }
        public string Note { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedAt { get; set; }
        public int Status { get; set; }
    }
}
