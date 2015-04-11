using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class addAutoOffer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        autoOffersDs.InsertParameters["createDate"].DefaultValue = DateTime.Today.ToString();
        MembershipUser CurrentUser = Membership.GetUser(User.Identity.Name);
        autoOffersDs.InsertParameters["userIdUniq"].DefaultValue = CurrentUser.ProviderUserKey.ToString();
    }
    protected void autoOffersDs_Inserted(object sender, SqlDataSourceStatusEventArgs e)
    {
      
        ClientScript.RegisterStartupScript(GetType(), "Show2", "<script> alert('Спасибо, данные сохранены успешно!');window.location.href = 'Transport.aspx';</script>");
    }
    protected void FormView1_ItemInserting(object sender, FormViewInsertEventArgs e)
    {
        TextBox tb1 = (TextBox)FormView1.FindControl("telTextBox");
       
        autoOffersDs.InsertParameters["tel"].DefaultValue = RemoveMaskChars(tb1.Text);
       // Response.Redirect("~/Transport.aspx");

    }

    protected String RemoveMaskChars(String v)
    {

        return (v.Replace("-", "").Replace("(", "").Replace(")", ""));
    }
}