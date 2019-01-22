using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestWebForm.Functions;
using System.Data;
using System.Web.UI.DataVisualization.Charting;


namespace TestWebForm
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string selectedExercise;
        protected void Page_Load(object sender, EventArgs e)
        {
            UploadEmptyAlert.Visible = false;
            //Default values

           // uploadTextBox1.Text = DateTime.Now.ToString().Substring(0,10);
          //  uploadTextBox2.Text = DateTime.Now.ToString().Substring(11,5);
            if (!Page.IsPostBack)
            {
                int j = 0;
                //populating drop down with Exercise types
                PopulateDropDown exerciseDD = new PopulateDropDown();
                exerciseDD.Type = "AllDistinctExercises";
                exerciseDD.populate();
           
                uploadDropDownList1.DataSource = exerciseDD.ReturnedList;
                uploadDropDownList1.DataBind();
            
                //populating dashboard

                PopulateDashboard1RM RMDash = new PopulateDashboard1RM();

                DashboardGridView1.DataSource = RMDash.populate1RMDashboard();
                DashboardGridView1.DataBind();

                //Populate 1RM star dashboard
                PopulateDashboard1RMStar RMDashStar = new PopulateDashboard1RMStar();

                DataTable dtStar = new DataTable();

                dtStar.Columns.Add("Exercise");
                dtStar.Columns.Add("RM_Increase_Flag");

                dtStar = RMDashStar.populate1RMDashboardStar();
                dtStar.Columns.Add("Star", typeof(System.String));
                
                //Change value of empty column to image hyperlink
                foreach(DataRow row in dtStar.Rows)
                {
                    if (row[1].ToString() == "1")
                    { 
                         row[2] = "~\\Files\\boom.png";                       
                    }
                }
               // Bind
                DashboardGridView2.DataSource = dtStar;
                DashboardGridView2.DataBind();
                //Make 2nd column invisible
                DashboardGridView2.Columns[1].Visible = false;
                j = DashboardGridView2.Rows.Count;
            }
        }
        protected void uploadCalendar1_SelectionChanged(object sender, EventArgs e)
        {
            uploadTextBox1.Text = uploadCalendar1.SelectedDate.ToString().Substring(0,10);
        }
        protected void uploadButton1_Click(object sender,EventArgs e)
        {
            if (uploadFileUpload1.HasFile == true)
            {
                string destination, dataCSV;

                destination = Server.MapPath("~" + "\\Files\\");

                FileHandler file = new FileHandler();

                file.FileName = uploadFileUpload1.FileName;
                file.SaveFile(destination, uploadFileUpload1);

                dataCSV = file.SaveExerciseFileToDatabase(destination + file.FileName);
                uploadLabel2.Text = dataCSV;
            }
            else
                UploadEmptyAlert.Visible = true;
        }

        protected void uploadButton2_Click(object sender, EventArgs e)
        {
            DataAccess_MySQL mySQL2 = new DataAccess_MySQL();
            mySQL2.Settype = "InsertExercise";

            mySQL2.SqlCommand = "INSERT INTO web.Exercise(Date,Time,Exercise,Reps,Weight) VALUES('" + uploadTextBox1.Text + "','" + uploadTextBox2.Text + "','" + uploadTextBox3.Text + "','" + uploadTextBox4.Text + "','" + uploadTextBox5.Text + "')";
            mySQL2.connect();

            //Repopulate the list with newly inserted item
            PopulateDropDown exerciseDD = new PopulateDropDown();
            exerciseDD.Type = "AllDistinctExercises";
            exerciseDD.populate();

            uploadDropDownList1.DataSource = exerciseDD.ReturnedList;
            uploadDropDownList1.DataBind();
        }

        protected void uploadDropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            uploadTextBox3.Text = uploadDropDownList1.SelectedItem.Text;
            selectedExercise = uploadTextBox3.Text;

        }

        protected void Chart1_Load(object sender, EventArgs e)
        {
            if (selectedExercise != null)
            {
                
                uploadTextBox3.Text = uploadDropDownList1.SelectedItem.Text;
                Populate1RmGraph RMDash = new Populate1RmGraph();

                // Chart1.ChartAreas[0].AxisY.IntervalAutoMode = IntervalAutoMode.FixedCount;

                Chart1.ChartAreas[0].AxisX.MaximumAutoSize = 100;
                Chart1.ChartAreas[0].AxisY.IsStartedFromZero = false;
                Chart1.ChartAreas[0].AxisX.Interval = 4;

                Chart1.DataSource = RMDash.populate1RmGraph(selectedExercise);

                Chart1.Series[0].XValueMember = "DateCreated";
                Chart1.Series[0].YValueMembers = "RM";
                Chart1.DataBind();
            }
        }
        protected void Chart2_Load(object sender, EventArgs e)
        {
            if (selectedExercise != null)
            {
                PopulateProgressChart ProgChartDash = new PopulateProgressChart();
                
                Chart2.ChartAreas[0].AxisX.MaximumAutoSize = 100;
                Chart2.ChartAreas[0].AxisY.IsStartedFromZero = false;
                Chart2.ChartAreas[0].AxisX.Interval = 2;
                
                Chart2.DataSource = ProgChartDash.populateProgChart(selectedExercise);

                Chart2.Series[0].XValueMember  = "DateCreated";
                Chart2.Series[0].YValueMembers = "RM";
                Chart2.DataBind();
            }
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = DashboardGridView2.SelectedRow;
            selectedExercise = row.Cells[1].Text;
            Chart1_Load(Chart1, null);
            Chart2_Load(Chart2, null);
            ClientScript.RegisterStartupScript(GetType(), "hwa", "openCity(event, 'Dashboard');", true);
        }

        protected void imageButton1_Click(object sender, ImageClickEventArgs e)
        {
            ClientScript.RegisterStartupScript(GetType(), "hwa", "openCity(event, 'Tungsten');", true);
        }
    }
}