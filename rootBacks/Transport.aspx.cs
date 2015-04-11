using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Transport : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

      
      
        String scForAdmin = "SELECT autoOffers.id as code, autoOffers.userId, autoOffers.offerNum, autoOffers.autoMakeId, autoOffers.autoTypeId, autoOffers.tare, autoOffers.cargo, autoOffers.autoNumber, autoOffers.regionOfNumber, autoOffers.bortHeight, autoOffers.addCargoName, autoOffers.value, autoOffers.userIdUniq, autoOffers.createDate, autoOffers.tel, autoType.name AS autoTypeName, autoMake.name AS autoMakeName FROM autoOffers INNER JOIN autoMake ON autoOffers.autoMakeId = autoMake.id INNER JOIN autoType ON autoOffers.autoTypeId = autoType.id";

        String scForUser = "SELECT autoOffers.id as code, autoOffers.userId, autoOffers.offerNum, autoOffers.autoMakeId, autoOffers.autoTypeId, autoOffers.tare, autoOffers.cargo, autoOffers.autoNumber, autoOffers.regionOfNumber, autoOffers.bortHeight, autoOffers.addCargoName, autoOffers.value, autoOffers.userIdUniq, autoOffers.createDate, autoOffers.tel, autoType.name AS autoTypeName, autoMake.name AS autoMakeName,  autoOffers.userIdUniq FROM autoOffers INNER JOIN autoMake ON autoOffers.autoMakeId = autoMake.id INNER JOIN autoType ON autoOffers.autoTypeId = autoType.id  WHERE     (autoOffers.userIdUniq = @Param1) ORDER BY code DESC";

     if (User.IsInRole("user"))
     {
        // SqlDataSource1.SelectCommand = scForUser;
         SqlDataSource1.SelectCommand = scForAdmin;
         MembershipUser CurrentUser = Membership.GetUser(User.Identity.Name);
         SqlDataSource1.SelectParameters.Clear();
         SqlDataSource1.SelectParameters.Add("Param1", CurrentUser.ProviderUserKey.ToString());
     }

     else
     {
         SqlDataSource1.SelectCommand = scForAdmin;
     }

     System.Data.DataView dv = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
     Label1.Text = (1430+dv.Count).ToString();
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

    protected void Repeater1_ItemCommand1(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "QualityEdit")
        {
            Response.Redirect("~/ProductQuality.aspx" + "?qualityId=" + e.CommandArgument.ToString());
        }

        if (e.CommandName == "Delete")
        {


            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM [autoOffers] WHERE [id] = @id";
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

    protected Object CheckRoleForTel(Object v)
    {

        if (User.IsInRole("User")) return ("<button type='button' class='btn btn-default'>Узнать контакты</button>"); else return (v);
    }
    protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        //Button bt = (Button)e.Item.FindControl("Button1");
        //if (User.IsInRole("User")) bt.Visible = false;
    }
    protected void SqlDataSource1_Selected(object sender, SqlDataSourceStatusEventArgs e)
    {
     
       
    }
}