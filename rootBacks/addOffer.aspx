<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addOffer.aspx.cs" Inherits="Offers" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!-- #include file="content/topincludes.aspx" -->
<body>
    <!-- #include file="content/middleincludes.aspx" -->
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <!-- #include file="content/header.aspx" -->

        <div class="container" style="margin-top: 33px;">
            <div class="panel panel-info">
                <div class="panel-heading">
                    <h4>Добавление объявления на продажу</h4>
                </div>
                <div class="panel-body">




                    <p>
                        <asp:SqlDataSource ID="offerDS" runat="server" ConnectionString="Data Source=208.116.7.82\castor;Initial Catalog=dispetcheroff;Persist Security Info=True;User ID=win610476;Password=w~Sxe738" DeleteCommand="DELETE FROM [offers] WHERE [id] = @id"
                            InsertCommand="INSERT INTO [offers] ([offerNum], [productId], [value], [regionId], [districtId], [city], [qualityId], [storePlaceId], [price], [tel], [createDate], [userIdUniq], [sor],[belok],[vlazhnost]) VALUES (@offerNum, @productId, @value, @regionId, @districtId, @city, @qualityId, @storePlaceId, @price, @tel, @createDate, @userIdUniq, @sor, @belok, @vlazhnost)" ProviderName="System.Data.SqlClient"
                            SelectCommand="SELECT offers.userIdUniq, offers.id, offers.offerNum, offers.productId, offers.value, offers.regionId,  offers.districtId, offers.city, offers.qualityId, offers.storePlaceId, offers.price, offers.tel, offers.createDate, offers.sor,offers.belok,offers.vlazhnost,
                      products.name AS productName, region.name AS regionName, district.Name AS districtName, quality.name AS qualityName, storePlace.name AS storePlaceName 
FROM         offers  INNER JOIN
                      products ON offers.productId = products.id INNER JOIN
                      region ON offers.regionId = region.id INNER JOIN
                      district ON offers.districtId = district.Id INNER JOIN
                      quality ON offers.qualityId = quality.id INNER JOIN
                      storePlace ON offers.storePlaceId = storePlace.id"
                            OnInserted="offerDS_Inserted">
                 


                            <DeleteParameters>
                                <asp:Parameter Name="id" Type="Int32" />
                            </DeleteParameters>
                            <InsertParameters>
                                <asp:FormParameter Name="offerNum" Type="String" />
                                <asp:Parameter Name="productId" Type="Int32" />
                                <asp:Parameter Name="value" Type="Int32" />
                                <asp:Parameter Name="regionId" Type="Int32" />
                                <asp:Parameter Name="districtId" Type="Int32" />
                                <asp:Parameter Name="city" Type="String" />
                                <asp:Parameter Name="qualityId" Type="Int32" />
                                <asp:Parameter Name="storePlaceId" Type="Int32" />
                                <asp:Parameter Name="price" Type="Decimal" />
                                <asp:Parameter Name="tel" Type="String" DefaultValue="0000000000"/>
                                <asp:Parameter Name="createDate" Type="DateTime" />
                                <asp:Parameter Name="userIdUniq" />
                                <asp:Parameter Name="sor" />
                                <asp:Parameter Name="belok" />
                                <asp:Parameter Name="vlazhnost" />

                            </InsertParameters>
                         
                        </asp:SqlDataSource>
                        <asp:SqlDataSource ID="productsDS" runat="server" ConnectionString="Data Source=208.116.7.82\castor;Initial Catalog=dispetcheroff;Persist Security Info=True;User ID=win610476;Password=w~Sxe738" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [products]"></asp:SqlDataSource>
                        <asp:SqlDataSource ID="regionDS" runat="server" ConnectionString="Data Source=208.116.7.82\castor;Initial Catalog=dispetcheroff;Persist Security Info=True;User ID=win610476;Password=w~Sxe738" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [region] ORDER BY Name"></asp:SqlDataSource>
                        <asp:SqlDataSource ID="districtDS" runat="server" ConnectionString="Data Source=208.116.7.82\castor;Initial Catalog=dispetcheroff;Persist Security Info=True;User ID=win610476;Password=w~Sxe738" ProviderName="System.Data.SqlClient"
                            SelectCommand="SELECT     Id, Name, RegionId FROM         district WHERE     (RegionId = @Param1) ORDER BY Name">
                            <SelectParameters>
                                <asp:Parameter Name="Param1" DefaultValue="8" />
                            </SelectParameters>
                        </asp:SqlDataSource>
                        <asp:SqlDataSource ID="qualityDS" runat="server" ConnectionString="Data Source=208.116.7.82\castor;Initial Catalog=dispetcheroff;Persist Security Info=True;User ID=win610476;Password=w~Sxe738" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [quality]"></asp:SqlDataSource>
                        <asp:SqlDataSource ID="storePlaceDS" runat="server" ConnectionString="Data Source=208.116.7.82\castor;Initial Catalog=dispetcheroff;Persist Security Info=True;User ID=win610476;Password=w~Sxe738" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [storePlace]"></asp:SqlDataSource>
                    </p>
                    <asp:FormView ID="FormView1" runat="server" AllowPaging="True" OnItemInserting="FormView1_ItemInserting" DataKeyNames="id" DataSourceID="offerDS" DefaultMode="Insert" OnHorizontalAlign="Center" Width="100%">
             
                        <InsertItemTemplate>

                            <div class="row">
                                <div class="col-md-4">

                                    <div class="panel panel-default">
                                        <div class="panel-body">

                                            <div class="form-group">
                                                <label for="DropDownList5">Область</label>
                                                <asp:DropDownList class="form-control" ID="DropDownList5" runat="server" OnSelectedIndexChanged="DropDownList5_SelectedIndexChanged" DataSourceID="regionDS" DataTextField="name" DataValueField="id" SelectedValue='<%# Bind("regionId") %>' AutoPostBack="True" AppendDataBoundItems="False" CausesValidation="False">
                                                </asp:DropDownList>
                                            </div>
                                            <div class="form-group">
                                                <label for="DropDownList2">Район</label>
                                                <asp:DropDownList class="form-control" ID="DropDownList2" runat="server" DataSourceID="districtDS" DataTextField="Name" DataValueField="Id" EnableViewState="False">
                                                </asp:DropDownList>
                                            </div>
                                            <div class="form-group">
                                                <label for="cityTextBox">
                                                    Город
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="cityTextBox" ErrorMessage="Введите город" Text="*"></asp:RequiredFieldValidator>
                                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="cityTextBox" ErrorMessage="Не верно указано наименование населенного пункта" ValidationExpression="\D{3,30}" Text="*"></asp:RegularExpressionValidator>

                                                </label>
                                                <asp:TextBox class="form-control" ID="cityTextBox" runat="server" MaxLength="30" Text='<%# Bind("city") %>' />
                                            </div>
                                              <div class="form-group">
                                                <label for="DropDownList1">Место хранения</label>
                                                <asp:DropDownList class="form-control" ID="DropDownList1" runat="server" DataSourceID="storePlaceDS" DataTextField="name" DataValueField="id" SelectedValue='<%# Bind("storePlaceId") %>'>
                                                </asp:DropDownList>
                                            </div>
                                                   <div class="form-group">
                                                <label for="telTextBox">
                                                    Телефон
                                          <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="telTextBox" ErrorMessage="Введите телефон" Text="*"></asp:RequiredFieldValidator>
                                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="telTextBox" ErrorMessage="Номер телефона должен содержать 10 цифр например 0653332211" ValidationExpression=".*0(39|50|63|66|67|68|91|92|93|94|95|96|97|98|99).*\d\d\d.*\d\d.*\d\d" ToolTip="нЕВЕРНЫЙ НОМЕР ТЕЛЕФОНА" Text="*"></asp:RegularExpressionValidator>
                                                </label>
                                                <asp:TextBox class="form-control" ID="telTextBox" runat="server" MaxLength="10"  Text="06322222222" />
                                                <asp:MaskedEditExtender ID="MaskedEditExtender1" runat="server" TargetControlID="telTextBox" Mask="(999)999-99-99" ClearTextOnInvalid="False" PromptCharacter=" " ClearMaskOnLostFocus="False" AutoComplete="False"></asp:MaskedEditExtender>
                                              <%--  <asp:MaskedEditValidator ID="MaskedEditValidator1" runat="server" ControlToValidate="telTextBox" ValidationExpression="" ControlExtender="MaskedEditExtender1" InvalidValueMessage="Fuck"></asp:MaskedEditValidator>--%>

                                               <%-- ^\([2-9]\d{2}\)\d{3}-\d{4}$--%>
                                            
                                            </div>
                                        </div>

                                    </div>
                                </div>
                                <div class="col-md-4">

                                    <div class="panel panel-default">
                                        <div class="panel-body">

                                            <div class="form-group">
                                                <label for="DropDownList6">Товар</label>
                                                <asp:DropDownList class="form-control" ID="DropDownList6" runat="server" DataSourceID="productsDS" DataTextField="name" DataValueField="id" SelectedValue='<%# Bind("productId") %>'>
                                                </asp:DropDownList>
                                            </div>
                                            <div class="form-group">
                                                <label for="DropDownList3">Тип товара</label>
                                                     <asp:DropDownList class="form-control" ID="DropDownList3" runat="server" DataSourceID="qualityDS" DataTextField="name" DataValueField="id" SelectedValue='<%# Bind("qualityId") %>'>
                                                </asp:DropDownList>
                                                </div>
                                          
                                            <div class="form-group">
                                                <label for="valueTextBox">
                                                    Объем
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="valueTextBox" ErrorMessage="необходимо ввести объем" Text="*"></asp:RequiredFieldValidator>
                                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="valueTextBox" ErrorMessage="Неверно указан объем. Пример (2000)" ValidationExpression="\d{1,7}" Text="*"></asp:RegularExpressionValidator>
                                                </label>
                                                <asp:TextBox class="form-control" ID="valueTextBox" runat="server" MaxLength="7" Text='<%# Bind("value") %>' />
                                            </div>
                                            
                                            <div class="form-group">
                                                <label for="TextBox4">Качество</label>
                                                   <div class="form-inline">
                                           
                                                            
                                              
                                                <asp:TextBox ID="TextBox4"  class="form-control" runat="server" Enabled="False" Font-Size="X-Small" Width="200px" Text="Нет данных"></asp:TextBox>
                                                         <asp:LinkButton data-toggle="modal" data-target="#qModal"  ID="LinkButton1" runat="server" Font-Bold="True"><span class="glyphicon glyphicon-edit"></span></asp:LinkButton>
                                                       </div>
                                            </div>
                                            <div class="form-group">
                                                <label for="priceTextBox">
                                                    Цена
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="priceTextBox" ErrorMessage="Введите цену"></asp:RequiredFieldValidator>
                                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="priceTextBox" ErrorMessage="Не верно указана цена" ValidationExpression="\d{1,7}"></asp:RegularExpressionValidator>
                                                </label>
                                                <asp:TextBox class="form-control" ID="priceTextBox" runat="server" MaxLength="7" Text='<%# Bind("price") %>' />
                                            </div>
                                               
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-4">
                                    <div class="panel panel-default">
                                        <div class="panel-body text-center">
                                            <label for="priceTextBox">
                                                Дата создания (для администраторов) 
                                            </label>

                                            <asp:Calendar Style="margin-left: 50px;" ID="Calendar1" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" SelectionMode="DayWeekMonth" Width="200px" UseAccessibleHeader="True">
                                                <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                                                <NextPrevStyle VerticalAlign="Bottom" />
                                                <OtherMonthDayStyle ForeColor="Gray" />
                                                <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                                                <SelectorStyle BackColor="#CCCCCC" />
                                                <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                                                <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                                                <WeekendDayStyle BackColor="#FFFFCC" />
                                            </asp:Calendar>
                                            <br />
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <div class="row">
                                
                                
                            </div>
                            <hr />
                            <asp:Button class="btn btn-default " ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Сохранить" />
                            <asp:Button class="btn btn-default" ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Отмена" PostBackUrl="~/Offers.aspx" />


                                  <div class="modal" id="qModal" tabindex="-1" role="dialog" aria-labelledby="qModalLabel" aria-hidden="true">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal"><span aria-hidden="true">&times;</span><span class="sr-only">Закрыть</span></button>
                        <h4 class="modal-title" id="qModalLabel">Качество</h4>
                    </div>
                    <div class="modal-body">
                        <table  text-align: center" class="auto-style1">
                            <tr>


                                <th>Сор</th>
                                <th>Влажность</th>
                                <th>Белок</th>
                            </tr>
                            <tr>

                                <td>
                                    <asp:TextBox ID="TextBox1"  class="form-control" runat="server" Text='<%# Bind("sor") %>'  MaxLength="2"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox2" class="form-control" runat="server"  Text='<%# Bind("vlazhnost") %>'  MaxLength="2"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox3"  class="form-control" runat="server" Text='<%# Bind("belok") %>'   MaxLength="2"></asp:TextBox>
                                </td>
                            </tr>


                        </table>
                       
                     
                    </div>
                    <div class="modal-footer">
                        <asp:Button ID="Button1"  class="btn btn-primary" runat="server" Text="Применить" CausesValidation="False" OnClick="Button1_Click1" />
                      
                          <button type="button" class="btn btn-default" data-dismiss="modal">Отмена</button>
                    </div>
                </div>
            </div>
        </div>



                        </InsertItemTemplate>
                   
                        <PagerSettings PageButtonCount="30" />





                    </asp:FormView>
                </div>
            </div>
        </div>



  


        <!-- #include file="content/footer.aspx" -->
    </form>

    <!-- #include file="content/bottomincludes.aspx" -->
</body>
</html>
