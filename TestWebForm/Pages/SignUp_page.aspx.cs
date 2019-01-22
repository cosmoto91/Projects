using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestWebForm.Functions;

namespace TestWebForm.Pages
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button_Submit_SignUp_OnClick(object sender, EventArgs e)
        {

            Aux aux1 = new Aux();
            if (aux1.IsEmpty(TextBox_UserName_SignUp.Text.ToString()) == true || aux1.IsEmpty(TextBox_Password_SignUp.Text.ToString()) == true)
            {
                Label_Error_SignUp.Text = aux1.ErrorIsEmpty;
            }
            else
            {
                DataAccess_MySQL signUp = new DataAccess_MySQL();
                signUp.Settype = "signUp";
                signUp.setUserName = TextBox_UserName_SignUp.Text.ToString();
                signUp.setPassword = TextBox_Password_SignUp.Text.ToString();
                signUp.connect();
                Response.Redirect("~/index.aspx");
            }
        }
    }
}