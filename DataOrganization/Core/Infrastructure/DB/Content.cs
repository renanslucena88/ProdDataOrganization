//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataOrganization.Core.Infrastructure.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Content
    {
        public int Id { get; set; }
        public string FieldContent { get; set; }
        public Nullable<int> IdField { get; set; }
        public Nullable<int> Line { get; set; }
    
        public virtual Field Field { get; set; }
    }
}
