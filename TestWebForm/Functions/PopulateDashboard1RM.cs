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
    public class PopulateDashboard1RM
    {
        public DataTable populate1RMDashboard()
        {
            //Constructing the data table
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[2]
            {   new DataColumn("ExerciseName",  typeof(string)),
                new DataColumn("RMValue",       typeof(float))
            }
            );
                       
            DataAccess_MySQL mySQL = new DataAccess_MySQL();
            mySQL.Settype = "1RMDashboard";
            mySQL.connect();

            dt = mySQL.Dt2;

            return dt;
        }  
    }
}