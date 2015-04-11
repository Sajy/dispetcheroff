<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addAutoBid.aspx.cs" Inherits="addAutoBid" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<!DOCTYPE html>


<!-- #include file="content/topincludes.aspx" -->
<body>
    <!-- #include file="content/middleincludes.aspx" -->
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <!-- #include file="content/header.aspx" -->
        <asp:SqlDataSource ID="productsDS" runat="server" ConnectionString="Data Source=208.116.7.82\castor;Initial Catalog=dispetcheroff;Persist Security Info=True;User ID=win610476;Password=w~Sxe738" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [products]"></asp:SqlDataSource>
          <asp:SqlDataSource ID="autoTypeDS" runat="server" ConnectionString="Data Source=208.116.7.82\castor;Initial Catalog=dispetcheroff;Persist Security Info=True;User ID=win610476;Password=w~Sxe738" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [autoType]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=208.116.7.82\castor;Initial Catalog=dispetcheroff;Persist Security Info=True;User ID=win610476;Password=w~Sxe738" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [region]"></asp:SqlDataSource>

        <div class="container" style="margin-top: 33px;">
            <div class="panel panel-info">
                <div class="panel-heading">
                    <h4>Заказать транспорт на перевозку с/х продукции</h4>
                </div>
                <div class="panel-body">
                    <div class="row">
                        <div class="col-md-3">
                            <div class="form-group">
                                <label for="DropDownList3">Продукт</label>
                                <asp:DropDownList class="form-control" ID="DropDownList3" runat="server" DataSourceID="productsDS" DataTextField="name" DataValueField="id">
                                </asp:DropDownList>
                            </div>
                            <div class="form-group">
                                <label for="DropDownList4">Тип авто</label>
                                <asp:DropDownList class="form-control" ID="DropDownList4" runat="server"  DataSourceID="autoTypeDS" DataTextField="name" DataValueField="id">
                                </asp:DropDownList>
                            </div>
                            <%--  <div class="form-group">
                                        <label for="DropDownList4">Тара</label>
                                        <asp:TextBox class="form-control" ID="tareTextBox" runat="server" Text='<%# Bind("tare") %>' MaxLength="10" />
                                    </div>--%>
                            <div class="form-group">
                                <label for="TextBox1">Высота борта</label>
                                <%--  <asp:TextBox class="form-control" ID="TextBox1" runat="server" MaxLength="6" />--%>
                                <asp:DropDownList class="form-control" ID="TextBox1" runat="server" AppendDataBoundItems="True" ToolTip="Высота борта вашего авто">
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

                             <div class="form-group">
                                <label for="valueTextBox">Весовая</label>
                                <%--<asp:TextBox class="form-control" ID="valueTextBox" runat="server" MaxLength="6" />--%>
                                <asp:DropDownList class="form-control" ID="valueTextBox" Text='<%# Bind("value") %>' runat="server">

                                    <asp:ListItem Text="30" Selected="True"></asp:ListItem>
                                    <asp:ListItem Text="60"></asp:ListItem>
                                    <asp:ListItem Text="80"></asp:ListItem>
                                     <asp:ListItem Text="без ограничений"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                         

                            <%--     <div class="form-group">
                                        <label for="yearsDropDownCheckBoxes">Дополнительный груз</label>
                                        <!--    <asp:TextBox class="form-control" ID="addCargoNameTextBox" runat="server" Text='<%# Bind("addCargoName") %>' MaxLength="10" />-->


                                        <div class="myDropdownCheckbox dropdown-checkbox-nbselected"></div>

                     

                                    </div>--%>
                        </div>

                        <div class="col-md-3">
                            <div class="form-group">
                                <label for="cargoTextBox">Груз (объем для перевозки)</label>
                                <%-- <asp:TextBox class="form-control" ID="cargoTextBox" runat="server" Text='<%# Bind("cargo") %>' MaxLength="10" />--%>
                                <asp:DropDownList class="form-control" ID="cargoTextBox" Text='<%# Bind("cargo") %>' runat="server">
                                    <asp:ListItem Text="25-30" Selected="True"></asp:ListItem>
                                    <asp:ListItem Text="40"></asp:ListItem>
                                    <asp:ListItem Text="50"></asp:ListItem>
                                    <asp:ListItem Text="80"></asp:ListItem>
                                    <asp:ListItem Text="100"></asp:ListItem>
                                    <asp:ListItem Text="120"></asp:ListItem>
                                    <asp:ListItem Text="150"></asp:ListItem>
                                      <asp:ListItem Text="170"></asp:ListItem>
                                      <asp:ListItem Text="200"></asp:ListItem>
                                      <asp:ListItem Text="250"></asp:ListItem>
                                      <asp:ListItem Text="300"></asp:ListItem>
                                    <asp:ListItem Text="400"></asp:ListItem>
                                    <asp:ListItem Text="500"></asp:ListItem>
                                    <asp:ListItem Text="1000"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="form-group">
                                <label for="departure">Откуда (область)</label>
                                <asp:DropDownList class="form-control" ID="departure" runat="server" DataSourceID="SqlDataSource1" DataTextField="name" DataValueField="id"></asp:DropDownList>
                                
                            </div>
                              <div class="form-group">
                                <label for="destination">Куда (область)</label>
                        
                                 <asp:DropDownList class="form-control" ID="destination" runat="server" DataSourceID="SqlDataSource1" DataTextField="name" DataValueField="id"></asp:DropDownList>
                            </div>
                            <%--  <div class="form-group">
                                        <label for="regionOfNumberTextBox">Номер региона</label>
                                        <asp:TextBox class="form-control" ID="regionOfNumberTextBox" runat="server" Text='<%# Bind("regionOfNumber") %>' />
                                    </div>--%>
                              <div class="form-group">
                                <label for="telTextBox">Телефон</label>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="telTextBox" ErrorMessage="Введите телефон" Text="*"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="telTextBox" ErrorMessage="Номер телефона должен содержать 10 цифр например 0653332211" ValidationExpression=".*0(39|50|63|66|67|68|91|92|93|94|95|96|97|98|99).*\d\d\d.*\d\d.*\d\d" ToolTip="нЕВЕРНЫЙ НОМЕР ТЕЛЕФОНА" Text="*"></asp:RegularExpressionValidator>
                             
                                                <asp:TextBox class="form-control" ID="telTextBox" runat="server" MaxLength="10" Text="06322222222" />
                                <asp:MaskedEditExtender ID="MaskedEditExtender1" runat="server" TargetControlID="telTextBox" Mask="(999)999-99-99" ClearTextOnInvalid="False" PromptCharacter=" " ClearMaskOnLostFocus="False" AutoComplete="False"></asp:MaskedEditExtender>
                            </div>

                        </div>
                        
                        <div class="col-md-3">
                            <div class="form-group">
                                <br /><br /><br />
                                </div>
                             <div class="form-group">
                                <label for="departureCity">Откуда (город)</label>
                                <asp:TextBox class="form-control" ID="departureCity" runat="server"  MaxLength="30" />
                            </div>
                              <div class="form-group">
                                <label for="destinationCity">Куда (город)</label>
                                <asp:TextBox class="form-control" ID="destinationCity" runat="server"  MaxLength="30" />
                            </div>


                        </div>
                    </div>

                     <div class="row">
                        <div class="col-md-6">
                              <div class="form-group">
                                <label for="TextBox2">Текст смс</label>


                                  <form name="myform">
                                      <textarea  class="form-control" name="limitedtextarea" onkeydown="limitText(this.form.limitedtextarea,this.form.countdown,70);"
                                          onkeyup="limitText(this.form.limitedtextarea,this.form.countdown,70);">
</textarea><br>
                                      <font size="1">(Максимум символов: 70)<br>
Осталось <input readonly type="text" name="countdown" size="3" value="70"> символов.</font>
                                  </form>


                             
                                  </div>
                            </div></div>

                 


                </div>
            </div>




            <br />
            <asp:Button class="btn btn-info " ID="InsertButton" runat="server" CausesValidation="True"  Text="Заказать" OnClientClick=" if (confirm('После применения услуги, с вашего счета будет снято 25 грн?')) {alert('Спасибо, услуга оплачена.');window.location.href = 'Transport.aspx'}" />
            <asp:Button class="btn btn-info" ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Отмена" PostBackUrl="~/Transport.aspx" />
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