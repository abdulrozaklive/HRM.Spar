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
    
    public partial class hs_hr_emp_passport
    {
        public int emp_number { get; set; }
        public decimal ep_seqno { get; set; }
        public string ep_passport_num { get; set; }
        public Nullable<System.DateTime> ep_passportissueddate { get; set; }
        public Nullable<System.DateTime> ep_passportexpiredate { get; set; }
        public string ep_comments { get; set; }
        public Nullable<short> ep_passport_type_flg { get; set; }
        public string ep_i9_status { get; set; }
        public Nullable<System.DateTime> ep_i9_review_date { get; set; }
        public string cou_code { get; set; }
    
        public virtual hs_hr_employee hs_hr_employee { get; set; }
    }
}
