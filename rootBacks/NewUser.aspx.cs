using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class newUser : System.Web.UI.Page
{


    protected void Page_Load(object sender, EventArgs e)
    {

        TextBox userName = (TextBox)CreateUserWizard1.CreateUserStep.Controls[0].FindControl("UserName");

        TextBox textbox1 = (TextBox)CreateUserWizard1.CreateUserStep.Controls[0].FindControl("TextBox1");
        //Response.Write(userName.Text);
        //Response.Write(textbox1.Text);
        userName.Text = RemoveMaskChars(textbox1.Text);
            
    }

    protected void ContinueButton_Click(object sender, EventArgs e)
    {


        DropDownList regionName = (DropDownList)CreateUserWizard1.CompleteStep.Controls[0].FindControl("RegionName");
        DropDownList districtName = (DropDownList)CreateUserWizard1.CompleteStep.Controls[0].FindControl("DistrictName");
        TextBox cityName = (TextBox)CreateUserWizard1.CompleteStep.Controls[0].FindControl("CityName");
        CheckBox sellCB = (CheckBox)CreateUserWizard1.CompleteStep.Controls[0].FindControl("sellCB");
        CheckBox buyCB = (CheckBox)CreateUserWizard1.CompleteStep.Controls[0].FindControl("buyCB");
        CheckBox transportCB = (CheckBox)CreateUserWizard1.CompleteStep.Controls[0].FindControl("transportCB");
        CheckBox sendCB = (CheckBox)CreateUserWizard1.CompleteStep.Controls[0].FindControl("sendCB");

        Profile.City = cityName.Text;
        Profile.District = regionName.SelectedIndex;
        Profile.Region = districtName.SelectedIndex;
        Profile.isSell = sellCB.Checked;
        Profile.isBuy = buyCB.Checked;
        Profile.isTransport = transportCB.Checked;
        Profile.isSend = sendCB.Checked;

        

        Profile.Money = 55;
        Profile.isActivated = true;
        Response.Redirect("~/IntroPage.aspx");
    }
    protected void CreateUserWizard1_CreatedUser(object sender, EventArgs e)

    {


        TextBox userName = (TextBox)CreateUserWizard1.CreateUserStep.Controls[0].FindControl("UserName");
        Roles.AddUserToRole(userName.Text, "User");
        FormsAuthentication.SetAuthCookie(userName.Text, false);
    }

    protected void CreateUserWizard1_ContinueButtonClick(object sender, EventArgs e)
    {
       // ClientScript.RegisterStartupScript(GetType(), "alert1", "<script> alert('Спасибо за регистрацию вы вошли в личный кабинет как'" + Profile.UserName + ");</script>");  
    }
    protected void RegionName_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList dd = (DropDownList)CreateUserWizard1.CompleteStep.Controls[0].FindControl("RegionName");
        /// dd2.SelectedValue = dd.SelectedValue;
        DistrictDataSource.SelectParameters["Param1"].DefaultValue = dd.SelectedValue.ToString();
      
    }
    protected void CreateUserWizard1_CreatingUser(object sender, LoginCancelEventArgs e)
    {
       

    }

    protected String RemoveMaskChars(String v)
    {

        return (v.Replace("-", "").Replace("(", "").Replace(")", ""));
    }
    protected void CreateUserWizard1_CreateUserError(object sender, CreateUserErrorEventArgs e)
    {
        switch (e.CreateUserError)
        {
            case MembershipCreateStatus.DuplicateUserName:
                Label2.Text = "Username already exists. Please enter a different user name.";
                break;

            case MembershipCreateStatus.DuplicateEmail:
                Label2.Text = "A username for that e-mail address already exists. Please enter a different e-mail address.";
                break;

            case MembershipCreateStatus.InvalidPassword:
                Label2.Text = "The password provided is invalid. Please enter a valid password value.";
                break;

            case MembershipCreateStatus.InvalidEmail:
                Label2.Text = "The e-mail address provided is invalid. Please check the value and try again.";
                break;

            case MembershipCreateStatus.InvalidAnswer:
                Label2.Text = "The password retrieval answer provided is invalid. Please check the value and try again.";
                break;

            case MembershipCreateStatus.InvalidQuestion:
                Label2.Text = "The password retrieval question provided is invalid. Please check the value and try again.";
                break;

            case MembershipCreateStatus.InvalidUserName:
                   TextBox userName = (TextBox)CreateUserWizard1.CreateUserStep.Controls[0].FindControl("UserName");
        TextBox textbox1 = (TextBox)CreateUserWizard1.CreateUserStep.Controls[0].FindControl("TextBox1");
        Label2.Text = "The user name provided is invalid. Please check the value and try again. UN: " + userName.Text + " TB:  " + textbox1.Text;
                break;

            case MembershipCreateStatus.ProviderError:
                Label2.Text = "The authentication provider returned an error. Please verify your entry and try again. If the problem persists, please contact your system administrator.";
                break;

            case MembershipCreateStatus.UserRejected:
                Label2.Text = "The user creation request has been canceled. Please verify your entry and try again. If the problem persists, please contact your system administrator.";
                break;

            default:
                Label2.Text = "An unknown error occurred. Please verify your entry and try again. If the problem persists, please contact your system administrator.";
                break;
        }
    }
    
}