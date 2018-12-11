using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestWebForm
{
    public partial class TravelForm : System.Web.UI.Page
    {

        string Qst, returnedMsg,databaseResponse;
        bool isNumeric;
        

        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(sender + " eventargs: " + e);

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            DataAccess_MySQL dbconn = new DataAccess_MySQL();
            dbconn.Settype = "login";
            dbconn.setUserName = TextBox2.Text;
            dbconn.setPassword = TextBox3.Text;
            dbconn.connect();
        }
        

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (RadioButton1.Checked == true)
            {
                Qst = "Question1 was selected";
            }
            else
                Qst = "Question2 was selected";
            isNumeric = int.TryParse(TextBox1.Text, out int n);

            if (isNumeric == false)
            {
                returnedMsg = "Lenght of time must be in minutes only";
            }
            else
                returnedMsg = "You spent " + TextBox1.Text + " minutes at the dealer" + " and more than that, " + Qst;

            Label1.Text = returnedMsg;

            // Response.Redirect("WebForm1.aspx");
            DataAccess_MySQL dbConn = new DataAccess_MySQL();

            dbConn.Settype = "retrieve";
            dbConn.connect();

            databaseResponse = dbConn.SetqueryReturnedValue;

            Label2.Text = databaseResponse;

            //DataAccess_MySQL.connect(type);
        }
    }
}