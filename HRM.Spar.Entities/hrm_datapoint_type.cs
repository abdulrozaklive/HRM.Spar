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
    
    public partial class hrm_datapoint_type
    {
        public hrm_datapoint_type()
        {
            this.hrm_datapoint = new HashSet<hrm_datapoint>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string action_class { get; set; }
    
        public virtual ICollection<hrm_datapoint> hrm_datapoint { get; set; }
    }
}
