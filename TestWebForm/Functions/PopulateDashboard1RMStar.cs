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
    public class PopulateDashboard1RMStar
    {
        public DataTable populate1RMDashboardStar()
        {

            DataAccess_MySQL mySQL = new DataAccess_MySQL();
            mySQL.Settype = "1RMDashboardStar";
            mySQL.connect();

            return mySQL.Dt2;
        }
    }
}