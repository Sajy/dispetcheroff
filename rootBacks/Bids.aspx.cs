using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Bid : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String scForAdmin = "SELECT bids.value, bids.city, bids.price, bids.createDate, bids.minLot, bids.weighouse, bids.sor,bids.belok,bids.vlazhnost,   bids.height, bids.tel, products.name AS productName, region.name AS regionName, district.Name AS districtName, quality.name AS qualityName, quality.id as qualityId, storePlace.name AS storeplaceName, autoType.name AS autoTypeName, bids.id AS code FROM bids INNER JOIN products ON bids.productId = products.id  INNER JOIN region ON bids.regionId = region.id INNER JOIN district ON bids.districtId = district.Id INNER JOIN quality ON bids.qualityId = quality.id                  INNER JOIN storePlace ON bids.storePlaceId = storePlace.id INNER JOIN autoType ON bids.autoTypeId = autoType.id";

        String scForUser = "SELECT bids.value, bids.city, bids.price, bids.createDate, bids.minLot, bids.weighouse,   bids.sor,bids.belok,bids.vlazhnost, bids.height, bids.tel, products.name AS productName, region.name AS regionName, district.Name AS districtName, quality.name AS qualityName, quality.id as qualityId, storePlace.name AS storeplaceName, autoType.name AS autoTypeName, bids.id AS code,  bids.userIdUniq  FROM bids INNER JOIN products ON bids.productId = products.id  INNER JOIN region ON bids.regionId = region.id INNER JOIN district ON bids.districtId = district.Id INNER JOIN quality ON bids.qualityId = quality.id                  INNER JOIN storePlace ON bids.storePlaceId = storePlace.id INNER JOIN autoType ON bids.autoTypeId = autoType.id WHERE     (bids.userIdUniq = @Param1) ORDER BY code DESC";

        if (User.IsInRole("user"))
        {
            SqlDataSource1.SelectCommand = scForAdmin;
           // SqlDataSource1.SelectCommand = scForUser;
            MembershipUser CurrentUser = Membership.GetUser(User.Identity.Name);
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
            cmd.CommandText = "DELETE FROM [bids] WHERE [id] = @id";
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
}