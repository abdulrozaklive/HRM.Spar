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
    
    public partial class hrm_performance_review
    {
        public hrm_performance_review()
        {
            this.hrm_reviewer = new HashSet<hrm_reviewer>();
            this.hrm_reviewer_rating = new HashSet<hrm_reviewer_rating>();
        }
    
        public int id { get; set; }
        public Nullable<int> status_id { get; set; }
        public Nullable<int> employee_number { get; set; }
        public Nullable<System.DateTime> work_period_start { get; set; }
        public Nullable<System.DateTime> work_period_end { get; set; }
        public Nullable<int> job_title_code { get; set; }
        public Nullable<int> department_id { get; set; }
        public Nullable<System.DateTime> due_date { get; set; }
        public Nullable<System.DateTime> completed_date { get; set; }
        public Nullable<System.DateTime> activated_date { get; set; }
        public string final_comment { get; set; }
        public Nullable<decimal> final_rate { get; set; }
    
        public virtual hs_hr_employee hs_hr_employee { get; set; }
        public virtual ICollection<hrm_reviewer> hrm_reviewer { get; set; }
        public virtual ICollection<hrm_reviewer_rating> hrm_reviewer_rating { get; set; }
    }
}
