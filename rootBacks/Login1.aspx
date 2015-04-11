<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login1.aspx.cs" Inherits="Login1" %>
<!DOCTYPE html>
<!--[if lt IE 7]>      <html class="no-js lt-ie9 lt-ie8 lt-ie7"> <![endif]-->
<!--[if IE 7]>         <html class="no-js lt-ie9 lt-ie8"> <![endif]-->
<!--[if IE 8]>         <html class="no-js lt-ie9"> <![endif]-->
<!--[if gt IE 8]><!-->
<html class="no-js">
<!--<![endif]-->
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
    <title></title>
    <meta name="description" content="">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="css/bootstrap.min.css">
    <link rel="stylesheet" href="css/bootstrap-table.css">
    <link rel="stylesheet" href="css/bootstrap-theme.min.css">
    <link rel="stylesheet" href="content/css/common.css">
    <link rel="stylesheet" href="css/main.css">
    <script src="js/vendor/modernizr-2.6.2-respond-1.1.0.min.js"></script>
   <style>
          body {
	margin:50px 50px; padding:50px 0px 0px 0px;
	text-align:center;
	}
	
#Content {
	width:280px;
	margin:0px auto;
	text-align:left;
	padding:15px;
	border:1px dashed #333;
	background-color:#eee;
	}


 .auto-style1 {
           width: 280px;
           padding-left: 5px;
            padding-right: 5px;
        }



   </style>
</head>

<body>
    <!-- #include file="content/middleincludes.aspx" -->
  

      <div id="Content">

    <form id="form1" runat="server">
    <div>
         <span style="font-size: xx-large; font-family: Arial, Helvetica, sans-serif">Dispetcheroff.net <br />
        
        </span>
     <table cellpadding="4" cellspacing="0" style="border-collapse: collapse;">
                    <tr>
                        <td>
                         
                            <table  cellpadding="0" >
                                <tr>
                                    
                                    <td align="center" style="color: White; background-color: #1C5E55; font-size: 1.5em; font-weight: bold;" class="auto-style1">Выполнить вход</td>
                                </tr>
                                <tr>
                                    <td class="auto-style1">
                                        <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName" Font-Size="Small">Логин</asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style1">
                                        <asp:TextBox class="form-control" ID="UserName" runat="server"  MaxLength="10"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" ErrorMessage="Поле &quot;Имя пользователя&quot; является обязательным." ToolTip="Поле &quot;Имя пользователя&quot; является обязательным." ValidationGroup="Login1" ForeColor="Red">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style1">
                                        <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password" Font-Size="Small">Пароль:</asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style1">
                                        <asp:TextBox  class="form-control" ID="Password" runat="server" TextMode="Password"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" ErrorMessage="Поле &quot;Пароль&quot; является обязательным." ToolTip="Поле &quot;Пароль&quot; является обязательным." ValidationGroup="Login1" ForeColor="Red">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style1">
                                        <asp:CheckBox ID="RememberMe" runat="server" Text="Запомнить учетные данные." Visible="False" />
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" style="color: Red;" class="auto-style1">
                                        <asp:Literal ID="FailureText" runat="server" EnableViewState="False" Visible="False">Неверный логин или пароль</asp:Literal>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" class="auto-style1">
                                        <asp:Button class="btn btn-default" ID="LoginButton" runat="server"  CommandName="Login" Text="Выполнить вход" ValidationGroup="Login1" OnClick="LoginButton_Click" />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style1">
                                        <asp:HyperLink ID="CreateUserLink" runat="server" NavigateUrl="~/NewUser.aspx" Visible="False">Зарегистрироваться</asp:HyperLink>
                                        <br />
                                        <asp:HyperLink ID="PasswordRecoveryLink" runat="server" Visible="False">Забыли пароль?</asp:HyperLink>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
    </div>
 
    </form>
</div>
    <!-- #include file="content/bottomincludes.aspx" -->
</body>
</html>


