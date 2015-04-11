<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Offers.aspx.cs" Inherits="Offers" %>

<!-- #include file="content/topincludes.aspx" -->
<body>
    <!-- #include file="content/middleincludes.aspx" -->
    <form id="form1" runat="server">
        <!-- #include file="content/header.aspx" -->
        <div class="container">
           <%-- <ul class="nav nav-tabs" role="tablist">
             
                <li class="active"><a href="Offers.aspx">Продажа</a></li>
                <li><a href="Bids.aspx">Покупка</a></li>
                <li><a href="Transport.aspx">Транспорт</a></li>
                 <%if (User.IsInRole("Administrator")) Response.Write(" <li><a href='ActiveContracts.aspx'>Активные контракты</a></li>"); %>
            </ul>--%>


            <div class="page-header">

                <div class="row">
                    <div class="col-md-6">
                        <h1>Объявления о продаже <small>
                            <br />
                            для тех кто ищет продукцию</small></h1>
                    </div>
                    <div class="col-md-6 text-right">
                        <img width="170" height="100" class="img-rounded" src="img/thumb1.gif" />
                    </div>
                </div>



            </div>





            


            <div class="row">
                <div class="col-md-12">    <div id="custem-toolbar">
                               
                
                    <div class="form-group">
                     <asp:LoginView ID="LoginView1" runat="server">
                            <RoleGroups>
                                <asp:RoleGroup Roles="Administrator">
                                    <ContentTemplate>
                                     
                                     <asp:Button ID="Button1" class="btn btn-success" runat="server" Text="+ Новое объявление" PostBackUrl="~/addOffer.aspx"  />
                                    </ContentTemplate>
                                </asp:RoleGroup>
                            </RoleGroups>
                        </asp:LoginView>
                        </div>

                  
                    
            <div class="row">
                <div class="col-md-5">
                     <div class="form-group">
                        <label for="DropDownList1">Фильтр по товару
                            <asp:LinkButton ID="Button2" class="glyphicon glyphicon-remove" runat="server" Visible="False" ForeColor="Red" OnClick="Button2_Click" ToolTip="Убрать фильтр"></asp:LinkButton></label>
                        <asp:DropDownList class="form-control input-sm" ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource2" DataTextField="name" DataValueField="id" EnableViewState="False" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AppendDataBoundItems="True">
                            <asp:ListItem Selected="True" Value="-1">Все</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                       
                    
                       </div>
                 <div class="col-md-5">

                   <div class="form-group">
                        <label for="DropDownList2">Фильтр по области
                            <asp:LinkButton ID="LinkButton3" class="glyphicon glyphicon-remove" runat="server" Visible="False" ForeColor="Red" OnClick="LinkButton3_Click" ToolTip="Убрать фильтр"></asp:LinkButton></label>
                        <asp:DropDownList class="form-control input-sm" ID="DropDownList2" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource3" DataTextField="name" DataValueField="id" EnableViewState="False" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" AppendDataBoundItems="True">
                            <asp:ListItem Selected="True" Value="-1">Все</asp:ListItem>
                        </asp:DropDownList>
                    </div>

                     </div>
                       </div>


                  
                       </div>
                         
                    <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1" OnItemCommand="Repeater1_ItemCommand"> 
                         
                <HeaderTemplate>
              
                    <table class="table-condensed" data-toolbar="#custem-toolbar"
                        data-toggle="table" data-sort-name="date" data-sort-order="desc"
                        data-search="true" data-show-refresh="true"
                        <%-- data-click-to-select="true" data-select-item-name="radioName"--%>>
                        <thead>
                            <tr>
                                <%--   <th data-field="state" data-radio="true"></th>--%>
                                <th data-field="code" data-align="center">Код</th>
                                <th data-field="product" data-sortable="true">Товар</th>
                                
                                <th data-field="type1">Тип</th>
                                <th data-field="quality">Качество</th>
                             
                                <th data-field="region" data-sortable="true">Регион</th>
                                <th data-field="store">Хранение</th>
                                <th data-field="quantity" data-align="center" data-sortable="true">Количество</th>
                                <th data-field="price" data-align="center" data-sortable="true">Цена</th>
                            
                                <th data-field="date" data-align="center" data-sortable="true">Дата создания</th>
                                    <th data-field="tel" data-align="center">Телефон</th>
                               <%-- <th data-field="order">Заказать</th>--%>
                                <%if (User.IsInRole("Administrator")) Response.Write("<th data-field='act'  data-align='center'>Удалить</th>"); else
                                        Response.Write("<th data-field='act' data-visible='false' data-align='center'>Удалить</th>"); %>
                            </tr>
                        </thead>
                        <tbody>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        
                        <td><%# DataBinder.Eval(Container.DataItem,"code") %></td>
                        <td><%# DataBinder.Eval(Container.DataItem,"productName") %></td>
                  
                          <td ><%# DataBinder.Eval(Container.DataItem,"qualityName") %></td>
                         <td >
                             
                             <asp:Label ID="Label1" runat="server" Text="" Font-Size="XX-Small">Сор:<%# DataBinder.Eval(Container.DataItem,"sor") %>;</asp:Label>
                             <asp:Label ID="Label2" runat="server" Text="" Font-Size="XX-Small">Вл.:<%# DataBinder.Eval(Container.DataItem,"vlazhnost") %>;</asp:Label>
                             <asp:Label ID="Label3" runat="server" Text="" Font-Size="XX-Small">Белок:<%# DataBinder.Eval(Container.DataItem,"belok") %></asp:Label>
                         </td>
                     

                        <td><%# DataBinder.Eval(Container.DataItem,"regionName") %></td>
                        <td><%# DataBinder.Eval(Container.DataItem,"storePlaceName") %></td>
                        <td><%# DataBinder.Eval(Container.DataItem,"value") %></td>
                        <td><%# DataBinder.Eval(Container.DataItem,"price","{0:f}") %></td>
                      
                        <td><%# DataBinder.Eval(Container.DataItem,"createDate","{0:dd.MM.yyyy}")%></td>
                          <td><%#  CheckRoleForTel( FormatPhoneNumber(DataBinder.Eval(Container.DataItem,"tel").ToString())) %></td>
                      <%--  <td>
                            <button type="button" class="btn btn-default">Узнать контакты</button></td>--%>
                        <td>
                            <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Delete" CommandArgument='<%# Eval("code") %>' OnClientClick="return confirm('Вы уверены что хотите удалить это объявление?');" Font-Bold="False"><i class="glyphicon glyphicon-remove"></i></asp:LinkButton></td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </tbody>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
           


              

          
 

                </div>
               
            </div>



            <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="Data Source=208.116.7.82\castor;Initial Catalog=dispetcheroff;User ID=win610476;Password=w~Sxe738" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [region]"></asp:SqlDataSource>






            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="Data Source=208.116.7.82\castor;Initial Catalog=dispetcheroff;User ID=win610476;Password=w~Sxe738" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [products]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=208.116.7.82\castor;Initial Catalog=dispetcheroff;Persist Security Info=True;User ID=win610476;Password=w~Sxe738" ProviderName="System.Data.SqlClient" OnDeleted="SqlDataSource1_Deleted" OnDeleting="SqlDataSource1_Deleting" SelectCommand="SELECT * FROM [offers]">
                <FilterParameters>
                    <asp:ControlParameter ControlID="DropDownList1" Name="SelectedParameter" PropertyName="SelectedValue" />
                    <asp:ControlParameter ControlID="DropDownList2" Name="SelectedParameter2" PropertyName="SelectedValue" />
                </FilterParameters>
            
            </asp:SqlDataSource>





             <%--<asp:LoginView ID="LoginView1" runat="server">


                            <RoleGroups>
                                <asp:RoleGroup Roles="Guest">
                                    <ContentTemplate>
                                      
                                    </ContentTemplate>
                                </asp:RoleGroup>
                            </RoleGroups>
                        </asp:LoginView>--%>


           

            <hr />
            <asp:Button class="btn btn-default" ID="backButton" runat="server" Text="Назад" PostBackUrl="~/IntroPage.aspx" Font-Bold="True" />
        </div>

        <!-- #include file="content/footer.aspx" -->
    </form>
    <!-- #include file="content/bottomincludes.aspx" -->
</body>
</html>
