<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addContract.aspx.cs" Inherits="addContract" %>

<!-- #include file="content/topincludes.aspx" -->
<body>
    <!-- #include file="content/middleincludes.aspx" -->
    <form id="form1" runat="server">

        <!-- #include file="content/header.aspx" -->

        <div class="container">
            <div class="panel panel-info">
                <div class="panel-heading"><h4>Добавление нового активного контракта</h4></div>
                <div class="panel-body">
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=208.116.7.82\castor;Initial Catalog=dispetcheroff;Persist Security Info=True;User ID=win610476;Password=w~Sxe738" 
                        InsertCommand="INSERT INTO [activeContracts] ([text]) VALUES (@text)" 
                        ProviderName="System.Data.SqlClient" 
                        SelectCommand="SELECT * FROM [activeContracts]" OnInserted="SqlDataSource1_Inserted" >
                       
                        <InsertParameters>
                            <asp:Parameter Name="text" Type="String" />
                        </InsertParameters>
                     
                    </asp:SqlDataSource>
                     <asp:FormView ID="FormView1" runat="server" AllowPaging="True" DataKeyNames="id" DataSourceID="SqlDataSource1" DefaultMode="Insert" HorizontalAlign="Center" Width="100%">
                          <InsertItemTemplate>

                            <div class="row">
                                <div class="col-md-4">


                                    <div class="form-group">
                                        <label for="contractTextTB">
                                            Текст контракта
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="contractTextTB" ErrorMessage="Введите текст контракта" Text="*"></asp:RequiredFieldValidator>
                                        
                                        </label>
                                        <asp:TextBox class="form-control" ID="contractTextTB" runat="server" Text='<%# Bind("text") %>' TextMode="MultiLine" MaxLength="1000" />
                                    </div>
                                </div>
                           

                            </div>

                       
                         
                               <hr />
                            <asp:Button class="btn btn-default " ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Сохранить"/>
                            <asp:Button class="btn btn-default" ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Отмена" PostBackUrl="~/ActiveContracts.aspx" />
                              
                        </InsertItemTemplate>
                         </asp:FormView>

                      </div>
            </div>
        </div>
        <!-- #include file="content/footer.aspx" -->
    </form>

    <!-- #include file="content/bottomincludes.aspx" -->
</body>
</html>
