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
    
    public partial class hs_hr_emp_member_detail
    {
        public int emp_number { get; set; }
        public int membship_code { get; set; }
        public string ememb_subscript_ownership { get; set; }
        public Nullable<decimal> ememb_subscript_amount { get; set; }
        public string ememb_subs_currency { get; set; }
        public Nullable<System.DateTime> ememb_commence_date { get; set; }
        public Nullable<System.DateTime> ememb_renewal_date { get; set; }
    
        public virtual hrm_membership hrm_membership { get; set; }
        public virtual hs_hr_employee hs_hr_employee { get; set; }
    }
}
