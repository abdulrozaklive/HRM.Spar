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
    
    public partial class hrm_employment_status
    {
        public hrm_employment_status()
        {
            this.hs_hr_employee = new HashSet<hs_hr_employee>();
            this.hrm_job_title = new HashSet<hrm_job_title>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
    
        public virtual ICollection<hs_hr_employee> hs_hr_employee { get; set; }
        public virtual ICollection<hrm_job_title> hrm_job_title { get; set; }
    }
}