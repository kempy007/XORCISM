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
    
    public partial class SECURITYATTRIBUTECATEGORY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SECURITYATTRIBUTECATEGORY()
        {
            this.SECURITYATTRIBUTE = new HashSet<SECURITYATTRIBUTE>();
            this.SECURITYATTRIBUTESTATE = new HashSet<SECURITYATTRIBUTESTATE>();
            this.SECURITYATTRIBUTEVARIETY = new HashSet<SECURITYATTRIBUTEVARIETY>();
        }
    
        public int SecurityAttributeCategoryID { get; set; }
        public string SecurityAttributeCategoryName { get; set; }
        public string SecurityAttributeCategoryDescription { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SECURITYATTRIBUTE> SECURITYATTRIBUTE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SECURITYATTRIBUTESTATE> SECURITYATTRIBUTESTATE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SECURITYATTRIBUTEVARIETY> SECURITYATTRIBUTEVARIETY { get; set; }
    }
}
