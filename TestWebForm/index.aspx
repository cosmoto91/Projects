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
         <div>
        <asp:Label ID="loginLabel1" runat="server" Text="Please enter your username: "></asp:Label>
        <asp:TextBox ID="loginTextboxUser" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="loginLabel2" runat="server" Text="Please enter your password: "></asp:Label>
        <asp:TextBox ID="loginTextboxPass" runat="server" TextMode="Password" ></asp:TextBox> 
        <br />
        <asp:Button ID="loginButton1" runat="server" OnClick="loginButton1_Click" Text="Log In"/>
        <br />
        <asp:Label ID="ErrMsg_1" runat="server"></asp:Label>
        </div>
        <br />
        <br />
        <asp:Button ID ="signUpButton1" runat="server" OnClick ="signUpButton1_Click" Text ="SignUp" Visible="False" />
        <br />
        <br />
        <asp:Label ID ="testLabel" runat="server"></asp:Label>

    </form>
   
         </body>
</html>
