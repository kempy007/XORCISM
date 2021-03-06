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
    
    public partial class REGULATORYRISK
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public REGULATORYRISK()
        {
            this.BUSINESSIMPACTFORREGULATORYRISK = new HashSet<BUSINESSIMPACTFORREGULATORYRISK>();
            this.USECASEFORREGULATORYRISK = new HashSet<USECASEFORREGULATORYRISK>();
        }
    
        public int RegulatoryRiskID { get; set; }
        public string RegulatoryRiskGUID { get; set; }
        public string RiskDescription { get; set; }
        public Nullable<int> VocabularyID { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BUSINESSIMPACTFORREGULATORYRISK> BUSINESSIMPACTFORREGULATORYRISK { get; set; }
        public virtual VOCABULARY VOCABULARY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USECASEFORREGULATORYRISK> USECASEFORREGULATORYRISK { get; set; }
    }
}
