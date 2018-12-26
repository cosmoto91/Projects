using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace TestWebForm
{

    public class DataAccess_MySQL
    {
        private string queryReturnedValue,type,username,password,sqlCommand;
        private bool connSuccess,val;

        public string SqlCommand
        {
            get { return sqlCommand; }
            set { sqlCommand = value; }
        }

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
        public string setUserName
        {
            get { return username; }
            set { username = value; }
        }
        public string setPassword
        {
            get { return setPassword; }
            set { password = value; }
        }
        public bool setconnSuccess
        {
            get { return connSuccess; }
        }


        public void connect()
        {
            MySqlConnection conn = new MySqlConnection("Server=bosiman11a.ddns.net;Database=cuivienql;Port=3306;User Id=cosmoto;Password=eArendil16");
            // MySqlConnection conn = new MySqlConnection("Database=cuivienql;Host=DESKTOP-RCGG4OD;User Id=cosmoto;Password=eArendil16");
            //  MySqlConnection conn = new MySqlConnection("Database=SourceApp;Data Source=188.121.44.71:3306;User Id=cosmoto;Password=eArendil16");
            conn.Open();

            MySqlCommand mycmd = new MySqlCommand();
            mycmd.Connection = conn;
            mycmd.CommandType = System.Data.CommandType.Text; 

            if(type == "InsertExercise")
            {
                mycmd.CommandText = sqlCommand;
                mycmd.BeginExecuteNonQuery();
            }

            if (type == "login")
            {
                mycmd.CommandText = "SELECT COUNT(*) FROM web.authorization WHERE UserName ='" + username + "' AND Password ='" + password+"'";
                MySqlDataReader dataReadLogin;
                dataReadLogin = mycmd.ExecuteReader();
                dataReadLogin.Read();

                queryReturnedValue = dataReadLogin.GetString(0);
                
                if(Convert.ToInt32(queryReturnedValue) > 0)
                {
                    connSuccess = true;
                }

            }

            else if (type == "signUp")
            {
                mycmd.CommandText = "INSERT INTO web.authorization (UserName,Password,Role,CreatedDate)VALUES('" + username + "', '" + password + "', 'User', NOW())";
                mycmd.BeginExecuteNonQuery();
            }
            else if (type == "retrieve")
            {
                mycmd.CommandText = "SELECT username FROM web.authorization";

                MySqlDataReader dataRead;
                dataRead = mycmd.ExecuteReader();
                dataRead.Read();

                queryReturnedValue = dataRead.GetString(0);
            }
            //queryReturn
        }

    }
}