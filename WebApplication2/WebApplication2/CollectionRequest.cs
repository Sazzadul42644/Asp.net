//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2
{
    using System;
    using System.Collections.Generic;
    
    public partial class CollectionRequest
    {
        public int Id { get; set; }
        public Nullable<int> RestaurantId { get; set; }
        public string PreservationTime { get; set; }
        public Nullable<System.DateTime> CollectionDate { get; set; }
        public string CollectionStatus { get; set; }
    
        public virtual Restaurant Restaurant { get; set; }
    }
}
