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
    
    public partial class Prj_Epics
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Prj_Epics()
        {
            this.Prj_Tasks = new HashSet<Prj_Tasks>();
        }
    
        public decimal EpicID { get; set; }
        public string Label { get; set; }
        public int InitialEstimate { get; set; }
        public int CurrentEstimate { get; set; }
        public bool Enabled { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime DueDate { get; set; }
        public string Quater { get; set; }
        public Nullable<System.DateTime> CompleteDate { get; set; }
        public Nullable<System.DateTime> ApproveDate { get; set; }
        public string Origin { get; set; }
        public bool AccordingToPlan { get; set; }
        public string EpicDoD { get; set; }
        public string Attachment1 { get; set; }
        public string Attachment2 { get; set; }
        public string Attachment3 { get; set; }
        public string Attachment4 { get; set; }
        public string Attachment5 { get; set; }
        public string Attachment6 { get; set; }
        public Nullable<decimal> ProductBranchID { get; set; }
        public decimal EpicTypeID { get; set; }
        public decimal TeamID { get; set; }
        public decimal PriorityID { get; set; }
        public decimal StatusID { get; set; }
        public decimal ProjectID { get; set; }
        public bool C_IsDeleted { get; set; }
        public Nullable<System.DateTime> C_LastModifyDate { get; set; }
        public Nullable<decimal> C_LastModifier { get; set; }
    
        public virtual Prj_Projects Prj_Projects { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Prj_Tasks> Prj_Tasks { get; set; }
    }
}