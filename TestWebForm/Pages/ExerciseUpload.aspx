<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExerciseUpload.aspx.cs" Inherits="TestWebForm.WebForm1" %>

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
           <br />
           <br />
           <asp:Label ID="uploadLabel2" runat="server"></asp:Label>
           <br />
           <br />
           <asp:Label ID="uploadLabel3" runat="server" Text="Insert a new exercise"></asp:Label>
           <br />
           <asp:Calendar ID="uploadCalendar1" runat="server" OnSelectionChanged="uploadCalendar1_SelectionChanged" ></asp:Calendar>
           <br />
           <asp:Label ID="uploadLabel4" runat="server" Text="Choose a date, default is today"></asp:Label>
           <br />
           <asp:TextBox ID="uploadTextBox1" runat="server"></asp:TextBox>
           <br />
           <asp:Label ID="uploadLabel5" runat="server" Text="Choose a time, default is now"></asp:Label>
           <br />
           <asp:TextBox ID="uploadTextBox2" runat="server"></asp:TextBox>
           <br />
           <asp:Label ID="uploadLabel6" runat="server" Text="ExerciseName"></asp:Label>
           <br />
           <asp:TextBox ID="uploadTextBox3" runat="server"></asp:TextBox> <asp:DropDownList ID="uploadDropDownList1" runat="server"></asp:DropDownList>
           <br />
           <asp:Label ID="uploadLabel7" runat="server" Text="Reps"></asp:Label>
           <br />
           <asp:TextBox ID="uploadTextBox4" runat="server"></asp:TextBox>
           <br />
           <asp:Label ID="uploadLabel8" runat="server" Text="Weight"></asp:Label>
           <br />
           <asp:TextBox ID="uploadTextBox5" runat="server"></asp:TextBox>
           <br />
           <asp:Label ID="uploadLabel9" runat="server" Text="Comments"></asp:Label>
           <br />
           <asp:TextBox ID="uploadTextBox6" runat="server"></asp:TextBox>
           <br />
           <br />
           <asp:Button ID="uploadButton2" runat="server" Text="Submit new exercise" OnClick="uploadButton2_Click"/><asp:Label ID="uploadLabel10" runat="server" Text="Success" Visible="false"></asp:Label>           
           <br />
           <br />           
           <br />
           <br />
           <asp:Label ID="DashboardLabel1" runat="server" Text="DASHBOARD"></asp:Label>
           <br />
           <br />           
           <br />
           <br />
           <asp:GridView ID="DashboardGridView1" runat="server"></asp:GridView> 

       </div>

  </form>
</body>
</html>
