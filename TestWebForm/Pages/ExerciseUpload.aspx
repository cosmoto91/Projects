<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExerciseUpload.aspx.cs" Inherits="TestWebForm.WebForm1" %>

<!DOCTYPE html>

<html lang="en">
<head runat="server">
    
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css">
    <link rel="stylesheet" href="../CSS/exerciseUpload.css" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
    <script type="text/javascript">
        google.charts.load('current', {packages: ['corechart']});
        google.charts.setOnLoadCallback(drawChart);

        function drawChart() {
      // Define the chart to be drawn.
            var data = new google.visualization.DataTable();
            
      data.addColumn('string', 'Element');
      data.addColumn('number', 'Percentage');
      data.addRows([
        ['Nitrogen', 0.78],
        ['Oxygen', 0.21],
        ['Other', 0.01]
      ]);

            // Instantiate and draw the chart.
            var chart = new google.visualization.ColumnChart(document.getElementById('ProgressPercChart'));

//      var chart = new google.visualization.PieChart(document.getElementById('ProgressPercChart'));
      chart.draw(data, null);
    }


    </script>


    <title></title>
</head>
<body>
   <form id="form2" runat="server">
    
        
        <div class="sidenav">
          <a class="tablinks" href="#" onclick="openCity(event, 'London')" id="defaultOpen">Home</a>
          <a class="tablinks" href="#" onclick="openCity(event, 'Paris')">Add items</a>
          <a class="tablinks" href="#" onclick="openCity(event, 'Dashboard')">Dashboard</a>
        </div>

        <div class="main">

         <div id="UploadEmptyAlert" class="alert alert-success alert-danger fade show" runat="server">

          <button type="button" class="close" data-dismiss="alert">&times;</button>

          <strong> DOES NOT COMPUTE </strong> Use a proper file or it won't work

        </div>

            <div id="London" class="tabcontent">
                    <span style="font-size:30px;cursor:pointer" onclick="openNav()">&#9776; open</span>
            </div>


        <div id="Paris" class="tabcontent">
            <div class="row">
                <div class="col-sm-2">
                <asp:ImageButton ID="imageButton1" runat="server" ImageUrl="~//Files//circle_plus.png" Height="315px" OnClick="imageButton1_Click" Width="333px"/>
                </div>
            </div>
        </div>

        <div id="Tungsten" class="tabcontent">
            <div class="col-sm-4">
               <asp:Label ID="uploadLabel1" runat="server" Text="Use the below button to upload your files:"></asp:Label>
               <asp:FileUpload ID="uploadFileUpload1" runat="server" />
               <asp:Button ID="uploadButton1" runat="server" Text="Upload!" onClick="uploadButton1_Click"/>
            </div>
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
               <asp:TextBox ID="uploadTextBox3" runat="server"></asp:TextBox> 
               <asp:DropDownList ID="uploadDropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="uploadDropDownList1_SelectedIndexChanged"></asp:DropDownList>
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
          </div>
      
           <div id="Dashboard" class="tabcontent">
               <div class="row">
                   <div class="col-sm-12">
                <asp:GridView ID="DashboardGridView1" runat="server" class="table table-stripped table-dark table-bordered table-hover table-sm table-responsive-sm"></asp:GridView> 
                       </div>
               </div>


               <div class="row">
                   <div class="col-sm-8" style="background-color:lightgrey; border:groove;border-color:greenyellow">
                        <asp:Chart ID="Chart1" runat="server" Height="387px" OnLoad="Chart1_Load" Width="929px">
                            <Series>
                                <asp:Series ChartType="Line" Name="Series1" YValuesPerPoint="14" IsValueShownAsLabel="true">
                                </asp:Series>
                            </Series>
                            <ChartAreas>
                                <asp:ChartArea Name="ChartArea1">
                                </asp:ChartArea>
                            </ChartAreas>
                        </asp:Chart>    
                    </div>
                   <div class="col-sm-4" style="background-color:lightgrey; border:groove;border-color:greenyellow">
                       <asp:GridView    ID="DashboardGridView2" runat="server" 
                                        AutoGenerateColumns="false" 
                                        autogenerateselectbutton="True"
                                        selectedindex="1"
                                        EmptyDataText="No data available" 
                                        class="table table-stripped table-dark table-bordered table-hover table-sm table-responsive-sm" 
                                        OnSelectedIndexChanged="GridView2_SelectedIndexChanged"
                       >
                           <Columns>
                               <asp:BoundField DataField="Exercise" HeaderText ="Exercise Name" ReadOnly="true" />
                               <asp:BoundField DataField="RM_Increase_Flag" HeaderText="Increase" ReadOnly="true" />
                               <asp:ImageField DataImageUrlField="Star" HeaderText="Star" ReadOnly="false" ControlStyle-Width="100px" ControlStyle-Height="50px" ItemStyle-Width="20%" ShowHeader="false"></asp:ImageField>
                           </Columns>


                       </asp:GridView> 
                   </div>
               </div>
                <asp:Chart ID="Chart2" runat="server" Height="320px" OnLoad="Chart2_Load" Width="929px">
                   <Series>
                       <asp:Series ChartType="Column" Name="Series1" YValuesPerPoint="14" IsValueShownAsLabel="true">
                       </asp:Series>
                   </Series>
                   <ChartAreas>
                       <asp:ChartArea Name="ChartArea2">
                       </asp:ChartArea>
                   </ChartAreas>
                    
               </asp:Chart>  
               <div id="ProgressPercChart"></div>
           </div> 
    </div>


      <script>
        function openCity(evt, cityName) {
          var i, tabcontent, tablinks;
          tabcontent = document.getElementsByClassName("tabcontent");
          for (i = 0; i < tabcontent.length; i++) {
            tabcontent[i].style.display = "none";
          }
          tablinks = document.getElementsByClassName("tablinks");
          for (i = 0; i < tablinks.length; i++) {
            tablinks[i].className = tablinks[i].className.replace(" active", "");
          }
            document.getElementById(cityName).style.display = "block";
            document.getElementById(cityName).style.marginTop = "15px";
            evt.currentTarget.className += " active";

       
        }

        // Get the element with id="defaultOpen" and click on it
        document.getElementById("defaultOpen").click();
     </script>
  </form>
    <!-- jQuery library -->
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>

<!-- Popper JS -->
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js"></script>

<!-- Latest compiled JavaScript -->
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js"></script>
</body>
</html>
