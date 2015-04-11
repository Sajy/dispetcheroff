using System;
using System.Collections.Generic;

using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void cmdLogin_Click(object sender, EventArgs e)
    {
      /*  if (txtPassword.Text == "secret")
        {
            lblStatus.Text = "you logged in";
            FormsAuthentication.RedirectFromLoginPage(
            txtName.Text, false);
        }
        else
        {
            lblStatus.Text = "Try again.";
        }*/

        /*if (Membership.ValidateUser(txtName.Text, txtPassword.Text))
        {
            FormsAuthentication.RedirectFromLoginPage(txtName.Text, false);
        }
        else
        {
            lblStatus.Text = "Invalid username or password.";
        }*/
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
       // FormsAuthentication.SignOut();
       // FormsAuthentication.RedirectToLoginPage();
       // Response.Redirect("~/Login.aspx");
    }
    protected void LoginButton_Click(object sender, EventArgs e)
    {

      
    }
}