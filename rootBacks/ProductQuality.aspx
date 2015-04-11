<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductQuality.aspx.cs" Inherits="ProductQuality" %>

<!-- #include file="content/topincludes.aspx" -->
<body>
    <!-- #include file="content/middleincludes.aspx" -->
    <form id="form1" runat="server">

        <!-- #include file="content/header.aspx" -->

        <div class="container">
            <div class="panel panel-info">
                <div class="panel-heading">
                    <h4>Редактор качества продукции</h4>
                </div>
                <div class="panel-body">

                    <h3>Пшеница 3 класс</h3>
                    <br />
                    <table class="table">
                        <tr>
                            <th>Показатель</th>
                            <th>Норма</th>
                            <th>Факт</th>
                        </tr>
                        <tr>
                            <td>Влажность</td>
                            <td>14%</td>
                            <td>
                                <asp:TextBox ID="TextBox3" class="form-control" runat="server" Text="11%" Width="100"></asp:TextBox>
                            </td>


                        </tr>
                        <tr>
                            <td>Белок</td>
                            <td>12%</td>
                            <td>
                                <asp:TextBox ID="TextBox1" class="form-control" runat="server" Text="13%"  Width="100"></asp:TextBox>
                            </td>

                        </tr>
                        <tr>
                            <td>Клейковина</td>
                            <td>21%</td>
                            <td>
                                <asp:TextBox ID="TextBox2" class="form-control" runat="server" Text="18%"  Width="100"></asp:TextBox>
                            </td>
                        </tr>

                    </table>
                    <br />
                     <asp:Button class="btn btn-info" ID="OkButton" runat="server" CommandName="Insert" Text="Сохранить" PostBackUrl="~/Offers.aspx" />
                    <asp:Button class="btn btn-info" ID="CancelButton" runat="server" CommandName="Cancel" Text="Отмена" PostBackUrl="~/Offers.aspx" />
                </div>
            </div>
        </div>

        <!-- #include file="content/footer.aspx" -->
    </form>

    <!-- #include file="content/bottomincludes.aspx" -->
</body>
</html>
