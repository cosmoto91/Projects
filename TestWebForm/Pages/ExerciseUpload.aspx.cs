using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestWebForm.Functions;
using System.Data;

namespace TestWebForm
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Default values

            uploadTextBox1.Text = DateTime.Now.ToString().Substring(0,10);
            uploadTextBox2.Text = DateTime.Now.ToString().Substring(11,5);

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


            ///////////////////
            Populate1RmGraph RMDash2 = new Populate1RmGraph();

            GridView2.DataSource = RMDash2.populate1RmGraph();
            GridView2.DataBind();

            
        }
        protected void uploadCalendar1_SelectionChanged(object sender, EventArgs e)
        {
            uploadTextBox1.Text = uploadCalendar1.SelectedDate.ToString().Substring(0,10);
        }
        protected void uploadButton1_Click(object sender,EventArgs e)
        {
            string destination, dataCSV;

            destination = Server.MapPath("~" + "\\Files\\");

            FileHandler file = new FileHandler();

            file.FileName = uploadFileUpload1.FileName;
            file.SaveFile(destination,uploadFileUpload1);
            //uploadGridView1.DataSource = file.DisplayFile(destination + file.FileName);
            //uploadGridView1.DataBind();

            dataCSV = file.SaveExerciseFileToDatabase(destination + file.FileName);
            uploadLabel2.Text = dataCSV;
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
        }

        protected void Chart1_Load(object sender, EventArgs e)
        {
            string[] label = new string[] { "A", "B" };
            int[] value_chart = new int[] { 100, 120 };

            Populate1RmGraph RMDash = new Populate1RmGraph();

            Chart1.DataSource = RMDash.populate1RmGraph();

             Chart1.Series[0].XValueMember = "DateCreated";
             Chart1.Series[0].YValueMembers = "RM";
             Chart1.DataBind();
            //Chart1.Series[0].Points.DataBindXY(label, value_chart);
        }
    }
}