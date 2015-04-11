using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ActiveContracts : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "Delete")
        {


            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM [activeContracts] WHERE [id] = @id";
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
}