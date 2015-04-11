using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Offers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        offerDS.InsertParameters["createDate"].DefaultValue = DateTime.Today.ToString();
        MembershipUser CurrentUser = Membership.GetUser(User.Identity.Name);
        offerDS.InsertParameters["userIdUniq"].DefaultValue = CurrentUser.ProviderUserKey.ToString();
        
      // Response.Write("CurrentUser ID :: " + CurrentUser.ProviderUserKey);
       

        //Calendar cal = (Calendar)FormView1.FindControl("Calendar1");
        //cal.SelectedDate = DateTime.Today;
        //Response.Write(DateTime.Today.ToString());
      
    }
  
    protected void offerDS_Inserted(object sender, SqlDataSourceStatusEventArgs e)
    {
        //Response.Redirect("~/Offers.aspx");
      
    }


    protected void DropDownList5_SelectedIndexChanged(object sender, EventArgs e)
    {


       
        DropDownList dd = (DropDownList)FormView1.FindControl("DropDownList5");
       /// dd2.SelectedValue = dd.SelectedValue;
        districtDS.SelectParameters["Param1"].DefaultValue = dd.SelectedValue.ToString();
      
    }

    protected void FormView1_ItemInserting(object sender, FormViewInsertEventArgs e)
    {
        DropDownList dd2 = (DropDownList)FormView1.FindControl("DropDownList2");
        TextBox tb1 = (TextBox)FormView1.FindControl("telTextBox");
        if (dd2.SelectedIndex > -1) offerDS.InsertParameters["districtId"].DefaultValue = dd2.SelectedValue;

        ClientScript.RegisterStartupScript(GetType(), "Show2", "<script> alert('Спасибо, данные сохранены успешно!');window.location.href = 'Offers.aspx';</script>");
      

   
        offerDS.InsertParameters["tel"].DefaultValue = RemoveMaskChars(tb1.Text);

       



    }

    protected String RemoveMaskChars(String v)
    {
       
        return (v.Replace("-", "").Replace("(", "").Replace(")", ""));
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        //formTheQuality();
    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {
        //formTheQuality();
    }
    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {
        //formTheQuality();
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
   
    protected void Button1_Click1(object sender, EventArgs e)
    {
        formTheQuality();
    }
}