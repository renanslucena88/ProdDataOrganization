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

    /// <summary>
    /// Defines the <see cref="Content" />.
    /// </summary>
    public partial class Content
    {
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the FieldContent.
        /// </summary>
        public string FieldContent { get; set; }

        /// <summary>
        /// Gets or sets the IdField.
        /// </summary>
        public Nullable<int> IdField { get; set; }

        /// <summary>
        /// Gets or sets the Field.
        /// </summary>
        public virtual Field Field { get; set; }
    }
}
