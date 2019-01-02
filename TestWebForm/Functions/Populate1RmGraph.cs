using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestWebForm.Functions;
using System.IO;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
namespace TestWebForm.Functions
{
    public class Populate1RmGraph
    {
        public DataTable populate1RmGraph()
        {

            DataAccess_MySQL mySQL = new DataAccess_MySQL();
            mySQL.Settype = "1RMGraph";
            mySQL.connect();

            return mySQL.Dt2;
        }
    }
}