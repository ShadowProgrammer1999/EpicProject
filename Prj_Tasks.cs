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
    
    public partial class Prj_Tasks
    {
        public decimal TaskID { get; set; }
        public string Label { get; set; }
        public int InitialEstimate { get; set; }
        public int CurrentEstimate { get; set; }
        public bool Enabled { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime DueDate { get; set; }
        public Nullable<System.DateTime> CompleteDate { get; set; }
        public Nullable<System.DateTime> ApproveDate { get; set; }
        public Nullable<System.DateTime> CloseDate { get; set; }
        public string TaskDoD { get; set; }
        public string Description { get; set; }
        public string Attachment1 { get; set; }
        public string Attachment2 { get; set; }
        public string Attachment3 { get; set; }
        public string Attachment4 { get; set; }
        public string Attachment5 { get; set; }
        public string Attachment6 { get; set; }
        public decimal EpicID { get; set; }
        public decimal TaskTypeID { get; set; }
        public decimal PriorityID { get; set; }
        public decimal StatusID { get; set; }
        public decimal UserID { get; set; }
        public Nullable<decimal> IssueID { get; set; }
        public bool C_IsDeleted { get; set; }
        public Nullable<System.DateTime> C_LastModifyDate { get; set; }
        public Nullable<decimal> C_LastModifier { get; set; }
    
        public virtual Prj_Epics Prj_Epics { get; set; }
        public virtual Sys_Users Sys_Users { get; set; }
    }
}
