//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Beetle.Client.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(CompanyMetadata))]
    public partial class Company : NamedEntity
    {
        public Nullable<System.Guid> AddressId { get; set; }
        public string CompanyNo { get; set; }
        public CompanyType CompanyType { get; set; }
    
        public virtual Address Address { get; set; }
    }
    
    public partial class CompanyMetadata { }
}