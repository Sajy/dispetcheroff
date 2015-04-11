<%@ Page Language="C#" AutoEventWireup="true" CodeFile="qualityXML.aspx.cs" Inherits="qualityXML" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        <br />
        <br />
        <table style="width: 100px; text-align: center" class="auto-style1">
            <tr>

              
                <th>Сор</th>
                <th>Влажность</th>
                <th>Белок</th>
            </tr>
            <tr>
                
                 <td>
                     <asp:TextBox ID="TextBox1" runat="server" Width="30px" AutoPostBack="True" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" Width="30px" AutoPostBack="True" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
                </td>
                  <td>
                      <asp:TextBox ID="TextBox3" runat="server" Width="30px" AutoPostBack="True" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
                </td>
            </tr>
           
         
        </table>
        Качество <br />
        <asp:TextBox ID="TextBox4" runat="server" Enabled="False" Font-Size="X-Small" Width="200px"></asp:TextBox>
        <br />
        <br />
        <asp:GridView ID="gridResults" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>
