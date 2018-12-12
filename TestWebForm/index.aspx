<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="TestWebForm.TravelForm" %>

<!DOCTYPE html5>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 467px;
            width: 343px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            Internet<strong> Web Form</strong></p>
        <asp:Label ID="Label2" runat="server"></asp:Label>

        <div style="width: 132px; margin-left: 520px">
            <asp:Label ID="Label3" runat="server" Text="SignUp Area"></asp:Label>
        </div>
        <p style="height: 35px; width: 1082px; margin-left: 200px">
            <asp:Label ID="Label4" runat="server" Text="UserName:"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <style="float:left" />
        <div style="margin-left: 200px">
            <asp:Label ID="Label5" runat="server" Text="Password:"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
        </div>
        <div style="margin-left: 200px">
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="SignUp" />
        </div>
    </form>
    
         </body>
</html>
