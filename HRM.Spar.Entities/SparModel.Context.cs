﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public  class sparEntities : DbContext
    {
        public sparEntities()
            : base("name=sparEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<hrm_advanced_report> hrm_advanced_report { get; set; }
        public DbSet<hrm_attendance_record> hrm_attendance_record { get; set; }
        public DbSet<hrm_available_group_field> hrm_available_group_field { get; set; }
        public DbSet<hrm_beacon_notification> hrm_beacon_notification { get; set; }
        public DbSet<hrm_composite_display_field> hrm_composite_display_field { get; set; }
        public DbSet<hrm_customer> hrm_customer { get; set; }
        public DbSet<hrm_data_group> hrm_data_group { get; set; }
        public DbSet<hrm_data_group_screen> hrm_data_group_screen { get; set; }
        public DbSet<hrm_datapoint> hrm_datapoint { get; set; }
        public DbSet<hrm_datapoint_type> hrm_datapoint_type { get; set; }
        public DbSet<hrm_display_field> hrm_display_field { get; set; }
        public DbSet<hrm_display_field_group> hrm_display_field_group { get; set; }
        public DbSet<hrm_education> hrm_education { get; set; }
        public DbSet<hrm_email> hrm_email { get; set; }
        public DbSet<hrm_email_configuration> hrm_email_configuration { get; set; }
        public DbSet<hrm_email_notification> hrm_email_notification { get; set; }
        public DbSet<hrm_email_processor> hrm_email_processor { get; set; }
        public DbSet<hrm_email_subscriber> hrm_email_subscriber { get; set; }
        public DbSet<hrm_email_template> hrm_email_template { get; set; }
        public DbSet<hrm_emp_education> hrm_emp_education { get; set; }
        public DbSet<hrm_emp_license> hrm_emp_license { get; set; }
        public DbSet<hrm_emp_reporting_method> hrm_emp_reporting_method { get; set; }
        public DbSet<hrm_emp_termination> hrm_emp_termination { get; set; }
        public DbSet<hrm_emp_termination_reason> hrm_emp_termination_reason { get; set; }
        public DbSet<hrm_employment_status> hrm_employment_status { get; set; }
        public DbSet<hrm_filter_field> hrm_filter_field { get; set; }
        public DbSet<hrm_group_field> hrm_group_field { get; set; }
        public DbSet<hrm_holiday> hrm_holiday { get; set; }
        public DbSet<hrm_home_page> hrm_home_page { get; set; }
        public DbSet<hrm_job_candidate> hrm_job_candidate { get; set; }
        public DbSet<hrm_job_candidate_attachment> hrm_job_candidate_attachment { get; set; }
        public DbSet<hrm_job_candidate_history> hrm_job_candidate_history { get; set; }
        public DbSet<hrm_job_candidate_vacancy> hrm_job_candidate_vacancy { get; set; }
        public DbSet<hrm_job_category> hrm_job_category { get; set; }
        public DbSet<hrm_job_interview> hrm_job_interview { get; set; }
        public DbSet<hrm_job_interview_attachment> hrm_job_interview_attachment { get; set; }
        public DbSet<hrm_job_specification_attachment> hrm_job_specification_attachment { get; set; }
        public DbSet<hrm_job_title> hrm_job_title { get; set; }
        public DbSet<hrm_job_vacancy> hrm_job_vacancy { get; set; }
        public DbSet<hrm_job_vacancy_attachment> hrm_job_vacancy_attachment { get; set; }
        public DbSet<hrm_kpi> hrm_kpi { get; set; }
        public DbSet<hrm_language> hrm_language { get; set; }
        public DbSet<hrm_leave> hrm_leave { get; set; }
        public DbSet<hrm_leave_adjustment> hrm_leave_adjustment { get; set; }
        public DbSet<hrm_leave_comment> hrm_leave_comment { get; set; }
        public DbSet<hrm_leave_entitlement> hrm_leave_entitlement { get; set; }
        public DbSet<hrm_leave_entitlement_adjustment> hrm_leave_entitlement_adjustment { get; set; }
        public DbSet<hrm_leave_entitlement_type> hrm_leave_entitlement_type { get; set; }
        public DbSet<hrm_leave_leave_entitlement> hrm_leave_leave_entitlement { get; set; }
        public DbSet<hrm_leave_period_history> hrm_leave_period_history { get; set; }
        public DbSet<hrm_leave_request> hrm_leave_request { get; set; }
        public DbSet<hrm_leave_request_comment> hrm_leave_request_comment { get; set; }
        public DbSet<hrm_leave_status> hrm_leave_status { get; set; }
        public DbSet<hrm_leave_type> hrm_leave_type { get; set; }
        public DbSet<hrm_license> hrm_license { get; set; }
        public DbSet<hrm_location> hrm_location { get; set; }
        public DbSet<hrm_login> hrm_login { get; set; }
        public DbSet<hrm_membership> hrm_membership { get; set; }
        public DbSet<hrm_menu_item> hrm_menu_item { get; set; }
        public DbSet<hrm_module> hrm_module { get; set; }
        public DbSet<hrm_module_default_page> hrm_module_default_page { get; set; }
        public DbSet<hrm_nationality> hrm_nationality { get; set; }
        public DbSet<hrm_operational_country> hrm_operational_country { get; set; }
        public DbSet<hrm_organization_gen_info> hrm_organization_gen_info { get; set; }
        public DbSet<hrm_pay_grade> hrm_pay_grade { get; set; }
        public DbSet<hrm_pay_grade_currency> hrm_pay_grade_currency { get; set; }
        public DbSet<hrm_performance_review> hrm_performance_review { get; set; }
        public DbSet<hrm_performance_track> hrm_performance_track { get; set; }
        public DbSet<hrm_performance_tracker_log> hrm_performance_tracker_log { get; set; }
        public DbSet<hrm_performance_tracker_reviewer> hrm_performance_tracker_reviewer { get; set; }
        public DbSet<hrm_plugin> hrm_plugin { get; set; }
        public DbSet<hrm_project> hrm_project { get; set; }
        public DbSet<hrm_project_activity> hrm_project_activity { get; set; }
        public DbSet<hrm_project_admin> hrm_project_admin { get; set; }
        public DbSet<hrm_report> hrm_report { get; set; }
        public DbSet<hrm_report_group> hrm_report_group { get; set; }
        public DbSet<hrm_reviewer> hrm_reviewer { get; set; }
        public DbSet<hrm_reviewer_group> hrm_reviewer_group { get; set; }
        public DbSet<hrm_reviewer_rating> hrm_reviewer_rating { get; set; }
        public DbSet<hrm_role_user_selection_rule> hrm_role_user_selection_rule { get; set; }
        public DbSet<hrm_screen> hrm_screen { get; set; }
        public DbSet<hrm_selected_composite_display_field> hrm_selected_composite_display_field { get; set; }
        public DbSet<hrm_selected_display_field> hrm_selected_display_field { get; set; }
        public DbSet<hrm_selected_display_field_group> hrm_selected_display_field_group { get; set; }
        public DbSet<hrm_selected_filter_field> hrm_selected_filter_field { get; set; }
        public DbSet<hrm_selected_group_field> hrm_selected_group_field { get; set; }
        public DbSet<hrm_skill> hrm_skill { get; set; }
        public DbSet<hrm_subunit> hrm_subunit { get; set; }
        public DbSet<hrm_summary_display_field> hrm_summary_display_field { get; set; }
        public DbSet<hrm_timesheet> hrm_timesheet { get; set; }
        public DbSet<hrm_timesheet_action_log> hrm_timesheet_action_log { get; set; }
        public DbSet<hrm_timesheet_item> hrm_timesheet_item { get; set; }
        public DbSet<hrm_upgrade_history> hrm_upgrade_history { get; set; }
        public DbSet<hrm_user> hrm_user { get; set; }
        public DbSet<hrm_user_role> hrm_user_role { get; set; }
        public DbSet<hrm_user_role_data_group> hrm_user_role_data_group { get; set; }
        public DbSet<hrm_user_role_screen> hrm_user_role_screen { get; set; }
        public DbSet<hrm_user_selection_rule> hrm_user_selection_rule { get; set; }
        public DbSet<hrm_work_shift> hrm_work_shift { get; set; }
        public DbSet<hrm_work_week> hrm_work_week { get; set; }
        public DbSet<hrm_workflow_state_machine> hrm_workflow_state_machine { get; set; }
        public DbSet<hs_hr_config> hs_hr_config { get; set; }
        public DbSet<hs_hr_country> hs_hr_country { get; set; }
        public DbSet<hs_hr_currency_type> hs_hr_currency_type { get; set; }
        public DbSet<hs_hr_custom_export> hs_hr_custom_export { get; set; }
        public DbSet<hs_hr_custom_fields> hs_hr_custom_fields { get; set; }
        public DbSet<hs_hr_custom_import> hs_hr_custom_import { get; set; }
        public DbSet<hs_hr_district> hs_hr_district { get; set; }
        public DbSet<hs_hr_emp_attachment> hs_hr_emp_attachment { get; set; }
        public DbSet<hs_hr_emp_basicsalary> hs_hr_emp_basicsalary { get; set; }
        public DbSet<hs_hr_emp_children> hs_hr_emp_children { get; set; }
        public DbSet<hs_hr_emp_contract_extend> hs_hr_emp_contract_extend { get; set; }
        public DbSet<hs_hr_emp_dependents> hs_hr_emp_dependents { get; set; }
        public DbSet<hs_hr_emp_directdebit> hs_hr_emp_directdebit { get; set; }
        public DbSet<hs_hr_emp_emergency_contacts> hs_hr_emp_emergency_contacts { get; set; }
        public DbSet<hs_hr_emp_history_of_ealier_pos> hs_hr_emp_history_of_ealier_pos { get; set; }
        public DbSet<hs_hr_emp_language> hs_hr_emp_language { get; set; }
        public DbSet<hs_hr_emp_member_detail> hs_hr_emp_member_detail { get; set; }
        public DbSet<hs_hr_emp_passport> hs_hr_emp_passport { get; set; }
        public DbSet<hs_hr_emp_picture> hs_hr_emp_picture { get; set; }
        public DbSet<hs_hr_emp_reportto> hs_hr_emp_reportto { get; set; }
        public DbSet<hs_hr_emp_us_tax> hs_hr_emp_us_tax { get; set; }
        public DbSet<hs_hr_emp_work_experience> hs_hr_emp_work_experience { get; set; }
        public DbSet<hs_hr_employee> hs_hr_employee { get; set; }
        public DbSet<hs_hr_module> hs_hr_module { get; set; }
        public DbSet<hs_hr_pay_period> hs_hr_pay_period { get; set; }
        public DbSet<hs_hr_payperiod> hs_hr_payperiod { get; set; }
        public DbSet<hs_hr_province> hs_hr_province { get; set; }
        public DbSet<hs_hr_unique_id> hs_hr_unique_id { get; set; }
        public DbSet<hs_hr_emp_skill> hs_hr_emp_skill { get; set; }
        public DbSet<hs_hr_mailnotifications> hs_hr_mailnotifications { get; set; }
    }
}
