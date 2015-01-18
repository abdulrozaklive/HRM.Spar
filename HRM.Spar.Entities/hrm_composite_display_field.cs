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
    
    public partial class hrm_composite_display_field
    {
        public hrm_composite_display_field()
        {
            this.hrm_selected_composite_display_field = new HashSet<hrm_selected_composite_display_field>();
        }
    
        public long composite_display_field_id { get; set; }
        public long report_group_id { get; set; }
        public string name { get; set; }
        public string label { get; set; }
        public string field_alias { get; set; }
        public string is_sortable { get; set; }
        public string sort_order { get; set; }
        public string sort_field { get; set; }
        public string element_type { get; set; }
        public string element_property { get; set; }
        public string width { get; set; }
        public string is_exportable { get; set; }
        public string text_alignment_style { get; set; }
        public bool is_value_list { get; set; }
        public Nullable<long> display_field_group_id { get; set; }
        public string default_value { get; set; }
        public bool is_encrypted { get; set; }
        public bool is_meta { get; set; }
    
        public virtual hrm_report_group hrm_report_group { get; set; }
        public virtual hrm_display_field_group hrm_display_field_group { get; set; }
        public virtual ICollection<hrm_selected_composite_display_field> hrm_selected_composite_display_field { get; set; }
    }
}
