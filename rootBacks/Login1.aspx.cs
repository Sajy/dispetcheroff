using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void LoginButton_Click(object sender, EventArgs e)
    {
        if (UserName.Text == "admin" && Password.Text == "222admin222")
        {
            Response.Redirect("~/IntroPage.aspx");
        }
        else
        {
            FailureText.Visible = true;
        }
    }
}