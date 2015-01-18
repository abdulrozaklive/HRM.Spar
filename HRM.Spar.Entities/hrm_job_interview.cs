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
    
    public partial class hrm_job_interview
    {
        public hrm_job_interview()
        {
            this.hrm_job_candidate_history = new HashSet<hrm_job_candidate_history>();
            this.hrm_job_interview_attachment = new HashSet<hrm_job_interview_attachment>();
            this.hs_hr_employee = new HashSet<hs_hr_employee>();
        }
    
        public int id { get; set; }
        public Nullable<int> candidate_vacancy_id { get; set; }
        public Nullable<int> candidate_id { get; set; }
        public string interview_name { get; set; }
        public Nullable<System.DateTime> interview_date { get; set; }
        public Nullable<System.TimeSpan> interview_time { get; set; }
        public string note { get; set; }
    
        public virtual hrm_job_candidate hrm_job_candidate { get; set; }
        public virtual ICollection<hrm_job_candidate_history> hrm_job_candidate_history { get; set; }
        public virtual ICollection<hrm_job_interview_attachment> hrm_job_interview_attachment { get; set; }
        public virtual ICollection<hs_hr_employee> hs_hr_employee { get; set; }
    }
}