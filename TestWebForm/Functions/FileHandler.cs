using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace TestWebForm.Functions
{
    public class FileHandler
    {
        private string fileName;

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }
        
        public void SaveFile(string destination,System.Web.UI.WebControls.FileUpload file)
        {
            if (file.HasFile)
            {
                file.SaveAs(destination + file.FileName);
                file.Dispose();
            }
        }

        public DataTable DisplayFile(string source)
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[6]
            {   new DataColumn("Date",typeof(string)),
                new DataColumn("Time",typeof(string)),
                new DataColumn("Exercise",typeof(string)),
                new DataColumn("# of Reps",typeof(string)),               
                new DataColumn("Weight",typeof(string)),
                new DataColumn("Comments",typeof(string)),
            }
            );
            string csvData = File.ReadAllText(source);
            foreach (string row in csvData.Split('\n'))
            {
                if (string.IsNullOrEmpty(row) ==false)
                {
                    dt.Rows.Add();
                    int i = 0;

                    foreach(string cell in row.Split(','))
                    {
                        dt.Rows[dt.Rows.Count - 1][i] = cell;
                        i++;
                    }
                }
            }
            return dt;
        } 
        public string SaveExerciseFileToDatabase(string source)
        {
            MySqlConnection conn = new MySqlConnection("Server=82.43.85.43;Database=web;Port=3306;User Id=cosmoto;Password=eArendil16; Connect Timeout=300");
            MySqlCommand mycmd = new MySqlCommand();

            StreamReader reader = new StreamReader(source);
            DataAccess_MySQL mySQL = new DataAccess_MySQL();
            mySQL.Settype = "InsertExercise";


     

            string lineCurr = "";
            string[] item   = new string[] {"one"};
            string result   = "";
            int i           = 0;



            while (!reader.EndOfStream)
            {               
                lineCurr = reader.ReadLine();
                item = lineCurr.Split(',');
          
                if (i > 0)
                {
                    mySQL.SqlCommand = "INSERT INTO web.Exercise(Date,Time,Exercise,Reps,Weight) VALUES('" + item[0] + "','" + item[1] + "','" + item[2] + "','" + item[3] + "','" + item[4] + "')";
                    mySQL.connect();
                }        
                i++;
            }
            reader.Dispose();
            return i.ToString();
        }
    }
}