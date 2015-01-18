using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HRM.Spar.Business;
using HRM.Spar.Entities;
using System.Web.Security;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if (Users.Login(txtUsername.Text, txtPassword.Text))
        {
            FormsAuthentication.RedirectFromLoginPage
             (txtUsername.Text, checkboxPersist.Checked);
            //Response.Redirect("hrm");
        }
        else
        { 
            LabelError.Text = "Invalid credentials. Please try again.";
        }
    }
}