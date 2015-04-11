<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MemberArea.aspx.cs" Inherits="MemberArea" %>

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
    <style>
        body {
            padding-top: 50px;
            padding-bottom: 20px;
        }

        .jumbotron {
            background-color: wheat;
            padding-top: 10px;
            padding-bottom: 1px;
            margin-bottom: 15px;
            background-image: url(img/wheat.png);
            
        }

        .panel {
            margin-top: 0px;
            padding: 0px;
        }
    </style>
    <script>
        $(document).ready(function () {
            $("#colapsLabel").click(function (e) {
                alert('ddd');
            });
        });

    </script>
    <link rel="stylesheet" href="css/bootstrap-theme.min.css">
    <link rel="stylesheet" href="css/main.css">

    <script src="js/vendor/modernizr-2.6.2-respond-1.1.0.min.js"></script>
</head>
<body>

   <!-- #include file="header.html" -->

    <form id="form1" runat="server">
   
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Вы не ввели номер телефона" ControlToValidate="telephone" EnableClientScript="True" EnableViewState="True" Display="None"></asp:RequiredFieldValidator><br />
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Номер телефона состоит из 10 цифр ПРИМЕР: 0632221133" ControlToValidate="telephone" ValidationExpression="\d{10,10}" EnableClientScript="True" Display="None"></asp:RegularExpressionValidator>
   


        <div class="container">
            <div id="privateAreaPanel" class="panel panel-default hide ">
                <div class="panel-heading ">

                            <h4 class="panel-title ">

                                <a  id="captionAnchor" data-toggle="collapse" data-parent="#accordion" href="#collapseOne">Личный кабинет
                                    <asp:Label ID="captionLabel" runat="server" Font-Bold="False"></asp:Label>
                                </a>
                            </h4>
                       
                      
                </div>
                <div id="collapseOne" class="panel-collapse  ">
                    <div class="panel-body ">

                        <div class="row">
                            <div class="col-md-2"><strong>Пользователь:</strong><br>
                                Сергей </div>
                            <div class="col-md-2 "><strong>Телефон:
                                <br>
                            </strong>+380632221122
                                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>

                            </div>
                            <div class="col-md-2 "><strong>Статус:</strong>
                                <br>
                                <asp:Label ID="Label2" runat="server" Text="Неактивен"></asp:Label>
                               <%--  <asp:Button ID="activationButton"  class="btn btn-success" data-toggle="modal" data-target="#activationDialog" runat="server" Text="Активировать" OnClick="activationButton_Click"  />--%>
                                <button id="activationButton" type="button" class="btn btn-success" data-toggle="modal" data-target="#activationDialog">Активировать</button>
                           </div>

                         <%--   <div class="col-md-1 ">
                                <%--<button id="activationButton" type="button" class="btn btn-success" data-toggle="modal" data-target="#activationDialog">Активировать</button>
                               
                               
                            </div> --%>
                            <div class="col-md-2 "><strong>На вашем счету:</strong>
                                <br>
                                <asp:Label ID="moneyLabel" runat="server" Text=""></asp:Label>
                                 <button type="button" class="btn btn-info">Пополнить счет</button>
                            </div>
                          <%--  <div class="col-md-2 ">
                               </div>
                            --%>
                            <div class="col-md-1 "><asp:Button class="btn btn-warning" ID="Button1" runat="server" Text="Выход" OnClick="Button1_Click" CausesValidation="False" UseSubmitBehavior="False" /></div>
                        </div>
                        <hr>

                        <!--Диалог активации-->
                        <div class="modal fade" id="activationDialog" tabindex="-1" role="dialog" aria-labelledby="activationDialogModalLabel" aria-hidden="true">
                            <div class="modal-dialog modal-sm">
                                <div class="modal-content">
                                    <div class="modal-header">
                                        <button type="button" class="close" data-dismiss="modal"><span aria-hidden="true">&times;</span><span class="sr-only">Close</span></button>
                                        <h4 class="modal-title" id="activationDialogModalLabel">Для активации аккаунта заполните форму</h4>
                                    </div>
                                    <div class="modal-body">
                                        <div class="form-group">
                                            <label for="smsCode">Код пришедший на телефон  
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="смс код должен быть длиной 6 цифр;" ControlToValidate="smsCode" ValidationExpression="\d{6,6}">*</asp:RegularExpressionValidator>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Вы не ввели смс;" ControlToValidate="smsCode" Display="Static" Text="*">*</asp:RequiredFieldValidator>
                                               
                                            </label>
                                            <asp:TextBox ID="smsCode" class="form-control"  placeholder="код и смс" runat="server" MaxLength="6"></asp:TextBox>
                                             <asp:CompareValidator ID="CompareValidator2" runat="server" ErrorMessage="Код не верен" ControlToValidate="smsCode" ValueToCompare="999999"></asp:CompareValidator>
                                          
                                           
                                            <%-- <input type="text" class="form-control" id="smsCode" placeholder="код и смс">--%>
                                        </div>
                                        <div class="form-group">
                                            <label for="smsCode">Не пришла смс?</label>
                                            <button class="btn btn-success">Выслать еще раз (3)</button>
                                        </div>


                                        <div class="form-group">
                                            <label for="password">
                                                Пароль
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Введите пароль;" ControlToValidate="password">*</asp:RequiredFieldValidator>
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="Пароль от 3-10 символов;" ControlToValidate="password" ValidationExpression="\d{3,10}">*</asp:RegularExpressionValidator>
                                            </label>
                                            <asp:TextBox type="password" class="form-control" id="password" placeholder="придумайте пароль" runat="server" MaxLength="10"></asp:TextBox>
                                          <%--  <input type="password" class="form-control" id="password" placeholder="придумайте пароль">--%>

                                        </div>
                                        <div class="form-group">
                                            <label for="passwordRepeat">Повторите пароль
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Требуется повторить пароль;" ControlToValidate="passwordRepeat">*</asp:RequiredFieldValidator>
                                                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Пароли должны совпадать" ControlToCompare="passwordRepeat" ControlToValidate="password">*</asp:CompareValidator>
                                            </label>
                                            <asp:TextBox type="password" class="form-control" id="passwordRepeat" placeholder="повторите пароль" runat="server" MaxLength="10"></asp:TextBox>
                                           <%-- <input type="password" class="form-control" id="passwordRepeat" placeholder="поаторите пароль">--%>
                                         
                                        </div>
                                           <asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="List" />
                                       
                                    </div>
                                    <div class="modal-footer">
                                      <%--  <button type="button" class="btn btn-default" data-dismiss="modal">Автивировать</button>--%>
                                        <asp:Button ID="Button2" runat="server" Text="Активировать"  data-dismiss="modal" class="btn btn-default" OnClick="Button2_Click" CausesValidation="False" UseSubmitBehavior="False" />
                                       <%-- <asp:Button ID="Button2 " runat="server" Text="Активировать"  class="btn btn-default" />--%>
                                        <button type="button" class="btn btn-default" data-dismiss="modal">Отменить</button>
                                        
                                        <!--        <button type="button" class="btn btn-primary">Save changes</button>-->
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!--Диалог активации конец-->


                         <!--Диалог нового обявления на продажу-->
                        <%--<div class="modal fade" id="newOfferDialog" tabindex="-1" role="dialog" aria-labelledby="newOfferDialogModalLabel" aria-hidden="true">
                            <div class="modal-dialog modal-sm">
                                <div class="modal-content">
                                    <div class="modal-header">
                                        <button type="button" class="close" data-dismiss="modal"><span aria-hidden="true">&times;</span><span class="sr-only">Close</span></button>
                                        <h4 class="modal-title" id="newOfferDialogModalLabel">Публикация объявления на продажу</h4>
                                    </div>
                                    <div class="modal-body">
                                        

                                    </div>
                                    <div class="modal-footer">
                                        <button type="button" class="btn btn-default" data-dismiss="modal">Опубликовать</button>
                                        <button type="button" class="btn btn-default" data-dismiss="modal">Отменить</button>
                                        <!--        <button type="button" class="btn btn-primary">Save changes</button>-->
                                    </div>
                                </div>
                            </div>
                        </div>--%>
                        <!--Диалог нового обявления на продажу конец-->






                        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="Data Source=208.116.7.82\castor;Initial Catalog=dispetcheroff;Persist Security Info=True;User ID=win610476;Password=w~Sxe738" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [user].id, serviceDescr.name, serviceDescr.purpose, services.active, services.price, services.endDate, services.activationTime FROM [user] INNER JOIN personalArea ON [user].id = personalArea.usrId INNER JOIN services ON [user].id = services.userId INNER JOIN serviceDescr ON services.serviceDescrId = serviceDescr.id WHERE ([user].id = @Param1)">
                            <SelectParameters>
                                <asp:Parameter DefaultValue="1" Name="Param1" />
                            </SelectParameters>
                        </asp:SqlDataSource>
                        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="Data Source=208.116.7.82\castor;Initial Catalog=dispetcheroff;Persist Security Info=True;User ID=win610476;Password=w~Sxe738" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [user].name, [user].tel, personalArea.money, personalArea.activated, [user].id FROM [user] INNER JOIN personalArea ON [user].id = personalArea.usrId WHERE ([user].id = @Param1)">
                            <SelectParameters>
                                <asp:QueryStringParameter Name="Param1" QueryStringField="user" />
                            </SelectParameters>
                        </asp:SqlDataSource>
                        <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="Data Source=208.116.7.82\castor;Initial Catalog=dispetcheroff;Persist Security Info=True;User ID=win610476;Password=w~Sxe738" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [user].id,[user].tel FROM personalArea INNER JOIN [user] ON personalArea.usrId = [user].id WHERE ([user].tel = @Param1)" OnSelected="SqlDataSource4_Selected">
                            <SelectParameters>
                                <asp:Parameter Name="Param1" />
                            </SelectParameters>
                        </asp:SqlDataSource>
                        <asp:Repeater ID="Repeater2" runat="server" DataSourceID="SqlDataSource2">
                            <HeaderTemplate>

                                <table class="table table-bordered">

                                    <tr>
                                        <th>Ваши права</th>
                                        <th>Кому удобно</th>
                                        <th>Активировано</th>
                                        <th>Истекает</th>
                                        <th>Цена</th>
                                        <th>Продлить</th>

                                    </tr>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tr>

                                    <td><a href="addOffer.aspx"><%# DataBinder.Eval(Container.DataItem,"name") %></a></td>
                                    <td><%# DataBinder.Eval(Container.DataItem,"purpose") %></td>
                                    <%-- <td><%# System.Convert.ToBoolean(DataBinder.Eval(Container.DataItem,"active"))==true 
                                    Response.Write("Да") %></td>--%>
                                    <td><asp:Label ID="Label1" runat="server" Text="" OnDataBinding="Label1_DataBinding"></asp:Label></td>
                                    <td><%# DataBinder.Eval(Container.DataItem,"endDate") %></td>
                                    <td><%# DataBinder.Eval(Container.DataItem,"price") %></td>
                                    <td>
                                        <button type="button" class="btn btn-default">Продлить</button></td>
                                </tr>



                            </ItemTemplate>
                            <FooterTemplate>
                                </table>
                            </FooterTemplate>

                        </asp:Repeater>


                        <%--          <table class="table table-bordered">

                        <tr>
                            <th>Ваши права</th>
                            <th>Кому удобно</th>
                            <th>Действие</th>
                            <th>Истекает</th>
                            <th>Цена</th>
                            <th>Продлить</th>

                        </tr>
                        <tr>
                            <td><a href="#">Дать объявление на продажу</a></td>
                            <td>покупатели</td>
                            <td>Активна</td>
                            <td>X</td>
                            <td>100 грн/мес</td>
                            <td><button type="button" class="btn btn-info">Продлить</button></td>
                        </tr>
                        <tr>
                            <td>Дать объявление на покупку</td>
                            <td>продавцы</td>
                            <td>Активна</td>
                            <td>X</td>
                            <td>100 грн/мес</td>
                            <td><button type="button" class="btn btn-default">Продлить</button></td>
                        </tr>
                        <tr>
                            <td>Предложить транспорт</td>
                            <td>продавцы</td>
                            <td>Активна</td>
                            <td>X</td>
                            <td>100 грн/мес</td>
                            <td><button type="button" class="btn btn-info">Продлить</button></td>
                        </tr>
                        <tr>
                            <td>Искать транспорт</td>
                            <td>продавцы</td>
                            <td>Активна</td>
                            <td>X</td>
                            <td>100 грн/мес</td>
                            <td><button type="button" class="btn btn-info">Продлить</button></td>
                        </tr>
                        <tr>
                            <td>Разослать водителям смс</td>
                            <td>продавцы</td>
                            <td>Активна</td>
                            <td>X</td>
                            <td>100 грн/мес</td>
                            <td><button type="button" class="btn btn-info">Продлить</button></td>
                        </tr>



                    </table>--%>
                    </div>
                </div>
            </div>

        </div>
        <!--        Личный кабинет конец-->


        <!-- Main jumbotron for a primary marketing message or call to action -->
        <div class="container">
            <div id="jmbTrn" class="jumbotron center-block ">

                <h1>Онлайн зерновой агент</h1>
                <p>Удобная покупка, продажа и транспортировка</p>
                <p><a class="btn btn-primary btn-lg" data-toggle="modal" data-target="#myModal">Регистрация>>></a></p>

            </div>
        </div>


        <div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
            <div class="modal-dialog modal-sm">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal"><span aria-hidden="true">&times;</span><span class="sr-only">Close</span></button>
                        <h4 class="modal-title" id="myModalLabel">Для регистрации введите номер вашего мобильного телефона</h4>
                    </div>
                    <div class="modal-body">


                        <h3>Номер телефона</h3>
                      <%--  <input type="text" placeholder="Телефон" class="form-control">--%>
                        <asp:TextBox ID="telephone" runat="server"  placeholder="Телефон" class="form-control" MaxLength="10">0632221133</asp:TextBox>
                    
                        <asp:Label ID="Label4" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </div>
                    <div class="modal-footer">
                        <asp:Button ID="Button3"  data-dismiss="modal" class="btn btn-default" runat="server" Text="Продолжить" OnClick="Button3_Click" UseSubmitBehavior="False" CausesValidation="False" />
                        
                      <%--  <button type="button" class="btn btn-default" data-dismiss="modal">Продолжить</button>--%>
                        <!--        <button type="button" class="btn btn-primary">Save changes</button>-->
                    </div>
                </div>
            </div>
        </div>
        <div class="container">

            <ul class="nav nav-tabs" role="tablist">
                <li class="active"><a href="#tosale" role="tab" data-toggle="tab">
                    <h4>Продажа</h4>
                </a></li>
                <li><a href="#transport" role="tab" data-toggle="tab">
                    <h4>Транспорт</h4>
                </a></li>
                <li><a href="#tobuy" role="tab" data-toggle="tab">
                    <h4>Покупка</h4>
                </a></li>

            </ul>

            <!-- Tab panes -->
            <div class="tab-content">
                <div class="tab-pane active" id="tosale">
                    <br>
                    <h5>Текущие предложения на дату 3.09.2014</h5>
                    <br>
                    <!-- Example row of columns -->

                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=208.116.7.82\castor;Initial Catalog=dispetcheroff;Persist Security Info=True;User ID=win610476;Password=w~Sxe738" ProviderName="System.Data.SqlClient" SelectCommand="SELECT     products.name AS productName, region.name AS regionName, district.Name AS districtName, quality.name AS qualityName, 
		storePlace.name AS storePlaceName, offers.city, offers.value,  offers.price, offers.tel
                      
FROM         offers  INNER JOIN
                      products ON offers.productId = products.id INNER JOIN
                      region ON offers.regionId = region.id INNER JOIN
                      district ON offers.districtId = district.Id INNER JOIN
                      quality ON offers.qualityId = quality.id INNER JOIN
                      storePlace ON offers.storePlaceId = storePlace.id"></asp:SqlDataSource>
                    <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1">

                        <HeaderTemplate>

                            <table class="table">
                                <tr>

                                    <th>Товар</th>
                                    <th>Тип</th>
                                    <th>Регион</th>
                                    <th>Хранение</th>
                                    <th>Количество</th>
                                    <th>Цена</th>
                                    <th>Телефон</th>
                                    <th>Заказать </th>
                                </tr>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <tr>

                                <td><%# DataBinder.Eval(Container.DataItem,"productName") %></td>
                                <td><%# DataBinder.Eval(Container.DataItem,"qualityName") %></td>
                                <td><%# DataBinder.Eval(Container.DataItem,"regionName") %></td>
                                <td><%# DataBinder.Eval(Container.DataItem,"storePlaceName") %></td>
                                <td><%# DataBinder.Eval(Container.DataItem,"value") %></td>
                                <td><%# DataBinder.Eval(Container.DataItem,"price") %></td>
                                <td><%# DataBinder.Eval(Container.DataItem,"tel") %></td>
                                <td>
                                    <button type="button" class="btn btn-info">Купить сейчас</button></td>
                            </tr>



                        </ItemTemplate>
                        <FooterTemplate>
                            </table>
                        </FooterTemplate>
                    </asp:Repeater>


                    <br />

                    <%--  <table class="table">
                    <tr>
                       
                        <th>Товар</th>
                        <th>Тип</th>
                        <th>Регион</th>
                        <th>Хранение</th>
                        <th>Количество</th>
                        <th>Цена</th>
                        <th></th>
                    </tr>
                    <tr>
                      
                        <td>Пшеница</td>
                        <td>2 класс</td>
                        <td>Николаевская</td>
                        <td>Хозяйство</td>
                        <td>300</td>
                        <td>3900</td>
                        <td><button type="button" class="btn btn-info">Купить сейчас</button></td>
                    </tr>
                    <tr>
                      
                        <td>Ячмень</td>
                        <td>3 класс</td>
                        <td>Херсонская</td>
                        <td>Хозяйство</td>
                        <td>3000</td>
                        <td>2700</td>
                        <td><button type="button" class="btn btn-info">Купить сейчас</button></td>
                    </tr>
                    <tr>
                      
                        <td>Ячмень</td>
                        <td>3 класс</td>
                        <td>Херсонская</td>
                        <td>Хозяйство</td>
                        <td>3000</td>
                        <td>2700</td>
                        <td><button type="button" class="btn btn-info">Купить сейчас</button></td>
                    </tr>
                    <tr>
                     
                        <td>Ячмень</td>
                        <td>3 класс</td>
                        <td>Херсонская</td>
                        <td>Хозяйство</td>
                        <td>3000</td>
                        <td>2700</td>
                        <td><button type="button" class="btn btn-info">Купить сейчас</button></td>
                    </tr>
                     <tr>
                      
                        <td>Ячмень</td>
                        <td>3 класс</td>
                        <td>Херсонская</td>
                        <td>Хозяйство</td>
                        <td>3000</td>
                        <td>2700</td>
                        <td><button type="button" class="btn btn-info">Купить сейчас</button></td>
                    </tr>


                </table>    --%>
                </div>
                <div class="tab-pane" id="transport">...</div>
                <div class="tab-pane" id="tobuy">...</div>

            </div>
        </div>



        <div class="container">
            <hr>

            <footer>
                <p>&copy; Dispetcheroff.net 2014</p>
            </footer>
        </div>
        <!-- /container -->
        <script src="//ajax.googleapis.com/ajax/libs/jquery/1.11.0/jquery.js"></script>
        <script>window.jQuery || document.write('<script src="js/vendor/jquery-1.11.0.js"><\/script>')</script>

        <script src="js/vendor/bootstrap.min.js"></script>

        <script src="js/main.js"></script>

        <!-- Google Analytics: change UA-XXXXX-X to be your site's ID. -->
        <script>
            (function (b, o, i, l, e, r) {
                b.GoogleAnalyticsObject = l; b[l] || (b[l] =
                function () { (b[l].q = b[l].q || []).push(arguments) }); b[l].l = +new Date;
                e = o.createElement(i); r = o.getElementsByTagName(i)[0];
                e.src = '//www.google-analytics.com/analytics.js';
                r.parentNode.insertBefore(e, r)
            }(window, document, 'script', 'ga'));
            ga('create', 'UA-XXXXX-X'); ga('send', 'pageview');
        </script>




    </form>

</body>
</html>
