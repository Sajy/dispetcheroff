<%@ Page Language="C#" AutoEventWireup="true" CodeFile="NewUser.aspx.cs" Inherits="newUser" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<!DOCTYPE html>
<!--[if lt IE 7]>      <html class="no-js lt-ie9 lt-ie8 lt-ie7"> <![endif]-->
<!--[if IE 7]>         <html class="no-js lt-ie9 lt-ie8"> <![endif]-->
<!--[if IE 8]>         <html class="no-js lt-ie9"> <![endif]-->
<!--[if gt IE 8]><!-->
<html class="no-js">
<!--<![endif]-->
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link rel="stylesheet" href="css/bootstrap.min.css">
    <link rel="stylesheet" href="css/bootstrap-theme.min.css">
    <link rel="stylesheet" href="css/main.css">
    <script src="js/vendor/modernizr-2.6.2-respond-1.1.0.min.js"></script>


    <style>
        body {
            margin: 50px 50px;
            padding: 50px 0px 0px 0px;
            text-align: center;
        }

        #Content {
            width: 350px;
            margin: 0px auto;
            text-align: left;
            padding: 15px;
            border: 1px dashed #333;
            background-color: #eee;
        }

        .auto-style1 {
            width: 125px;
        }

        .warnings {
            font-family: Arial, Helvetica, sans-serif;
            font-size: xx-small;

        }
        .warnings ul{
           margin-top:10px;
           padding-left: 10px;

        }

    </style>
  
</head>
<body>
    <asp:SqlDataSource ID="RegionDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:LocalSqlServer %>" SelectCommand="SELECT * FROM [region]" ProviderName="System.Data.SqlClient"></asp:SqlDataSource>
    <asp:SqlDataSource ID="DistrictDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:LocalSqlServer %>" SelectCommand="SELECT     Id, Name, RegionId FROM         district WHERE     (RegionId = @Param1) ORDER BY Name" ProviderName="System.Data.SqlClient">
        <SelectParameters>
            <asp:Parameter Name="Param1" DefaultValue="8" />
        </SelectParameters>
    </asp:SqlDataSource>
    <form id="form1" runat="server">

        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div id="Content">
            <div class="panel panel-primary ">
                <div class="panel-heading "><strong>Регистрация нового пользователя</strong></div>
                <div class="panel-body ">
                  
                    <asp:CreateUserWizard ID="CreateUserWizard1" runat="server" RequireEmail="False" Width="300px" CancelDestinationPageUrl="~/IntroPage.aspx" DisplayCancelButton="True" CreateUserButtonText="Далее" OnCreatedUser="CreateUserWizard1_CreatedUser" OnCreatingUser="CreateUserWizard1_CreatingUser"  OnContinueButtonClick="CreateUserWizard1_ContinueButtonClick" OnCreateUserError="CreateUserWizard1_CreateUserError">
                        <CreateUserButtonStyle CssClass="btn btn-default" />
                        <WizardSteps>
                            <asp:CreateUserWizardStep ID="CreateUserWizardStep1" runat="server">
                                <ContentTemplate>

                                    

                                    <div class="form-group">
                                        <label for="TextBox1">Номер телефона (Логин)


                                    
                                          
                          
                                          




                                            <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="TextBox1" ErrorMessage="Поле &quot;Имя пользователя&quot; является обязательным." ToolTip="Поле &quot;Имя пользователя&quot; является обязательным." ValidationGroup="CreateUserWizard1" CssClass="text-info">*</asp:RequiredFieldValidator>
                                          
                                             <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1" ValidationGroup="CreateUserWizard1" ValidationExpression=".*0(39|50|63|66|67|68|91|92|93|94|95|96|97|98|99).*\d\d\d.*\d\d.*\d\d" ToolTip="нЕВЕРНЫЙ НОМЕР ТЕЛЕФОНА" ErrorMessage="Неверный оператор или формат номер телефона. Пример (063)233-12-33 (лайф) или (097)444-44-44 (киевстар)">*</asp:RegularExpressionValidator>
                                            </label>
                                        
                                        
                                        <asp:TextBox ID="TextBox1" class="form-control  " placeholder="0632221133" runat="server" MaxLength="10" ToolTip="Рекомендуется вводить реальный номер телефона, так как в дальнейшем для получения услуг необходимо будет пройти активацию"></asp:TextBox>
                                        <asp:TextBox ID="UserName" runat="server" Visible="False"></asp:TextBox>
                                             <asp:MaskedEditExtender ID="MaskedEditExtender1" runat="server" TargetControlID="TextBox1" Mask="(999)999-99-99" ClearTextOnInvalid="False" ClearMaskOnLostFocus="False" AutoComplete="False" PromptCharacter="_"></asp:MaskedEditExtender>

                                        <asp:Label ID="Label1" runat="server" Text="Внимание! Рекомендуется вводить реальный номер телефона, так как в дальнейшем для получения услуг необходимо будет пройти активацию" Font-Size="Smaller" ForeColor="#333333" Font-Strikeout="False"></asp:Label>
                                    </div>
                                    <div class="form-group">
                                        <label for="Password">Пароль<asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" ErrorMessage="Поле &quot;Пароль&quot; является обязательным." ToolTip="Поле &quot;Пароль&quot; является обязательным." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator></label>
                                        <asp:TextBox ID="Password" class="form-control" placeholder="Пароль (придумайте себе пароль)" runat="server" TextMode="Password" MaxLength="10"></asp:TextBox>

                                    </div>
                                    <div class="form-group">
                                        <label for="ConfirmPassword">
                                            Подтвердите пароль
                                               <asp:RequiredFieldValidator ID="ConfirmPasswordRequired" runat="server" ControlToValidate="ConfirmPassword" ErrorMessage="Поле &quot;Подтвердите пароль&quot; является обязательным." ToolTip="Поле &quot;Подтвердите пароль&quot; является обязательным." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                                        </label>
                                        <asp:TextBox ID="ConfirmPassword" class="form-control" placeholder="Повторите придуманный пароль" runat="server" TextMode="Password" MaxLength="10"></asp:TextBox>

                                    </div>

                                    <asp:CompareValidator ID="PasswordCompare" runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword" Display="Dynamic" ErrorMessage="Значения &quot;Пароль&quot; и &quot;Подтвердите пароль&quot; должны совпадать." ValidationGroup="CreateUserWizard1"></asp:CompareValidator>

                                </ContentTemplate>
                            </asp:CreateUserWizardStep>

                            <asp:CompleteWizardStep ID="CompleteWizardStep1" runat="server" ViewStateMode="Inherit">
                                <ContentTemplate>

                                    <div class="form-group">
                                        <label for="RegionName">Область<asp:RequiredFieldValidator ID="RegionRequired" runat="server" ControlToValidate="RegionName" ErrorMessage="Поле &quot;Область&quot; является обязательным." ToolTip="Поле &quot;Область&quot; является обязательным." ValidationGroup="CompleteWizardStep1">*</asp:RequiredFieldValidator></label>
                                        <%--  <asp:TextBox ID="RegionName" class="form-control  " placeholder="Область" runat="server" MaxLength="10"></asp:TextBox>--%>
                                        <asp:DropDownList ID="RegionName" class="form-control  " placeholder="Область" runat="server" DataSourceID="RegionDataSource" DataTextField="name" DataValueField="id" AutoPostBack="True"   OnSelectedIndexChanged="RegionName_SelectedIndexChanged"></asp:DropDownList>

                                    </div>
                                    <div class="form-group">
                                        <label for="DistrictName">Район<asp:RequiredFieldValidator ID="DistrictNameRequired" runat="server" ControlToValidate="DistrictName" ErrorMessage="Поле &quot;Район&quot; является обязательным." ToolTip="Поле &quot;Район&quot; является обязательным." ValidationGroup="CompleteWizardStep1">*</asp:RequiredFieldValidator></label>
                                        <%--<asp:TextBox ID="DistrictName" class="form-control  " placeholder="Район" runat="server" MaxLength="10"></asp:TextBox>--%>
                                        <asp:DropDownList ID="DistrictName" class="form-control  " placeholder="Район" runat="server" DataSourceID="DistrictDataSource" DataTextField="name" DataValueField="id"></asp:DropDownList>
                                    </div>
                                    <div class="form-group">
                                        <label for="CityName">Город (не обязательно)<asp:RegularExpressionValidator ID="CityNameCheck" runat="server" ErrorMessage="Неверно введен город" ValidationGroup="CompleteWizardStep1" ToolTip="Неверно введен город" ValidationExpression="\D" ControlToValidate="CityName">*</asp:RegularExpressionValidator></label>
                                        <asp:TextBox ID="CityName" class="form-control  " placeholder="Город" runat="server" MaxLength="20"></asp:TextBox>

                                    </div>
                                    <%-- <div class="form-group">
                                        <label for="Role">Роль<asp:RequiredFieldValidator ID="RoleRequired" runat="server" ControlToValidate="Role" ErrorMessage="Поле &quot;Роль&quot; является обязательным." ToolTip="Поле &quot;Роль&quot; является обязательным." ValidationGroup="CompleteWizardStep1">*</asp:RequiredFieldValidator></label>
                                        <asp:TextBox ID="Role" class="form-control  " placeholder="Роль" runat="server" MaxLength="10"></asp:TextBox>
                                      
                                    </div>--%>
                                   <b> Укажите Ваши намерения?</b>
                                    <table class="table">
                                        <tr>
                                            <td class="auto-style1"><asp:CheckBox ID="sellCB" runat="server" Checked="True" Text="Продавец" Font-Bold="False" Font-Size="Small" /></td>
                                            <td style="font-size:xx-small">Возможность давать объявления на продажу</td>
                                        </tr>
                                         <tr>
                                            <td class="auto-style1">   <asp:CheckBox ID="buyCB" runat="server" Text="Покупатель" Font-Size="Small" /></td>
                                              <td style="font-size:xx-small">Возможность давать объявления на покупку </td>
                                        </tr>
                                         <tr>
                                            <td class="auto-style1"> <asp:CheckBox ID="transportCB" runat="server" Text="Водитель" Font-Size="Small" /></td>
                                             <td style="font-size:xx-small">Возможность предлагать транспорт </td>
                                        </tr>
                                        
                                         <tr>
                                            <td class="auto-style1"> <asp:CheckBox ID="sendCB" runat="server" Text="Смс заказы" Font-Size="Small" /></td>
                                             <td style="font-size:xx-small">Возможность искать транспорт через смс</td>
                                           
                                        </tr>
                                    </table>
                               
                                    <asp:Button ID="ContinueButton" runat="server" CausesValidation="False" CommandName="Continue" Text="Зарегестрировать" ValidationGroup="CreateUserWizard1" CssClass="btn btn-default" OnClick="ContinueButton_Click" OnClientClick=" alert('Спасибо за регистрацию. Управлять профилем можно в личном кабине.')" />

                                    </table>
                                </ContentTemplate>
                            </asp:CompleteWizardStep>
                        </WizardSteps>

                        <CancelButtonStyle CssClass="btn btn-default" />

                    </asp:CreateUserWizard>
                    <asp:Label ID="Label2" runat="server"></asp:Label><asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="warnings" ValidationGroup="CreateUserWizard1" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
