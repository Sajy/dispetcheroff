<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addAutoOffer.aspx.cs" Inherits="addAutoOffer" %>

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
                    <h4>Регистрация нового получателя рассылок</h4>
                </div>
                <div class="panel-body">

                    <asp:SqlDataSource ID="autoOffersDs" runat="server" ConnectionString="Data Source=208.116.7.82\castor;Initial Catalog=dispetcheroff;Persist Security Info=True;User ID=win610476;Password=w~Sxe738" ProviderName="System.Data.SqlClient"
                        SelectCommand="SELECT autoOffers.id as code, autoOffers.userId, autoOffers.offerNum, autoOffers.autoMakeId, autoOffers.autoTypeId, autoOffers.tare, autoOffers.cargo, autoOffers.autoNumber, autoOffers.regionOfNumber, autoOffers.bortHeight, autoOffers.addCargoName, autoOffers.value, autoOffers.userIdUniq, autoOffers.createDate, autoOffers.tel, autoType.name AS autoTypeName, autoMake.name AS autoMakeName FROM autoOffers INNER JOIN autoMake ON autoOffers.autoMakeId = autoMake.id INNER JOIN autoType ON autoOffers.autoTypeId = autoType.id"
                        DeleteCommand="DELETE FROM [autoOffers] WHERE [id] = @id"
                        InsertCommand="INSERT INTO [autoOffers] ( [offerNum], [autoMakeId], [autoTypeId], [tare], [cargo], [autoNumber], [regionOfNumber], [bortHeight], [addCargoName], [value], [userIdUniq], [createDate], [tel]) VALUES ( @offerNum, @autoMakeId, @autoTypeId, @tare, @cargo, @autoNumber, @regionOfNumber, @bortHeight, @addCargoName, @value, @userIdUniq, @createDate, @tel)" OnInserted="autoOffersDs_Inserted">
                        <DeleteParameters>
                            <asp:Parameter Name="id" Type="Int32" />
                        </DeleteParameters>
                        <InsertParameters>

                            <asp:Parameter Name="offerNum" Type="Int32" />
                            <asp:Parameter Name="autoMakeId" Type="Int32" />
                            <asp:Parameter Name="autoTypeId" Type="Int32" />
                            <asp:Parameter Name="tare" Type="Decimal" />
                            <asp:Parameter Name="cargo" Type="String" />
                            <asp:Parameter Name="autoNumber" Type="String" />
                            <asp:Parameter Name="regionOfNumber" Type="String" />
                            <asp:Parameter Name="bortHeight" Type="String" />
                            <asp:Parameter Name="addCargoName" Type="String" />
                            <asp:Parameter Name="value" Type="Decimal" />
                            <asp:Parameter Name="userIdUniq" />
                            <asp:Parameter Name="createDate" Type="DateTime" />
                            <asp:Parameter Name="tel" Type="String" />
                        </InsertParameters>

                    </asp:SqlDataSource>
                    <asp:SqlDataSource ID="autoMakeDS" runat="server" ConnectionString="Data Source=208.116.7.82\castor;Initial Catalog=dispetcheroff;Persist Security Info=True;User ID=win610476;Password=w~Sxe738" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [autoMake]"></asp:SqlDataSource>
                    <asp:SqlDataSource ID="autoTypeDS" runat="server" ConnectionString="Data Source=208.116.7.82\castor;Initial Catalog=dispetcheroff;Persist Security Info=True;User ID=win610476;Password=w~Sxe738" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [autoType]"></asp:SqlDataSource>

                    <asp:FormView ID="FormView1" runat="server" DataKeyNames="code" DataSourceID="autoOffersDs" DefaultMode="Insert" Width="100%" OnItemInserting="FormView1_ItemInserting">

                        <InsertItemTemplate>

                            <div class="row">
                                <div class="col-md-3">
                                    <div class="form-group">
                                        <label for="DropDownList3">Марка авто</label>
                                        <asp:DropDownList class="form-control" ID="DropDownList3" runat="server" Text='<%# Bind("autoMakeId") %>' DataSourceID="autoMakeDS" DataTextField="name" DataValueField="id">
                                        </asp:DropDownList>
                                    </div>
                                    <div class="form-group">
                                        <label for="DropDownList4">Тип авто</label>
                                        <asp:DropDownList class="form-control" ID="DropDownList4" runat="server" Text='<%# Bind("autoTypeId") %>' DataSourceID="autoTypeDS" DataTextField="name" DataValueField="id">
                                        </asp:DropDownList>
                                    </div>
                                    <%--  <div class="form-group">
                                        <label for="DropDownList4">Тара</label>
                                        <asp:TextBox class="form-control" ID="tareTextBox" runat="server" Text='<%# Bind("tare") %>' MaxLength="10" />
                                    </div>--%>


                                      <div class="form-group">
                                        <label for="autoNumberTextBox">Номер авто</label>
                                        <asp:TextBox class="form-control" ID="autoNumberTextBox" runat="server" Text='<%# Bind("autoNumber") %>' MaxLength="10" />
                                    </div>
                                   
                                  <div class="form-group">
                                        <label for="telTextBox">Телефон</label>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="telTextBox" ErrorMessage="Введите телефон" Text="*"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="telTextBox" ErrorMessage="Номер телефона должен содержать 10 цифр например 0653332211" ValidationExpression=".*0(39|50|63|66|67|68|91|92|93|94|95|96|97|98|99).*\d\d\d.*\d\d.*\d\d" ToolTip="нЕВЕРНЫЙ НОМЕР ТЕЛЕФОНА" Text="*"></asp:RegularExpressionValidator>
                                        </label>
                                                <asp:TextBox class="form-control" ID="telTextBox" runat="server" MaxLength="10" Text="06322222222" />
                                        <asp:MaskedEditExtender ID="MaskedEditExtender1" runat="server" TargetControlID="telTextBox" Mask="(999)999-99-99" ClearTextOnInvalid="False" PromptCharacter=" " ClearMaskOnLostFocus="False" AutoComplete="False"></asp:MaskedEditExtender>
                                    </div>

                               <%--     <div class="form-group">
                                        <label for="yearsDropDownCheckBoxes">Дополнительный груз</label>
                                        <!--    <asp:TextBox class="form-control" ID="addCargoNameTextBox" runat="server" Text='<%# Bind("addCargoName") %>' MaxLength="10" />-->


                                        <div class="myDropdownCheckbox dropdown-checkbox-nbselected"></div>

                     

                                    </div>--%>
                                </div>

                                <div class="col-md-3">
                                <%--    <div class="form-group">
                                        <label for="cargoTextBox">Груз (в тоннах)</label>
                                       
                                        <asp:DropDownList class="form-control" ID="cargoTextBox" Text='<%# Bind("cargo") %>' runat="server">
                                            <asp:ListItem Text="25-30" Selected="True"></asp:ListItem>
                                            <asp:ListItem Text="30-35"></asp:ListItem>
                                            <asp:ListItem Text="35-40"></asp:ListItem>
                                            <asp:ListItem Text="45-50"></asp:ListItem>
                                            <asp:ListItem Text="50-55"></asp:ListItem>
                                            <asp:ListItem Text="55-60"></asp:ListItem>
                                            <asp:ListItem Text=">60"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>--%>
                                   <div class="form-group">
                                        <label for="TextBox1">Высота борта</label>
                                        <%--  <asp:TextBox class="form-control" ID="TextBox1" runat="server" MaxLength="6" />--%>
                                        <asp:DropDownList class="form-control" ID="TextBox1" runat="server" Text='<%# Bind("bortHeight") %>' AppendDataBoundItems="True" ToolTip="Высота борта вашего авто">
                                            <asp:ListItem Text="3" Selected="True"> </asp:ListItem>
                                            <asp:ListItem Text="3.1"> </asp:ListItem>
                                            <asp:ListItem Text="3.2"> </asp:ListItem>
                                            <asp:ListItem Text="3.3"> </asp:ListItem>
                                            <asp:ListItem Text="3.4"> </asp:ListItem>
                                            <asp:ListItem Text="3.5"> </asp:ListItem>
                                            <asp:ListItem Text="3.6"> </asp:ListItem>
                                            <asp:ListItem Text="3.7"> </asp:ListItem>
                                            <asp:ListItem Text="3.8"> </asp:ListItem>
                                            <asp:ListItem Text="3.9"> </asp:ListItem>
                                            <asp:ListItem Text="4"> </asp:ListItem>


                                        </asp:DropDownList>
                                    </div>
                                  <%--  <div class="form-group">
                                        <label for="regionOfNumberTextBox">Номер региона</label>
                                        <asp:TextBox class="form-control" ID="regionOfNumberTextBox" runat="server" Text='<%# Bind("regionOfNumber") %>' />
                                    </div>--%>
                                    <div class="form-group">
                                        <label for="valueTextBox">Весовая (допуск при макс. загрузке)</label>
                                        <%--<asp:TextBox class="form-control" ID="valueTextBox" runat="server" MaxLength="6" />--%>
                                        <asp:DropDownList class="form-control" ID="valueTextBox"  Text='<%# Bind("value") %>' runat="server">

                                             <asp:ListItem Text="30" Selected="True"></asp:ListItem>
                                            <asp:ListItem Text="60"></asp:ListItem>
                                            <asp:ListItem Text="80"></asp:ListItem>
                                            <asp:ListItem Text="без ограничений"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                  
                                      <div class="form-group">
                                        <label for="emailTB">E-mail</label>
                                        <asp:TextBox class="form-control" ID="emailTB" runat="server"  MaxLength="30" />
                                    </div>
                                   
                                </div>
                            </div>






                            <br />
                            <asp:Button class="btn btn-info " ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Зарегистрироваться"  />
                            <asp:Button class="btn btn-info" ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Отмена" PostBackUrl="~/Transport.aspx" />
                        </InsertItemTemplate>

                    </asp:FormView>

                </div>
            </div>
        </div>

        <!-- #include file="content/footer.aspx" -->
    </form>

    <!-- #include file="content/bottomincludes.aspx" -->

</body>

<script>
    var myData = [{ id: 1, label: "Семмечка" }, { id: 2, label: "Горчица" }, { id: 3, label: "Кукуруза" }];
    $(".myDropdownCheckbox").dropdownCheckbox({
        data: myData,
        title: "Выбрать дополнительный груз ",
        btnClass: "btn btn-default",
        showNbSelected: true
    });
</script>
</html>
