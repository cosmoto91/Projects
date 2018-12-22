using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestWebForm.Functions;

namespace TestWebForm
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void uploadButton1_Click(object sender,EventArgs e)
        {
            string destination;

            destination = Server.MapPath("~" + "\\Files\\");

            FileHandler file = new FileHandler();

            file.FileName = uploadFileUpload1.FileName;
            file.SaveFile(destination,uploadFileUpload1);
            uploadGridView1.DataSource = file.DisplayFile(destination + file.FileName);
            uploadGridView1.DataBind();
        }
    }
}