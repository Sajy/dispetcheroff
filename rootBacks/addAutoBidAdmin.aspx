<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addAutoBidAdmin.aspx.cs" Inherits="addAutoBidAdmin" %>

<!DOCTYPE html>
<!DOCTYPE html>


<!-- #include file="content/topincludes.aspx" -->
<body>
    <!-- #include file="content/middleincludes.aspx" -->
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <!-- #include file="content/header.aspx" -->
        <asp:SqlDataSource ID="productsDS" runat="server" ConnectionString="Data Source=208.116.7.82\castor;Initial Catalog=dispetcheroff;Persist Security Info=True;User ID=win610476;Password=w~Sxe738" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [products]"></asp:SqlDataSource>
          <asp:SqlDataSource ID="autoTypeDS" runat="server" ConnectionString="Data Source=208.116.7.82\castor;Initial Catalog=dispetcheroff;Persist Security Info=True;User ID=win610476;Password=w~Sxe738" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [autoType]"></asp:SqlDataSource>


        <div class="container" style="margin-top: 33px;">
            <div class="panel panel-info">
                <div class="panel-heading">
                    <h4>Рассылка смс по клиентам</h4>
                </div>
                <div class="panel-body">
                    

                     <div class="row">
                        <div class="col-md-6">
                              <div class="form-group">
                                <label for="TextBox2">Текст смс</label>
                                  <asp:TextBox  class="form-control" ID="TextBox2" runat="server" MaxLength="70" TextMode="MultiLine"></asp:TextBox>
                                  <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Длина текста не больше 70 символов" ControlToValidate="TextBox2" ValidationExpression=".{1.70}"></asp:RegularExpressionValidator>
                                  </div>
                            </div></div>

                      <div class="col-md-6">


                          

                                  <div class="form-group">
                                        <label for="yearsDropDownCheckBoxes"> <asp:CheckBox ID="CheckBox1" runat="server" Text="Разсылать по областям" /></label>
                                        <!--    <asp:TextBox class="form-control" ID="addCargoNameTextBox" runat="server" Text='<%# Bind("addCargoName") %>' MaxLength="10" />-->


                                        <div class="myDropdownCheckbox dropdown-checkbox-nbselected"></div>

                     

                          </div>
                          </div>
                 


                </div>
            </div>




            <br />
            <asp:Button class="btn btn-info " ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Разослать" PostBackUrl="~/PrivateArea.aspx"/>
            <asp:Button class="btn btn-info" ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Отмена" PostBackUrl="~/PrivateArea.aspx" />
        </div>
    
        <!-- #include file="content/footer.aspx" -->
    </form>

    <!-- #include file="content/bottomincludes.aspx" -->

</body>

<script>
    var myData = [{ id: 1, label: "Николаевская" }, { id: 2, label: "Одесская" }, { id: 3, label: "Черкасская" }];
    $(".myDropdownCheckbox").dropdownCheckbox({
        data: myData,
        title: "Выбрать области для рассылки ",
        btnClass: "btn btn-default",
        showNbSelected: true
    });
</script>
</html>