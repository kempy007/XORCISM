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
    
    public partial class PHYSICALLOCATION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHYSICALLOCATION()
        {
            this.ASSETPHYSICALLOCATION = new HashSet<ASSETPHYSICALLOCATION>();
            this.PERSONBLACKLIST = new HashSet<PERSONBLACKLIST>();
            this.PERSONPHYSICALLOCATION = new HashSet<PERSONPHYSICALLOCATION>();
            this.PERSONWHITELIST = new HashSet<PERSONWHITELIST>();
            this.PHYSICALLOCATIONDESCRIPTION1 = new HashSet<PHYSICALLOCATIONDESCRIPTION>();
            this.PHYSICALLOCATIONTAG = new HashSet<PHYSICALLOCATIONTAG>();
        }
    
        public int PhysicalLocationID { get; set; }
        public string PhysicalLocationName { get; set; }
        public string PhysicalLocationDescription { get; set; }
        public Nullable<int> TrustLevelID { get; set; }
        public int VocabularyID { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<int> CreationObjectID { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ASSETPHYSICALLOCATION> ASSETPHYSICALLOCATION { get; set; }
        public virtual CREATIONOBJECT CREATIONOBJECT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERSONBLACKLIST> PERSONBLACKLIST { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERSONPHYSICALLOCATION> PERSONPHYSICALLOCATION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERSONWHITELIST> PERSONWHITELIST { get; set; }
        public virtual PHYSICALLOCATION PHYSICALLOCATION1 { get; set; }
        public virtual PHYSICALLOCATION PHYSICALLOCATION2 { get; set; }
        public virtual TRUSTLEVEL TRUSTLEVEL { get; set; }
        public virtual VOCABULARY VOCABULARY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHYSICALLOCATIONDESCRIPTION> PHYSICALLOCATIONDESCRIPTION1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHYSICALLOCATIONTAG> PHYSICALLOCATIONTAG { get; set; }
    }
}
