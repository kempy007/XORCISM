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
    
    public partial class RECOMMENDATIONAUDITPROCEDURE
    {
        public int RecommendationAuditProcedureID { get; set; }
        public int RecommendationID { get; set; }
        public int AuditProcedureID { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public string RecommendationAuditProcedureName { get; set; }
        public string RecommendationAuditProcedureDescription { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<int> VocabularyID { get; set; }
    
        public virtual AUDITPROCEDURE AUDITPROCEDURE { get; set; }
        public virtual RECOMMENDATION RECOMMENDATION { get; set; }
        public virtual VOCABULARY VOCABULARY { get; set; }
    }
}