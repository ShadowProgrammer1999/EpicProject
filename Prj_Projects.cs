//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EpicProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Prj_Projects
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Prj_Projects()
        {
            this.Hrs_Team_Projects = new HashSet<Hrs_Team_Projects>();
            this.Prj_Epics = new HashSet<Prj_Epics>();
        }
    
        public decimal ProjectID { get; set; }
        public string Label { get; set; }
        public bool Enabled { get; set; }
        public string Reasons { get; set; }
        public string Purposes { get; set; }
        public string Owners { get; set; }
        public decimal ProjectTypeID { get; set; }
        public bool C_IsDeleted { get; set; }
        public Nullable<System.DateTime> C_LastModifyDate { get; set; }
        public Nullable<decimal> C_LastModifier { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hrs_Team_Projects> Hrs_Team_Projects { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Prj_Epics> Prj_Epics { get; set; }
    }
}