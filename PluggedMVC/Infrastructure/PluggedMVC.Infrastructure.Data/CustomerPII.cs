//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PluggedMVC.Infrastructure.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class CustomerPII
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SSN { get; set; }
        public string CreditCardNumber { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public Nullable<int> TerritoryID { get; set; }
    }
}