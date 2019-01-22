<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="TestWebForm.TravelForm" %>

<!DOCTYPE html5>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

  <title>Exercise Landing</title>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
  <link rel="stylesheet" href="../CSS/index.css" />
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>

</head>
<body>
   
    <form id="form1" runat="server">

    <div class="container">
        <div class="background-image"></div>
        <div class="loginForm">

            <div class="loginUser">
                <asp:Label ID="loginLabel1" runat="server" class="loginLabel" Text="Please enter your username: " ></asp:Label>
                <asp:TextBox ID="loginTextboxUser" runat="server"></asp:TextBox>
            </div>

            <div class="loginPass">
                <asp:Label ID="loginLabel2" runat="server"  class="loginLabel" Text="Please enter your password: "></asp:Label>
                <asp:TextBox ID="loginTextboxPass" runat="server" TextMode="Password" ></asp:TextBox> 
            </div>

            <div class="loginDivButtton">
                <asp:Button ID="loginButton1" runat="server"  OnClick="loginButton1_Click" Text="Log In" class="loginButton1"/>
                <asp:Label ID="ErrMsg_1" runat="server"></asp:Label>
                <asp:Button ID ="signUpButton1" runat="server" OnClick ="signUpButton1_Click" Text ="SignUp" Visible="False" class="loginButton2"/>
                <asp:Label ID ="testLabel" runat="server"></asp:Label>
            </div>

        </div>
    </div>
    </form>
</body>
</html>
