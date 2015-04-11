using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Offers : System.Web.UI.Page
{

    protected static String filterExpression = "productId='{0}' OR regionId='{1}'";
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (User.IsInRole("Administrator"))
        //{
        //    Control HeaderTemplate = Repeater1.Controls[1].Controls[1];
        //    Button lblHeader = HeaderTemplate.FindControl("Button1") as Button;
        //    lblHeader.Visible = false;
        //}
        //DropDownList1.Items.Add(new ListItem("-1", "Все"));
        //DropDownList1.DataBind();
        MembershipUser CurrentUser = Membership.GetUser(User.Identity.Name);


        String scForAdmin = "SELECT products.name AS productName, region.name AS regionName, district.Name AS districtName, quality.name AS qualityName, offers.productId, offers.regionId,		storePlace.name AS storePlaceName, offers.city, offers.value,  offers.price, offers.tel, offers.createDate, offers.sor,offers.belok,offers.vlazhnost, quality.id as qualityId, offers.id As code FROM         offers  INNER JOIN               products ON offers.productId = products.id INNER JOIN region ON offers.regionId = region.id INNER JOIN district ON offers.districtId = district.Id INNER JOIN quality ON offers.qualityId = quality.id INNER JOIN storePlace ON offers.storePlaceId = storePlace.id ORDER BY code desc  ";
        String scForUser = "SELECT     products.name AS productName, region.name AS regionName, district.Name AS districtName, quality.name AS qualityName, offers.productId, offers.regionId,  storePlace.name AS storePlaceName, offers.city, offers.value, offers.price, offers.tel, offers.createDate, offers.sor,offers.belok,offers.vlazhnost, quality.id AS qualityId, offers.id AS code, offers.userIdUniq FROM         offers INNER JOIN  products ON offers.productId = products.id INNER JOIN  region ON offers.regionId = region.id INNER JOIN  district ON offers.districtId = district.Id INNER JOIN  quality ON offers.qualityId = quality.id INNER JOIN   storePlace ON offers.storePlaceId = storePlace.id WHERE     (offers.userIdUniq = @Param1) ORDER BY code DESC";
        if (User.IsInRole("user"))
        {
            SqlDataSource1.SelectCommand = scForAdmin; 
            //SqlDataSource1.SelectCommand = scForUser;
            //MembershipUser CurrentUser = Membership.GetUser(User.Identity.Name);
            SqlDataSource1.SelectParameters.Clear();
            SqlDataSource1.SelectParameters.Add("Param1", CurrentUser.ProviderUserKey.ToString());
        }

        else
        {
            SqlDataSource1.SelectCommand = scForAdmin;
        }
    }

    public object FormatPhoneNumber(string phoneNumber)
    {

        if (String.IsNullOrEmpty(phoneNumber))
        {
            return "";
        }
        if (phoneNumber.Length != 10)
        {
            return "";
        }
        return string.Format("({0}) {1}-{2}-{3}",
          phoneNumber.Substring(0, 3),
          phoneNumber.Substring(3, 3),
          phoneNumber.Substring(7, 2), phoneNumber.Substring(9));
    }
    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {

        if (e.CommandName == "QualityEdit")
        {
            Response.Redirect("~/ProductQuality.aspx" + "?qualityId=" + e.CommandArgument.ToString());
        }

        if (e.CommandName == "Delete")
        {


            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM [offers] WHERE [id] = @id";
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@id";
            param.Value = e.CommandArgument.ToString();
            cmd.Parameters.Add(param);
            cmd.Connection = con;
            con.Open();
            int numberDeleted = cmd.ExecuteNonQuery();
            Repeater1.DataBind();




        }
    }


    protected void SqlDataSource1_Deleting(object sender, SqlDataSourceCommandEventArgs e)
    {
        Response.Write("deleting");
    }
    protected void SqlDataSource1_Deleted(object sender, SqlDataSourceStatusEventArgs e)
    {
        Response.Write("deleted");
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

        SqlDataSource1.FilterExpression = filterExpression;
        Button2.Visible = true;
        // Response.Write(DropDownList1.SelectedIndex);
        //if (DropDownList1.SelectedIndex==null)
        // {

        //   Button2.Visible = false;

        //}


        // Response.Write(DropDownList1.SelectedValue);

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        DropDownList1.SelectedValue = "-1";
        Button2.Visible = false;
        removeFilter();
    }
    protected void DropDownList1_Load(object sender, EventArgs e)
    {

    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        LinkButton3.Visible = false;
        DropDownList2.SelectedValue = "-1";

        removeFilter();
    }

    protected void removeFilter()
    {
        SqlDataSource1.FilterExpression = null;
        SqlDataSource1.DataBind();

    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlDataSource1.FilterExpression = filterExpression;
        LinkButton3.Visible = true;
        // Response.Write(DropDownList2.SelectedValue);
    }

    protected Object CheckRoleForTel(Object v)
    {

        if (User.IsInRole("User")) return ("<button type='button' class='btn btn-default'>Узнать контакты</button>"); else return (v);
    }
}