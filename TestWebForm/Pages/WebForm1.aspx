<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TestWebForm.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   <form id="form2" runat="server">
       <div>



           <asp:Label ID="uploadLabel1" runat="server" Text="Use the below button to upload your files:"></asp:Label>
           <br />
           <asp:FileUpload ID="uploadFileUpload1" runat="server" />
           <br />
           <asp:Button ID="uploadButton1" runat="server" Text="Upload!" onClick="uploadButton1_Click"/>
           <br />
           <br />
           <asp:GridView ID="uploadGridView1" runat="server"></asp:GridView>



       </div>

  </form>
</body>
</html>
