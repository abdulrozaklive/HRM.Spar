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
    
    public partial class hrm_nationality
    {
        public hrm_nationality()
        {
            this.hs_hr_employee = new HashSet<hs_hr_employee>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
    
        public virtual ICollection<hs_hr_employee> hs_hr_employee { get; set; }
    }
}
