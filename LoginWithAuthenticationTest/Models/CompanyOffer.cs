//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoginWithAuthenticationTest.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CompanyOffer
    {
        public int CompanyOfferID { get; set; }
        public int CompanyID { get; set; }
        public int LanguageID { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string Location { get; set; }
        public Nullable<int> Experience { get; set; }
        public string Description { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual Language Language { get; set; }
    }
}
