<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PrivateArea.aspx.cs" Inherits="PrivateArea" %>


<!-- #include file="content/topincludes.aspx" -->
<body>
    <!-- #include file="content/middleincludes.aspx" -->
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <!-- #include file="content/header.aspx" -->

        <div style="margin-top: 37px;" class="container">
                    <div class="panel panel-default" style="margin-bottom: 0px; margin-top: 10px;">
                        <div class="panel-heading">
                            <h4 class="panel-title text-right">

<%--                                <a id="captionAnchor" data-toggle="collapse" data-parent="#accordion" href="#collapseOne">Добро пожаловать в Личный Кабинет, <strong><%Response.Write(User.Identity.Name);%></strong>

                                </a>--%>

                             
                                <a href="IntroPage.aspx">   <span class="label label-warning">Закрыть(Х)</span></a>

                            </h4>
                        </div>




                        <div id="collapseOne" class="panel-collapse  collapse in">
                            <div class="panel-body">

                                <table class="table table-bordered">
                                    <tr>
                                     
                                        <td>На вашем счету:  <% Response.Write("<span class='badge'>" + Convert.ToString(Profile.Money) + " грн.</span>");%>
                                            <br /><br />
                                            <form role="form88" id="payment" name="payment" method="post" enctype="utf-8">
                                                <input type="hidden" name="ik_co_id" value="5416be5cbf4efcce2aab5e58" />
                                                <input type="hidden" name="ik_pm_no" value="ID_4233" />
                                                <input type="hidden" name="ik_am" value="100.00" />
                                                <input type="hidden" name="ik_cur" value="UAH" />
                                                <input type="hidden" name="ik_desc" value="Оплата за услугу " />
                                                <button type="submit" class="btn btn-success btn-sm" formaction="https://sci.interkassa.com/">Пополнить?</button>
                                            </form>

                                        </td>
                                        <td><%if (Profile.isActivated) Response.Write("Ваш аккаунт: <span class='badge'>активирован</span>"); else Response.Write("Ваш аккаунт <span class='badge'>неактивен                             </span> <a data-toggle='modal' data-target='#activDialog' href='#'>Активировать?</a>"); %><br /><br />
                                          
                                            <asp:Button ID="Button4" class="btn btn-default btn-sm" runat="server" Text="Деактивировать (для тестов активации)" CausesValidation="False" OnClick="Button4_Click" /></td>


                                    </tr>
                                </table>


                                <br />





                                <table class="table table-bordered  ">
                                    <tr >
                                        <%-- <th><a href="Offers.aspx?uid=<%Response.Write(getUid());%>.aspx">МОИ ОБЪЯВЛЕНИЯ НА ПРОДАЖУ</a></th>--%>
                                        <th ><a  class=" no-under " href="Offers.aspx"><span class="label label-primary">МОИ ОБЪЯВЛЕНИЯ НА ПРОДАЖУ</span></a></th>
                                        <th><a href="Bids.aspx"><span class="label label-primary ">МОИ ОБЪЯВЛЕНИЯ НА ПОКУПКУ</span></a></th>
                                        <th><a href="Transport.aspx"><span class="label label-primary ">МОИ ПРЕДЛОЖЕНИЯ ДЛЯ ТРАСПОРТА</span></a></th>


                                        <asp:LoginView ID="LoginView1" runat="server">
                                            <RoleGroups>
                                                <asp:RoleGroup Roles="Administrator">
                                                    <ContentTemplate>
                                                        <th><a href="ActiveContracts.aspx"><span class="label label-primary ">АКТИВНЫЕ КОНТРАКТЫ</span></a></th>
                                                        <th><a href="addAutoBidAdmin.aspx"><span class="label label-primary ">СМС Рассылки (админ)</span></a></th>

                                                    </ContentTemplate>
                                                </asp:RoleGroup>
                                            </RoleGroups>
                                        </asp:LoginView>



                                    </tr>
                                </table>
                                <hr />
                                <table class="table table-bordered">
                                    <tr>

                                        <th>Мои услуги</th>
                                        <th>Цена</th>
                                        <th>Активна</th>
                                        <th>Заказ</th>
                                        <th>Активирована</th>
                                        <th>Завершается</th>
                                    </tr>
                                    <tr class="success">

                                        <td><a href="addOffer.aspx">Дать объявление на продажу</a></td>
                                        <td>Бесплатно</td>
                                        <td class="text-center"><i class="glyphicon glyphicon-ok"></i></td>
                                        <td class="text-center"></a></td>
                                        <td class="text-center"></td>
                                        <td class="text-center"></td>

                                    </tr>
                                    <tr class="success">

                                        <td><a href="addBid.aspx">Дать объявление на покупку</a></td>
                                        <td>Бесплатно</td>
                                        <td class="text-center"><i class="glyphicon glyphicon-ok"></i></td>
                                        <td class="text-center"></a></td>
                                        <td class="text-center"></td>
                                        <td class="text-center"></td>

                                    </tr>
                                    <tr class="success">

                                        <td><a href="addAutoOffer.aspx">Предложить свой транспорт</a></td>
                                        <td>Бесплатно</td>
                                        <td class="text-center"><i class="glyphicon glyphicon-ok"></i></td>
                                        <td class="text-center"></a></td>
                                        <td class="text-center"></td>
                                        <td class="text-center"></td>

                                    </tr>

                                    <tr>

                                        <td><a href="Offers.aspx">Видеть контакты продавцов</a></td>
                                        <td>100 грн./мес </td>
                                        <td class="text-center"><i class="glyphicon glyphicon-remove"></i></td>
                                        <td class="text-center">
                                            <asp:CheckBox ID="SellContractsCB" runat="server"  OnCheckedChanged="SellContractsCB_CheckedChanged" /></td>
                                        <td class="text-center">-</td>
                                        <td class="text-center">-</td>

                                    </tr>
                                    <tr>

                                        <td><a href="Bids.aspx">Видеть контакты покупателей</a></td>
                                        <td>80 грн./мес </td>
                                        <td class="text-center"><i class="glyphicon glyphicon-remove"></i></td>
                                        <td class="text-center">
                                            <asp:CheckBox ID="BuyContactsCB" runat="server" OnCheckedChanged="BuyContactsCB_CheckedChanged"  />
                                         </td>
                                        <td class="text-center">-</td>
                                        <td class="text-center">-</td>
                                    </tr>
                                    <tr>

                                        <td><a href="Transport.aspx">Видеть контакты водителей</a></td>
                                        <td>50 грн./мес </td>
                                        <td class="text-center"><i class="glyphicon glyphicon-remove"></i></td>
                                        <td class="text-center">
                                            <asp:CheckBox ID="SauggestTransportCB" runat="server" OnCheckedChanged="SauggestTransportCB_CheckedChanged" /> </td>
                                        <td class="text-center">-</td>
                                        <td class="text-center">-</td>
                                    </tr>
                                    <tr>

                                        <td><a href="#">Получать заказы на транспорт (для водителей)</a></td>
                                        <td>30 грн./мес  </td>
                                        <td class="text-center"><i class="glyphicon glyphicon-remove"></i></td>
                                        <td class="text-center">
                                            
                                            <asp:CheckBox ID="GetTransportOrdersCB" runat="server" OnPreRender="GetTransportOrdersCB_PreRender" OnCheckedChanged="GetTransportOrdersCB_CheckedChanged"/></td>
                                        <td class="text-center">-</td>
                                        <td class="text-center">-</td>
                                    </tr>
                                    <tr>

                                        <td><a href="#">Рассылка SMS по водителям (поиск перевозчика) </a></td>
                                        <td>30 коп./смс  </td>
                                        <td class="text-center"><i class="glyphicon glyphicon-remove"></i></td>
                                        <td class="text-center">
                                            <asp:CheckBox ID="SendSMSDriverCB" runat="server" OnCheckedChanged="SendSMSDriverCB_CheckedChanged"  /></td>
                                        <td class="text-center">-</td>
                                        <td class="text-center">-</td>
                                    </tr>
                                </table>


                            </div>
                        </div>
                    </div>
                </div>

        
        <!--Диалог активации-->
        <div class="modal fade" id="activDialog" tabindex="-1" role="dialog" aria-labelledby="activDialogLabel" aria-hidden="true">
            <div class="modal-dialog modal-sm">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal"><span aria-hidden="true">&times;</span><span class="sr-only">Закрыть</span></button>
                        <h4 class="modal-title" id="activDialogLabel">Активация личного кабинета</h4>
                    </div>
                    <div class="modal-body">

                        <h4>Номер на который придет СМС</h4>
                        <form class="form-inline" role="form">
                            <div class="form-group">
                                <asp:TextBox ID="telephone" runat="server" placeholder="Телефон" class="form-control" MaxLength="10">0632221133</asp:TextBox>

                                <asp:UpdatePanel ID="UpdatePanel1" runat="server">

                                    <ContentTemplate>

                                        <asp:Button ID="Button1" class="btn btn-default" runat="server" Text="Прислать смс" OnClick="Button1_Click" UseSubmitBehavior="False" /><br />

                                        <asp:Label ID="Label1" runat="server" Text="" Font-Bold="True" ForeColor="#006600"></asp:Label>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                                <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
                                    <ProgressTemplate>
                                        <asp:Label ID="Label2" runat="server" Text="Смс высылается на ваш номер... " ForeColor="Red"></asp:Label>
                                    </ProgressTemplate>


                                </asp:UpdateProgress>
                            </div>
                            <div class="form-group">
                                <label for="TextBox1">
                                    Код из подтверждающего смс       
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Для активации необходимо ввести код из присланной смс" ControlToValidate="TextBox1" Text="*"></asp:RequiredFieldValidator></label>

                                <asp:TextBox ID="TextBox1" class="form-control" placeholder="Код из смс" runat="server" MaxLength="8">99999999</asp:TextBox>

                            </div>
                        </form>


                    </div>

                    <div class="modal-footer">
                        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                            <ContentTemplate>
                                <asp:Button ID="Button3" class="btn btn-default" runat="server" Text="Потвердить" OnClick="Button3_Click1" />
                                <asp:Button ID="Button2" data-dismiss="modal" class="btn btn-default" runat="server" Text="Отмена" UseSubmitBehavior="False" CausesValidation="False" />

                            </ContentTemplate>


                        </asp:UpdatePanel>
                        <asp:UpdateProgress ID="UpdateProgress2" runat="server" AssociatedUpdatePanelID="UpdatePanel2">

                            <ProgressTemplate>
                                <asp:Label ID="Label22" runat="server" Text="Проверка номера... " ForeColor="Red"></asp:Label>
                            </ProgressTemplate>
                        </asp:UpdateProgress>


                        <%--  <button type="button" class="btn btn-default" data-dismiss="modal">Продолжить</button>--%>
                        <!--        <button type="button" class="btn btn-primary">Save changes</button>-->
                    </div>
                </div>
            </div>
        </div>
        <!--Диалог активации end-->

        <!-- #include file="content/footer.aspx" -->
    </form>

    <!-- #include file="content/bottomincludes.aspx" -->
</body>
</html>