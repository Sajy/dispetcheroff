<%@ Page Language="C#" AutoEventWireup="true" CodeFile="uptest.aspx.cs" Inherits="uptest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

      

    
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click1" />
        <asp:FileUpload ID="FileUpload1" runat="server" /><asp:Label ID="msg" runat="server" Text=""></asp:Label>
     </div></form>
</body>
</html>
