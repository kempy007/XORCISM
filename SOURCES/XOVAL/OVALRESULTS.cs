//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XOVALModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class OVALRESULTS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OVALRESULTS()
        {
            this.OVALCLASSDIRECTIVES = new HashSet<OVALCLASSDIRECTIVES>();
        }
    
        public int OVALResultsID { get; set; }
        public int GeneratorTypeID { get; set; }
        public int OVALDefaultDirectivesID { get; set; }
        public Nullable<int> OVALDefinitionsID { get; set; }
        public int OVALResultsTypeID { get; set; }
        public string signature { get; set; }
    
        public virtual OVALDEFAULTDIRECTIVES OVALDEFAULTDIRECTIVES { get; set; }
        public virtual OVALGENERATORTYPE OVALGENERATORTYPE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OVALCLASSDIRECTIVES> OVALCLASSDIRECTIVES { get; set; }
    }
}
