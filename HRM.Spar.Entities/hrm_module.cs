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
    
    public partial class hrm_module
    {
        public hrm_module()
        {
            this.hrm_module_default_page = new HashSet<hrm_module_default_page>();
            this.hrm_screen = new HashSet<hrm_screen>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public Nullable<sbyte> status { get; set; }
    
        public virtual ICollection<hrm_module_default_page> hrm_module_default_page { get; set; }
        public virtual ICollection<hrm_screen> hrm_screen { get; set; }
    }
}
