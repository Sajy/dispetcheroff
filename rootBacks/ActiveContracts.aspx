<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ActiveContracts.aspx.cs" Inherits="ActiveContracts" %>

<!-- #include file="content/topincludes.aspx" -->
<body>
    <!-- #include file="content/middleincludes.aspx" -->
    <form id="form1" runat="server">
        <!-- #include file="content/header.aspx" -->
        <div style="margin-top: 37px;" class="container">
           <%-- <ul class="nav nav-tabs" role="tablist">
            
                <li><a href="Offers.aspx">Продажа</a></li>
                <li><a href="Bids.aspx">Покупка</a></li>
                <li><a href="Transport.aspx">Транспорт</a></li>
                 <%if (User.IsInRole("Administrator")) Response.Write(" <li class='active'><a href='ActiveContracts.aspx'>Активные контракты</a></li>"); %>
            </ul>--%>


            <div class="page-header">

                <div class="row">
                    <div class="col-md-6">
                        <h1>Активные контракты<small>
                            <br />
                            добавление и редактирование</small></h1>
                    </div>
                    <div class="col-md-6 text-right">
                        <img width="170" height="100" class="img-rounded" src="img/contract2.gif" />
                    </div>
                </div>
                <hr />

                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=208.116.7.82\castor;Initial Catalog=dispetcheroff;Persist Security Info=True;User ID=win610476;Password=w~Sxe738" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [activeContracts]"
                      DeleteCommand="DELETE FROM [offers] WHERE [id] = 30">
                    
                    </asp:SqlDataSource>

                 <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1" OnItemCommand="Repeater1_ItemCommand" >
                <HeaderTemplate>
                    <div id="custem-toolbar">
                        <asp:Button ID="Button1" class="btn btn-success" runat="server" Text="+ Новый активный контракт" PostBackUrl="~/addContract.aspx"  />
                        
                    </div>

                    <table class="table-condensed" data-toolbar="#custem-toolbar"
                        data-toggle="table" data-sort-name="date" data-sort-order="desc"
                        data-search="true" data-show-refresh="true"
                        <%-- data-click-to-select="true" data-select-item-name="radioName"--%>>
                        <thead>
                            <tr>
                                <%--   <th data-field="state" data-radio="true"></th>--%>
                                <th data-field="name" data-align="left">Активный контракт</th>
                             
                                <th data-field="act" data-align="center">Удалить</th>
                            </tr>
                        </thead>
                        <tbody>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <%-- <td></td>--%>
                        <td><%# DataBinder.Eval(Container.DataItem,"text") %></td>
                   
                        <td>
                            <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Delete" CommandArgument='<%# Eval("id") %>' OnClientClick="return confirm('Вы уверены что хотите удалить этот контракт?');"><i class="glyphicon glyphicon-remove"></i></asp:LinkButton></td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </tbody>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
             
            </div>

               <asp:Button class="btn btn-default" ID="backButton" runat="server" Text="Назад" PostBackUrl="~/PrivateArea.aspx" Font-Bold="True" />

  </div>
        <!-- #include file="content/footer.aspx" -->
    </form>
    <!-- #include file="content/bottomincludes.aspx" -->
</body>
</html>
