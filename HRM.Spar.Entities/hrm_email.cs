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
    
    public partial class hrm_email
    {
        public hrm_email()
        {
            this.hrm_email_processor = new HashSet<hrm_email_processor>();
            this.hrm_email_template = new HashSet<hrm_email_template>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
    
        public virtual ICollection<hrm_email_processor> hrm_email_processor { get; set; }
        public virtual ICollection<hrm_email_template> hrm_email_template { get; set; }
    }
}