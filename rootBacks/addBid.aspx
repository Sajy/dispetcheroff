<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addBid.aspx.cs" Inherits="addBid" %>

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
                    <h4>Добавление объявления на покупку c/х продукции</h4>
                </div>
                <div class="panel-body">
                    <asp:SqlDataSource ID="bidsDs" ConnectionString="Data Source=208.116.7.82\castor;Initial Catalog=dispetcheroff;Persist Security Info=True;User ID=win610476;Password=w~Sxe738" runat="server" ProviderName="System.Data.SqlClient"
                        SelectCommand="SELECT bids.value, bids.city, bids.price, bids.createDate, bids.minLot, bids.weighouse,  bids.sor,bids.belok,bids.vlazhnost,
                bids.height, bids.tel, products.name AS productName, region.name AS regionName, district.Name AS districtName, quality.name AS qualityName, quality.id as qualityId, 
                storePlace.name AS storeplaceName, autoType.name AS autoTypeName, bids.id AS code FROM bids INNER JOIN products ON bids.productId = products.id  
                INNER JOIN region ON bids.regionId = region.id INNER JOIN district ON bids.districtId = district.Id INNER JOIN quality ON bids.qualityId = quality.id  
                INNER JOIN storePlace ON bids.storePlaceId = storePlace.id INNER JOIN autoType ON bids.autoTypeId = autoType.id"
                        DeleteCommand="DELETE FROM [bids] WHERE [id] = @id"
                        InsertCommand="INSERT INTO [bids] ([productId], [value], [regionId], [districtId], [city], [qualityId], [storePlaceId], [price], [minLot], [weighouse], [height], [autoTypeId], [tel], [userIdUniq], [createDate],[sor],[belok],[vlazhnost]) VALUES ( @productId, @value, @regionId, @districtId, @city, @qualityId, @storePlaceId, @price, @minLot, @weighouse, @height, @autoTypeId, @tel, @userIdUniq, @createDate,@sor, @belok, @vlazhnost)" OnInserted="SqlDataSource1_Inserted">
                        <DeleteParameters>
                            <asp:Parameter Name="id" Type="Int32" />
                        </DeleteParameters>
                        <InsertParameters>
                            <asp:Parameter Name="userIdUniq" />
                            <asp:Parameter Name="createDate" Type="DateTime" />


                            <asp:Parameter Name="productId" />
                            <asp:Parameter Name="value" />
                            <asp:Parameter Name="regionId" />
                            <asp:Parameter Name="districtId" />
                            <asp:Parameter Name="city" />
                            <asp:Parameter Name="qualityId" />
                            <asp:Parameter Name="storePlaceId" />
                            <asp:Parameter Name="price" />
                            <asp:Parameter Name="minLot" />
                            <asp:Parameter Name="weighouse" />
                            <asp:Parameter Name="height" />
                            <asp:Parameter Name="autoTypeId" />
                            <asp:Parameter Name="tel" />
                              <asp:Parameter Name="sor" />
                                <asp:Parameter Name="belok" />
                                <asp:Parameter Name="vlazhnost" />
                        </InsertParameters>

                    </asp:SqlDataSource>


                    <asp:SqlDataSource ID="productsDS" runat="server" ConnectionString="Data Source=208.116.7.82\castor;Initial Catalog=dispetcheroff;Persist Security Info=True;User ID=win610476;Password=w~Sxe738" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [products]"></asp:SqlDataSource>
                    <asp:SqlDataSource ID="regionDS" runat="server" ConnectionString="Data Source=208.116.7.82\castor;Initial Catalog=dispetcheroff;Persist Security Info=True;User ID=win610476;Password=w~Sxe738" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [region] ORDER BY Name"></asp:SqlDataSource>
                    <asp:SqlDataSource ID="districtDS" runat="server" ConnectionString="Data Source=208.116.7.82\castor;Initial Catalog=dispetcheroff;Persist Security Info=True;User ID=win610476;Password=w~Sxe738" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [district]  WHERE     (RegionId = @Param1) ORDER BY Name ">
                        <SelectParameters>
                            <asp:Parameter Name="Param1" DefaultValue="8" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                    <asp:SqlDataSource ID="qualityDS" runat="server" ConnectionString="Data Source=208.116.7.82\castor;Initial Catalog=dispetcheroff;Persist Security Info=True;User ID=win610476;Password=w~Sxe738" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [quality]"></asp:SqlDataSource>
                    <asp:SqlDataSource ID="storePlaceDS" runat="server" ConnectionString="Data Source=208.116.7.82\castor;Initial Catalog=dispetcheroff;Persist Security Info=True;User ID=win610476;Password=w~Sxe738" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [storePlace]"></asp:SqlDataSource>
                    <asp:SqlDataSource ID="autoTypeDS" runat="server" ConnectionString="Data Source=208.116.7.82\castor;Initial Catalog=dispetcheroff;Persist Security Info=True;User ID=win610476;Password=w~Sxe738" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [autoType]"></asp:SqlDataSource>



                    <asp:FormView ID="FormView1" runat="server" DataKeyNames="id" DataSourceID="bidsDs" DefaultMode="Insert" Width="100%" OnItemInserting="FormView1_ItemInserting" OnItemInserted="FormView1_ItemInserted">

                        <InsertItemTemplate>

                            <div class="row">


                                <div class="col-md-4">
                                    <div class="panel panel-default">
                                        <div class="panel-heading">Общая информация</div>
                                        <div class="panel-body">
                                            <div class="form-group">
                                                <label for="DropDownList6">Продукт</label>
                                                <asp:DropDownList class="form-control" ID="DropDownList6" runat="server" DataSourceID="productsDS" DataTextField="name" DataValueField="id" SelectedValue='<%# Bind("productId") %>'></asp:DropDownList>
                                            </div>
                                            <div class="form-group">
                                                <label for="valueTextBox">Объем</label>
                                                <asp:TextBox class="form-control" ID="valueTextBox" runat="server" Text='<%# Bind("value") %>' MaxLength="6" />
                                            </div>

                                            <div class="form-group">
                                                <label for="priceTextBox">Цена</label>
                                                <asp:TextBox class="form-control" ID="priceTextBox" runat="server" Text='<%# Bind("price") %>' MaxLength="6" />
                                            </div>
                                            <div class="form-group">
                                                <label for="DropDownList3">Тип</label>

                                              
                                                <asp:DropDownList class="form-control" ID="DropDownList3" runat="server" DataSourceID="qualityDS" DataTextField="name" DataValueField="id" SelectedValue='<%# Bind("qualityId") %>'></asp:DropDownList>
                                                    
                                                
                                                
                                            </div>
                                              <div class="form-group">
                                                  <label for="TextBox4">Качество</label>
                                                     <div class="form-inline">
                                                         <asp:TextBox ID="TextBox4"  class="form-control" runat="server" Enabled="False" Font-Size="X-Small" Width="200px" Text="Нет данных. Редактировать?>>>"></asp:TextBox>
                                                          <asp:LinkButton data-toggle="modal" data-target="#qModal" 
                                                           ID="LinkButton1" runat="server" Font-Bold="True" ToolTip="Редактировать данные о качестве продукции"><span class="glyphicon glyphicon-edit"></span></asp:LinkButton>
                                                         </div>
                                                  </div>
                                                  

                                            <div class="form-group">
                                                <label for="minLotTextBox">Минимальный объем</label>
                                                <asp:TextBox class="form-control" ID="minLotTextBox" runat="server" Text='<%# Bind("minLot") %>' MaxLength="6" />
                                            </div>

                                            <div class="form-group">
                                                <label for="telTextBox">Телефон</label>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="telTextBox" ErrorMessage="Введите телефон" Text="*"></asp:RequiredFieldValidator>
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="telTextBox" ErrorMessage="Номер телефона должен содержать 10 цифр например 0653332211" ValidationExpression=".*0(39|50|63|66|67|68|91|92|93|94|95|96|97|98|99).*\d\d\d.*\d\d.*\d\d" ToolTip="нЕВЕРНЫЙ НОМЕР ТЕЛЕФОНА" Text="*"></asp:RegularExpressionValidator>
                                                </label>
                                                <asp:TextBox class="form-control" ID="telTextBox" runat="server" MaxLength="10" Text="06322222222" />
                                                <asp:MaskedEditExtender ID="MaskedEditExtender1" runat="server" TargetControlID="telTextBox" Mask="(999)999-99-99" ClearTextOnInvalid="False" PromptCharacter=" " ClearMaskOnLostFocus="False" AutoComplete="False"></asp:MaskedEditExtender>

                                            </div>
                                        </div>
                                    </div>

                                </div>




                                <div class="col-md-4">
                                    <div class="panel panel-default">
                                        <div class="panel-heading">Место выгрузки на условиях доставки</div>
                                        <div class="panel-body">

                                            <div class="form-group">
                                                <label for="DropDownList7">Область</label>
                                                <asp:DropDownList class="form-control" OnSelectedIndexChanged="DropDownList5_SelectedIndexChanged" ID="DropDownList7" runat="server" DataSourceID="regionDS" DataTextField="name" DataValueField="id" SelectedValue='<%# Bind("regionId") %>' AutoPostBack="True"></asp:DropDownList>
                                            </div>
                                            <div class="form-group">
                                                <label for="DropDownList5">Район</label>
                                                <asp:DropDownList class="form-control" ID="DropDownList5" runat="server" DataSourceID="districtDS" DataTextField="name" DataValueField="id"></asp:DropDownList>
                                            </div>
                                            <div class="form-group">
                                                <label for="cityTextBox">Город</label>
                                                <asp:TextBox class="form-control" ID="cityTextBox" runat="server" Text='<%# Bind("city") %>' MaxLength="30" />
                                            </div>

                                                   <div class="form-group">

                                        <label for="DropDownList2">Место выгрузки</label>
                                        <asp:DropDownList class="form-control" ID="DropDownList2" runat="server" DataSourceID="storePlaceDS" DataTextField="name" DataValueField="id" SelectedValue='<%# Bind("storeplaceId") %>'></asp:DropDownList>
                                    </div>
                                         



                                             <div class="form-group">
                                                <label for="condTextBox">Примечание (обязательные усовия)</label>
                                                 <asp:TextBox class="form-control"  ID="condTextBox" runat="server" TextMode="MultiLine"></asp:TextBox>
                                            </div>
                                        </div>
                                    </div>
                                </div>


                                <div class="col-md-4">
                                        <div class="panel panel-default">
                                        <div class="panel-heading">Особенности разгрузки транспорта</div>
                                        <div class="panel-body">


                                <div class="form-group">
                                                <label for="weighouseTextBox">Весовая</label>
                                                <asp:TextBox class="form-control" ID="weighouseTextBox" runat="server" Text='<%# Bind("weighouse") %>' MaxLength="10" />
                                            </div>
                                                                                        <div class="form-group">
                                                <label for="heightTextBox">Высота</label>
                                                <asp:TextBox class="form-control" ID="heightTextBox" runat="server" Text='<%# Bind("height") %>' MaxLength="6" />
                                            </div>
                                    <div class="form-group">
                                        <label for="DropDownList1">Тип авто</label>
                                        <asp:DropDownList class="form-control" ID="DropDownList1" runat="server" DataSourceID="autoTypeDS" DataTextField="name" DataValueField="id" SelectedValue='<%# Bind("autoTypeId") %>'>
                                        </asp:DropDownList>
                                    </div>


                                </div>
</div></div>
                            </div>




                            <br />



                            <asp:Button class="btn btn-info " ID="ButtonOk" runat="server" CausesValidation="True" CommandName="Insert" Text="Добавить объявление" />
                            <asp:Button class="btn btn-info" ID="Button2" runat="server" CausesValidation="False" CommandName="Cancel" Text="Отмена" PostBackUrl="~/Bids.aspx" />
                              

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
                        <asp:Button ID="Button1"  class="btn btn-primary" runat="server" Text="Применить" CausesValidation="False" OnClick="Button1_Click" />
                      
                          <button type="button" class="btn btn-default" data-dismiss="modal">Отмена</button>
                    </div>
                </div>
            </div>
        </div>




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