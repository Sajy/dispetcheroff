using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class IntroPage : System.Web.UI.Page
{



 
    protected void Page_Load(object sender, EventArgs e)
    {
        //MembershipUser CurrentUser = Membership.GetUser(User.Identity.Name);
        //if (CurrentUser != null)
        //{
        //    //Response.Write("CurrentUser ID :: " + CurrentUser.ProviderUserKey);



        //    CheckBox cb1 = (CheckBox)LoginView1.FindControl("BuyContactsCB");
        //    CheckBox cb2 = (CheckBox)LoginView1.FindControl("SendSMSDriverCB");
        //    CheckBox cb3 = (CheckBox)LoginView1.FindControl("GetTransportOrdersCB");
        //    CheckBox cb4 = (CheckBox)LoginView1.FindControl("SauggestTransportCB");
        //    CheckBox cb5 = (CheckBox)LoginView1.FindControl("SellContractsCB");

        //    cb1.Checked = Roles.IsUserInRole("BuyContactsWatcher");
        //    cb2.Checked = Roles.IsUserInRole("SmsSendMaker");
        //    cb3.Checked = Roles.IsUserInRole("TransportOrdersGetter");
        //    cb4.Checked = Roles.IsUserInRole("DriversContactsWatcher");
        //    cb5.Checked = Roles.IsUserInRole("SellContactsWatcher");
        //}


    }






    protected void Button1_Click(object sender, EventArgs e)
    {
        //Label lb = (Label)UpdatePanel1.FindControl("Label1");
        //lb.Text = "";
        //System.Threading.Thread.Sleep(TimeSpan.FromSeconds(5));

        //lb.Text = "Код выслан на указанный номер";

        ///////здесь генерируем код
        //Profile.LastSentCode = "99999999";

        ////потом отправляем его смской на телефон из 
        ////telephone.Text




    }




    protected String RemoveMaskChars(String v)
    {
        return (v.Replace("-", ""));
    }

    protected void CheckCode()
    {
        //if (RemoveMaskChars(TextBox1.Text) == Profile.LastSentCode)
        //{
        //    Profile.isActivated = true;

        //    ScriptManager.RegisterStartupScript(UpdatePanel2, UpdatePanel2.GetType(), "alert1", "alert('Вы ввели верный код. Активация ВЫПОЛНЕНА.');$('#activDialog').modal('hide');location.reload();", true);

        //}
        ////ClientScript.RegisterStartupScript(GetType(), "alert1", "<script> alert('Вы ввели верный код');</script>");
        //else

        //    ScriptManager.RegisterStartupScript(UpdatePanel2, UpdatePanel2.GetType(), "alert1", "alert('Вы ввели НЕ ВЕРНЫЙ код. Попробуйте еще раз.')", true);
        ////  ClientScript.RegisterStartupScript(GetType(), "alert1", "<script> alert('Вы ввели НЕ ВЕРНЫЙ код');</script>");

        ////if (RemoveMaskChars(TextBox1.Text) == Profile.LastSentCode) return (true); else return (false);

    }


    protected void Button3_Click1(object sender, EventArgs e)
    {
        //System.Threading.Thread.Sleep(TimeSpan.FromSeconds(5));
        ////здесь проверяем введенный пользователем код
        //// в TextBox1.Text
        ////Response.Write(Profile.LastSentCode);
        ////Response.Write(TextBox1.Text);
        //CheckCode();
        ////Profile.isActivated = false;
        ////произойдет возврат управления к вызв контролу когда здесь закончатся все вычисления
    }


    protected void Button4_Click(object sender, EventArgs e)
    {
        Profile.isActivated = false;
        Response.Redirect(Request.RawUrl);
    }

    //protected void BuyContactsCB_CheckedChanged(object sender, EventArgs e)
    //{
    //    CheckBox cb = (CheckBox)LoginView1.FindControl("BuyContactsCB");
    //    if (!cb.Checked)
    //    {
    //        Roles.AddUserToRole(Profile.UserName, "BuyContactsWatcher");
    //    }
    //    if (cb.Checked)
    //    {
    //        Roles.RemoveUserFromRole(Profile.UserName, "BuyContactsWatcher");
    //    }
    //}
    //protected void SendSMSDriverCB_CheckedChanged(object sender, EventArgs e)
    //{
    //    CheckBox cb = (CheckBox)LoginView1.FindControl("SendSMSDriverCB");
    //    if (!cb.Checked)
    //    {
    //        Roles.AddUserToRole(Profile.UserName, "SmsSendMaker");
    //    }
    //    if (cb.Checked)
    //    {
    //        Roles.RemoveUserFromRole(Profile.UserName, "SmsSendMaker");
    //    }
    //}
    //protected void GetTransportOrdersCB_CheckedChanged(object sender, EventArgs e)
    //{
    //    CheckBox cb = (CheckBox)LoginView1.FindControl("GetTransportOrdersCB");
    //    if (!cb.Checked)
    //    {
    //        Roles.AddUserToRole(Profile.UserName, "TransportOrdersGetter");
    //    }
    //    if (cb.Checked)
    //    {
    //        Roles.RemoveUserFromRole(Profile.UserName, "TransportOrdersGetter");
    //    }
    //}
    //protected void SauggestTransportCB_CheckedChanged(object sender, EventArgs e)
    //{
    //    CheckBox cb = (CheckBox)LoginView1.FindControl("SauggestTransportCB");
    //    if (!cb.Checked)
    //    {
    //        Roles.AddUserToRole(Profile.UserName, "DriversContactsWatcher");
    //    }
    //    if (cb.Checked)
    //    {
    //        Roles.RemoveUserFromRole(Profile.UserName, "DriversContactsWatcher");
    //    }
    //}
    //protected void SellContractsCB_CheckedChanged(object sender, EventArgs e)
    //{

    //    CheckBox cb = (CheckBox)LoginView1.FindControl("SellContractsCB");
    //    if (!cb.Checked)
    //    {
    //        Roles.AddUserToRole(Profile.UserName, "SellContactsWatcher");
    //    }
    //    if (cb.Checked)
    //    {
    //        Roles.RemoveUserFromRole(Profile.UserName, "SellContactsWatcher");
    //    }
    //}
    //protected void GetTransportOrdersCB_PreRender(object sender, EventArgs e)
    //{
    //    CheckBox cb5 = (CheckBox)LoginView1.FindControl("SellContractsCB");
    //    cb5.Checked = Roles.IsUserInRole("SellContactsWatcher");
    //}
}