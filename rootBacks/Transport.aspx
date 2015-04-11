<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Transport.aspx.cs" Inherits="Transport" %>

<!-- #include file="content/topincludes.aspx" -->
<body>
    <!-- #include file="content/middleincludes.aspx" -->
    <form id="form1" runat="server">

        <!-- #include file="content/header.aspx" -->

        <div  class="container">
            <%--<ul class="nav nav-tabs" role="tablist">
       
                <li><a href="Offers.aspx">Продажа</a></li>
                <li><a href="Bids.aspx">Покупка</a></li>

                <li class="active"><a href="Transport.aspx">Транспорт</a></li>

                <%if (User.IsInRole("Administrator")) Response.Write(" <li><a href='ActiveContracts.aspx'>Активные контракты</a></li>"); %>
            </ul>--%>


            <div class="row">
                <div  class="col-md-6">
                    <div class="panel panel-default">
                        <div class="panel-heading">
                            <h3 class="panel-title">Для тех кто ищет транспорт</h3>
                        </div>
                        <div class="panel-body">

                            
                                <div class="row">
                                     <div class="col-md-12">
                                          <div class="row">
                                            <div class="col-md-9">  <h3>Закаказать смс рассылку для поиска транспорта</h3></div>
                                              <div class="col-md-3 text-center"> <h3 ><img width="85" height="50" class="img-rounded " src="img/trans1.gif" /></h3></div>
                                          </div>



                                         <br />
                                         <asp:LinkButton ID="Button2" class="btn btn-success btn-lg" PostBackUrl="~/addAutoBid.aspx"  runat="server">Найти транспорт <br /><span class="badge">(15коп./смс)</span> </asp:LinkButton>
                                           
                                         Среди <asp:Label ID="Label1" runat="server" Text="Label" Font-Size="X-Large" ForeColor="#006600" Font-Bold="True"></asp:Label> машин в нашей базе
                                         <h3><small>
                                        
                                         СМС Рассылка позволит Вам быстро найти оптимального перевозчика по выгодной цене в кратчайшие сроки</small></h3>
                                     <%--    <h5>Удобное средство для поиска водителей через смс </h5>--%>
                                     </div>
                                  <%--  <div class="col-md-3 text-right">
                                       
                                    </div>--%>
                                </div>
                        </div>
                    </div>
                </div>

                <div  class="col-md-6">
                    <div class="panel panel-default">
                        <div class="panel-heading">
                            <h3 class="panel-title">Для водителей</h3>
                        </div>
                        <div class="panel-body">


                            
                                <div class="row">
                                     <div class="col-md-12">
                                          <div class="row">
                                            <div class="col-md-9">  <h3>Предложить свой транспорт для сотруднчиества</h3></div>
                                              <div class="col-md-3  text-center"> <h3><img width="85" height="50" class="img-rounded" src="img/thumb2.gif" /></h3></div>
                                          </div>



                                         <br />
                                       

<asp:LinkButton ID="Button3" class="btn btn-warning btn-lg" PostBackUrl="~/addAutoOffer.aspx" runat="server">Предложить транспорт <br /><span class="badge"> (бесплатно)</span></asp:LinkButton>
                                         
                                         <h3><small>
                                        
                                              Регистрация водителей для получения заказов через смс для перевозки c/х продукции</small></h3>
                                     <%--    <h5>Удобное средство для поиска водителей через смс </h5>--%>
                                     </div>
                                  <%--  <div class="col-md-3 text-right">
                                       
                                    </div>--%>
                                </div>

                            


                         </div> 
                        </div>
                    </div>
                

            </div>













           
            <asp:SqlDataSource ID="SqlDataSource1" ConnectionString="Data Source=208.116.7.82\castor;Initial Catalog=dispetcheroff;Persist Security Info=True;User ID=win610476;Password=w~Sxe738" runat="server"  OnSelected="SqlDataSource1_Selected" ProviderName="System.Data.SqlClient"></asp:SqlDataSource>
            <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1" OnItemCommand="Repeater1_ItemCommand1" OnItemDataBound="Repeater1_ItemDataBound" Visible="True">
                <HeaderTemplate>
                    <div id="custem-toolbar">
                        <asp:LoginView ID="LoginView1" runat="server">
                            <RoleGroups>
                                <asp:RoleGroup Roles="Administrator">
                                    <ContentTemplate>
                                       <h3>Стакан заявок водителей (для администраторов)</h3> 
                                        <asp:Button ID="Button1" class="btn btn-default" runat="server" Text="+ Предложить транспорт" PostBackUrl="~/addAutoOffer.aspx" Visible="False" />
                                    </ContentTemplate>
                                </asp:RoleGroup>
                            </RoleGroups>
                        </asp:LoginView>
                    </div>

                    <table class="table-condensed" data-toolbar="#custem-toolbar"
                        data-toggle="table" data-sort-name="date" data-sort-order="desc"
                        data-search="true" data-show-refresh="true"
                        <%-- data-click-to-select="true" data-select-item-name="radioName"--%>>
                        <thead>
                            <tr>
                                <%--   <th data-field="state" data-radio="true"></th>--%>
                                <th data-field="code" data-align="center">Код</th>
                                <th data-field="product" data-sortable="true">Марка</th>
                                <th data-field="quality">Тип</th>
                                <th data-field="tara" data-visible="false" data-sortable="true">Тара</th>
                                <th data-field="cargo">Груз</th>
                                <th data-field="number">Номер</th>
                                <th data-field="height">Высота борта</th>
                                <th data-field="addcargo">Доп. груз</th>
                                <th data-field="value">Общ. вес</th>
                                <th data-field="tel" data-align="center">Телефон</th>
                                <th data-field="date" data-align="center" data-sortable="true">Дата</th>
                                <%-- <th data-field="order">Заказать</th>--%>

                                <%if (User.IsInRole("Administrator")) Response.Write("<th data-field='act'  data-align='center'>Удалить</th>");
                                  else
                                      Response.Write("<th data-field='act' data-visible='false' data-align='center'>Удалить</th>"); %>
                         <asp:LoginView ID="LoginView2" runat="server">
                            <RoleGroups>
                                <asp:RoleGroup Roles="Administrator">
                                    <ContentTemplate>
                                         <th data-field="isActive">Допуск</th>
                                    </ContentTemplate>
                                </asp:RoleGroup>
                            </RoleGroups>
                        </asp:LoginView>

                                
                              
                            </tr>
                        </thead>
                        <tbody>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <%-- <td></td>--%>
                        <td><%# DataBinder.Eval(Container.DataItem,"code") %></td>
                        <td><%# DataBinder.Eval(Container.DataItem,"autoMakeName") %></td>

                        <td><%# DataBinder.Eval(Container.DataItem,"autoTypeName") %></td>
                        <td><%# DataBinder.Eval(Container.DataItem,"tare") %></td>
                        <td><%# DataBinder.Eval(Container.DataItem,"cargo") %></td>
                        <td><%# DataBinder.Eval(Container.DataItem,"autoNumber") %></td>

                        <td><%# DataBinder.Eval(Container.DataItem,"bortHeight") %></td>

                        <td><%# DataBinder.Eval(Container.DataItem,"addCargoName") %></td>
                        <td><%# DataBinder.Eval(Container.DataItem,"value") %></td>



                        <td><%# CheckRoleForTel(FormatPhoneNumber(DataBinder.Eval(Container.DataItem,"tel").ToString())) %></td>
                        <td><%# DataBinder.Eval(Container.DataItem,"createDate","{0:dd.MM.yyyy}")%></td>
                        <%--  <td><button type="button" class="btn btn-default">Продать</button></td>--%>
                        <td>
                            <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Delete" CommandArgument='<%# Eval("code") %>' OnClientClick="return confirm('Вы уверены что хотите удалить это объявление?');"><i class="glyphicon glyphicon-remove"></i></asp:LinkButton></td>

                         <asp:LoginView ID="LoginView2" runat="server">
                            <RoleGroups>
                                <asp:RoleGroup Roles="Administrator">
                                    <ContentTemplate>
                                         <td> <asp:CheckBox ID="CheckBox1" runat="server" /></td>
                                    </ContentTemplate>
                                </asp:RoleGroup>
                            </RoleGroups>
                        </asp:LoginView>
                        

                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </tbody>
                    </table>
                </FooterTemplate>


            </asp:Repeater>
            <hr />
            <asp:Button class="btn btn-default" ID="backButton" runat="server" Text="Назад" PostBackUrl="~/IntroPage.aspx" Font-Bold="True" />
        </div>

        <!-- #include file="content/footer.aspx" -->
    </form>

    <!-- #include file="content/bottomincludes.aspx" -->
</body>
</html>
