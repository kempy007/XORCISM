//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XORCISMModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class PERSONFORASSET
    {
        public int PersonID { get; set; }
        public int AssetID { get; set; }
        public string relationshiptype { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public string RACIValue { get; set; }
        public Nullable<int> TrustLevelID { get; set; }
    
        public virtual ASSET ASSET { get; set; }
        public virtual PERSON PERSON { get; set; }
        public virtual TRUSTLEVEL TRUSTLEVEL { get; set; }
    }
}
