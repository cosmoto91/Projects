using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestWebForm.Functions;

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

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void loginButton1_Click(object sender,EventArgs e)
        {
            DataAccess_MySQL dbconn0 = new DataAccess_MySQL();
            Aux aux1 = new Aux();
            if (aux1.IsEmpty(loginTextboxUser.Text.ToString()) == true || aux1.IsEmpty(loginTextboxPass.Text.ToString()) == true)
            {
                ErrMsg_1.Text = "Neither one of the username and the password fields can't be empty";
            }
            else
            {
                dbconn0.setUserName = loginTextboxUser.Text;
                dbconn0.setPassword = loginTextboxPass.Text;
                dbconn0.Settype = "login";
                dbconn0.connect();

                if (dbconn0.setconnSuccess == true)
                    Response.Redirect("WebForm1.aspx");
                else
                    ErrMsg_1.Text = "Invalid credentials";
            }

        }
    }
}