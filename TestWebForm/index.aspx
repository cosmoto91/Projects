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
        <p>
            &nbsp;</p>
        <p>
            What Question is being answered right now ?</p>
        <p>
            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="Questions" Text="Q1" />
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="Questions" Text="Q2" />
        </p>
        <p>
            What country are you from ?</p>
        <p>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem></asp:ListItem>
                <asp:ListItem>UK</asp:ListItem>
                <asp:ListItem>Ireland</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            Which car types do you prefer ?</p>
        <p>
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Supermini" />
            <asp:CheckBox ID="CheckBox2" runat="server" Text="Sedan" />
        </p>
        <p>
            Enter the length of time your dealer visit took.</p>
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" style="background-color:aqua;color:chocolate" BorderStyle="Dashed" Font-Names="Calibri" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" ></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <div style="width: 132px; margin-left: 520px">
            <asp:Label ID="Label3" runat="server" Text="LOGIN AREA"></asp:Label>
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
