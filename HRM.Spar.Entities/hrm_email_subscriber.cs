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
    
    public partial class hrm_email_subscriber
    {
        public int id { get; set; }
        public int notification_id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
    
        public virtual hrm_email_notification hrm_email_notification { get; set; }
    }
}
