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
    
    public partial class hs_hr_emp_history_of_ealier_pos
    {
        public int emp_number { get; set; }
        public decimal emp_seqno { get; set; }
        public string ehoep_job_title { get; set; }
        public string ehoep_years { get; set; }
    
        public virtual hs_hr_employee hs_hr_employee { get; set; }
    }
}
