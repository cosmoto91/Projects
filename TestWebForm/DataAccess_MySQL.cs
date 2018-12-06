using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWebForm
{
    using MySql.Data.MySqlClient;
    public class DataAccess_MySQL
    {
        private string queryReturnedValue,type;

        public string SetqueryReturnedValue
        {
            get { return queryReturnedValue; }
            set { queryReturnedValue = value; }
        }
        public string Settype
        {
            get { return type; }
            set { type = value; }
        }


        public void connect()
        {
            MySqlConnection conn = new MySqlConnection("Database=cuivienql;Data Source=AC-PC124;User Id=admin;Password=eArendil16");

            conn.Open();
            MySqlCommand mycmd = new MySqlCommand();

            mycmd.Connection = conn;
            mycmd.CommandType = System.Data.CommandType.Text;
            if (type == "login")
                mycmd.CommandText = "INSERT INTO web.Authentication (UserName,Password,Role,CreatedDate)VALUES('ljenkings', 'leeroy', 'User', NOW())";
            else if (type == "retrieve")
                mycmd.CommandText = "SELECT username FROM web.Authentication";

            MySqlDataReader dataRead;
            dataRead = mycmd.ExecuteReader();
            dataRead.Read();

            queryReturnedValue = dataRead.GetString(0);

            //queryReturn
        }

    }
}