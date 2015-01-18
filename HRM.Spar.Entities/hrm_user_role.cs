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
    
    public partial class hrm_user_role
    {
        public hrm_user_role()
        {
            this.hrm_home_page = new HashSet<hrm_home_page>();
            this.hrm_module_default_page = new HashSet<hrm_module_default_page>();
            this.hrm_user = new HashSet<hrm_user>();
            this.hrm_user_role_data_group = new HashSet<hrm_user_role_data_group>();
            this.hrm_user_role_screen = new HashSet<hrm_user_role_screen>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string display_name { get; set; }
        public Nullable<bool> is_assignable { get; set; }
        public Nullable<bool> is_predefined { get; set; }
    
        public virtual ICollection<hrm_home_page> hrm_home_page { get; set; }
        public virtual ICollection<hrm_module_default_page> hrm_module_default_page { get; set; }
        public virtual ICollection<hrm_user> hrm_user { get; set; }
        public virtual ICollection<hrm_user_role_data_group> hrm_user_role_data_group { get; set; }
        public virtual ICollection<hrm_user_role_screen> hrm_user_role_screen { get; set; }
    }
}