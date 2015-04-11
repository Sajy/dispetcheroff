using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class addBid : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        bidsDs.InsertParameters["createDate"].DefaultValue = DateTime.Today.ToString();
        MembershipUser CurrentUser = Membership.GetUser(User.Identity.Name);
        bidsDs.InsertParameters["userIdUniq"].DefaultValue = CurrentUser.ProviderUserKey.ToString();
    }
    protected void SqlDataSource1_Inserted(object sender, SqlDataSourceStatusEventArgs e)
    {
       // Response.Redirect("~/Bids.aspx");
    }
    protected void Unnamed_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void DropDownList5_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList dd = (DropDownList)FormView1.FindControl("DropDownList7");
        /// dd2.SelectedValue = dd.SelectedValue;
        districtDS.SelectParameters["Param1"].DefaultValue = dd.SelectedValue.ToString();
    }
    protected void FormView1_ItemInserting(object sender, FormViewInsertEventArgs e)
    {

        TextBox tb1 = (TextBox)FormView1.FindControl("telTextBox");
        DropDownList dd2 = (DropDownList)FormView1.FindControl("DropDownList5");
        if (dd2.SelectedIndex > -1) bidsDs.InsertParameters["districtId"].DefaultValue = dd2.SelectedValue;
        ClientScript.RegisterStartupScript(GetType(), "Show2", "<script> alert('Спасибо, данные сохранены успешно!');window.location.href = 'Bids.aspx';</script>");
        bidsDs.InsertParameters["tel"].DefaultValue = RemoveMaskChars(tb1.Text);
       

    }

    protected String RemoveMaskChars(String v)
    {

        return (v.Replace("-", "").Replace("(", "").Replace(")", ""));
    }
    protected void FormView1_ItemInserted(object sender, FormViewInsertedEventArgs e)
    {
        //Response.Redirect("~/Bids.aspx");
    }

    protected void formTheQuality()
    {
        TextBox tb2 = (TextBox)FormView1.FindControl("TextBox1");
        TextBox tb3 = (TextBox)FormView1.FindControl("TextBox2");
        TextBox tb4 = (TextBox)FormView1.FindControl("TextBox3");
        String qs = "Сор: " + tb2.Text + "; Вл: " + tb3.Text + "; Белок: " + tb4.Text;
        TextBox tb1 = (TextBox)FormView1.FindControl("TextBox4");
        tb1.Text = qs;

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        formTheQuality();
    }
}