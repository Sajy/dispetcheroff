<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Pay.aspx.cs" Inherits="Pay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
         <link rel="stylesheet" href="css/bootstrap-dropdown-checkbox.css">
</head>
<body>
   
    <div>
       
                                        <div class="myDropdownCheckbox"></div>
    </div>
   
</body>
        <script src="//ajax.googleapis.com/ajax/libs/jquery/1.11.0/jquery.js"></script>
  
    <script src="js/vendor/bootstrap-dropdown-checkbox.js"></script>
                                 <script>
                                     var myData = [{ id: 1, label: "Test" }];
                                     $(".myDropdownCheckbox").dropdownCheckbox({
                                         data: myData,
                                         title: "Dropdown Checkbox"
                                     });

    </script>
</html>
