//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityDomainTest.Domain1
{
    using System;
    using System.Collections.Generic;
    
    public partial class WorkflowStatus
    {
        public int Id { get; set; }
        public Nullable<int> ParentWorkflowStatusId { get; set; }
        public string WorkflowStatusType { get; set; }
        public string WorkflowItemKey { get; set; }
        public System.DateTime Created { get; set; }
        public Nullable<System.DateTime> Completed { get; set; }
        public int AreaId { get; set; }
        public bool Archiviert { get; set; }
    
        public virtual Area Area { get; set; }
    }
}
