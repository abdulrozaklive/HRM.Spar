//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HRM.Spar.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class hrm_emp_termination_reason
    {
        public hrm_emp_termination_reason()
        {
            this.hrm_emp_termination = new HashSet<hrm_emp_termination>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
    
        public virtual ICollection<hrm_emp_termination> hrm_emp_termination { get; set; }
    }
}
