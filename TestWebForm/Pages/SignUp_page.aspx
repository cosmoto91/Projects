<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp_page.aspx.cs" Inherits="TestWebForm.Pages.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label Id="Label_SignUp" Text="Choose your username:" runat="server"></asp:Label>
            <br />
            <asp:TextBox Id="TextBox_UserName_SignUp" runat="server"></asp:TextBox>
            <br />
            <asp:Label Id="Label1" Text="Choose your password:" runat="server"></asp:Label>
            <br />
            <asp:TextBox Id="TextBox_Password_SignUp" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Label ID="Label_Error_SignUp" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="Button_Submit_SignUp" runat="server" OnClick ="Button_Submit_SignUp_OnClick" Text="Create Account"/>
        </div>
    </form>
</body>
</html>
