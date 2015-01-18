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
    
    public partial class hs_hr_emp_basicsalary
    {
        public hs_hr_emp_basicsalary()
        {
            this.hs_hr_emp_directdebit = new HashSet<hs_hr_emp_directdebit>();
        }
    
        public int id { get; set; }
        public int emp_number { get; set; }
        public Nullable<int> sal_grd_code { get; set; }
        public string currency_id { get; set; }
        public string ebsal_basic_salary { get; set; }
        public string payperiod_code { get; set; }
        public string salary_component { get; set; }
        public string comments { get; set; }
    
        public virtual hrm_pay_grade hrm_pay_grade { get; set; }
        public virtual hs_hr_currency_type hs_hr_currency_type { get; set; }
        public virtual hs_hr_employee hs_hr_employee { get; set; }
        public virtual hs_hr_payperiod hs_hr_payperiod { get; set; }
        public virtual ICollection<hs_hr_emp_directdebit> hs_hr_emp_directdebit { get; set; }
    }
}