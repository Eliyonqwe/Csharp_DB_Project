//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Csharp_DB_Project.DBq
{
    using System;
    using System.Collections.Generic;
    
    public partial class offerList
    {
        public int offerID { get; set; }
        public Nullable<int> offeringUserID { get; set; }
        public string companyName { get; set; }
        public string companyType { get; set; }
        public decimal amount { get; set; }
        public decimal price { get; set; }
        public decimal offerAmount { get; set; }
        public string offerStatus { get; set; }
    }
}