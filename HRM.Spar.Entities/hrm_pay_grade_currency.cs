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
    
    public partial class hrm_pay_grade_currency
    {
        public int pay_grade_id { get; set; }
        public string currency_id { get; set; }
        public Nullable<double> min_salary { get; set; }
        public Nullable<double> max_salary { get; set; }
    
        public virtual hrm_pay_grade hrm_pay_grade { get; set; }
        public virtual hs_hr_currency_type hs_hr_currency_type { get; set; }
    }
}
