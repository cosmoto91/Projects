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
    public class PopulateProgressChart
    {
        public DataTable populateProgChart(string exercise)
        {

            DataAccess_MySQL mySQL = new DataAccess_MySQL();
            mySQL.Settype = "ProgChart";
            mySQL.ExerciseType = exercise;
            mySQL.connect();

            return mySQL.Dt2;
        }
    }
}