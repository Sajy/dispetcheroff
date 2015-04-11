using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;



public partial class MemberArea : System.Web.UI.Page
{


    public bool Loged = false;


    protected void Page_Load(object sender, EventArgs e)
    {
        // lblMessage.Text = "Добро пожаловть в Ваш личный кабинет, ";
        // lblMessage.Text += User.Identity.Name + ".";
        //Label2.Text = "Aктивен";
        //if (Loged)
        //{
        //    ClientScript.RegisterStartupScript(GetType(), "Show2", "<script> $('#privateAreaPanel').removeClass('hide')</script>");
        //    ClientScript.RegisterStartupScript(GetType(), "Show3", "<script> $('#collapseOne').collapse({toggle: true})</script>");
        //}
        //ClientScript.RegisterStartupScript(GetType(), "Show3", "<script>   $('captionAnchor').attr('disabled', true);</script>");

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        FormsAuthentication.SignOut();
        Response.Redirect("~/Login.aspx");
    }

    protected void Label1_DataBinding(object sender, EventArgs e)
    {
        Label lbl = (Label)sender;
        Boolean code = (Boolean)Eval("active");
        if (code) lbl.Text = "Да"; else lbl.Text = "Нет";

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        //Response.Write("Activated");
        //Page.Validate();


        //if (!RegularExpressionValidator1.IsValid ||
        //    !RequiredFieldValidator1.IsValid ||
        //    !CompareValidator2.IsValid ||
        //    !RequiredFieldValidator2.IsValid ||
        //    !RegularExpressionValidator3.IsValid ||
        //    !RequiredFieldValidator3.IsValid ||
        //    !CompareValidator1.IsValid 


        //    )
        //{

            //Response.Write("show");
           // ClientScript.RegisterStartupScript(GetType(), "Show", "<script> $('#activationDialog').modal('show');</script>");
           // ClientScript.RegisterStartupScript(GetType(), "Show2", "<script> $('#privateAreaPanel').removeClass('hide')</script>");
           // ClientScript.RegisterStartupScript(GetType(), "Show3", "<script> $('#collapseOne').collapse({toggle: true})</script>");

        //}

    }
    protected void SqlDataSource4_Selected(object sender, SqlDataSourceStatusEventArgs e)
    {
       
    }

    protected String GetUserId()
    {

        DataView dv = (DataView)SqlDataSource4.Select(DataSourceSelectArguments.Empty);
        return(dv[0][0].ToString());
        
    }

    protected String GetUserName()
    {

        DataView dv = (DataView)SqlDataSource3.Select(DataSourceSelectArguments.Empty);
        return (dv[0][0].ToString());

    }

    protected String GetTelePhone()
    {

        DataView dv = (DataView)SqlDataSource3.Select(DataSourceSelectArguments.Empty);
        return (dv[0][1].ToString());

    }

    protected String getMoney()
    {

        DataView dv = (DataView)SqlDataSource3.Select(DataSourceSelectArguments.Empty);
        return (dv[0][2].ToString());

    }

    protected bool isUserActive()
    {

        DataView dv = (DataView)SqlDataSource3.Select(DataSourceSelectArguments.Empty);
       // Response.Write(dv[0][3].ToString());
        bool result = Convert.ToBoolean(dv[0][3].ToString());
        if (!result) return (false); else return (true);
      

      

    }


    protected bool CheckIfUserTelephoneInBase()
    {
        DataView dv = (DataView)SqlDataSource4.Select(DataSourceSelectArguments.Empty);
    
      
        
        if (dv.Count == 0) return (false); else return (true);

        
    }


    protected void Button3_Click(object sender, EventArgs e)
    {



        Page.Validate();
        
        if (!RegularExpressionValidator2.IsValid || !RequiredFieldValidator4.IsValid)
        {

            Label4.Text = "Неправильно введен номер телефона";
            ClientScript.RegisterStartupScript(GetType(), "Show", "<script> $('#myModal').modal('show');</script>");
          

        }
        else
        {
            


            Label4.Text = "";
            SqlDataSource4.SelectParameters["Param1"].DefaultValue = telephone.Text;
            if (CheckIfUserTelephoneInBase())
            {
                //получить шв пользовтеля
                Label3.Text = GetUserId();
                SqlDataSource3.SelectParameters["Param1"].DefaultValue = GetUserId();
                captionLabel.Text = "- "+GetUserName();
                moneyLabel.Text = getMoney()+" грн";
                Loged = true;
                if (isUserActive())
                {
                    Label2.Text = "Активирован";
                   // activationButton.Visible = false;
                    
                    //ClientScript.RegisterStartupScript(GetType(), "Show3", "<script>    $('#activationButton').prop('disabled', true);</script>");
                   
                }
                else
                {
                    Label2.Text = "Неактивирован";
                    
                   // activationButton.Visible = true;
                    
                }


               
               

            }
            else
            {
                Label3.Text = "Новый пользователь";
            }

            ClientScript.RegisterStartupScript(GetType(), "Show2", "<script> $('#privateAreaPanel').removeClass('hide')</script>");
                ClientScript.RegisterStartupScript(GetType(), "Show3", "<script> $('#collapseOne').collapse({toggle: true})</script>");

                ClientScript.RegisterStartupScript(GetType(), "Show9", "<script> $('#jmbTrn').addClass('hide')</script>");
            
            
            //ClientScript.RegisterStartupScript(GetType(), "Show2", "<script> $('#collapseOne').collapse('hide')</script>");
            //ClientScript.RegisterStartupScript(GetType(), "Show2", "<script> $('#privateAreaPanel').addClass('hide')</script>");
          /// ClientScript.RegisterStartupScript(GetType(), "Show4", "<script> $('#privateAreaPanel').show())</script>");

            //Response.Write("dfdfdf");
          


        }
    }



    protected void activationButton_Click(object sender, EventArgs e)
    {
        
    }
}

