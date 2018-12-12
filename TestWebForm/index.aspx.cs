using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Text;

namespace TestWebForm
{
    public partial class TravelForm : System.Web.UI.Page
    {

        string Qst, returnedMsg,databaseResponse,hash_ret;
        bool isNumeric;
        

        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(sender + " eventargs: " + e);

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
          /*  DataAccess_MySQL dbconn = new DataAccess_MySQL();
            dbconn.Settype = "login";
            dbconn.setUserName = TextBox2.Text;
            dbconn.setPassword = TextBox3.Text;
            dbconn.connect();
        */
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(TextBox3.Text));

                StringBuilder sbuilder = new StringBuilder();
                for(int i = 0; i < hash.Length; i++)
                {
                    sbuilder.Append(hash[i].ToString("x2"));
                }

                hash_ret = sbuilder.ToString();


            }

            Label2.Text = hash_ret;

            //byte[] bytes = sha256
        }
        

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}