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
            StreamReader reader = new StreamReader(source);
            DataAccess_MySQL mySQL = new DataAccess_MySQL();
            mySQL.Settype = "InsertExercise";
     

            string lineCurr = "";
            string[] item   = new string[] {"one"};
            string result   = "";
            int i           = 0;

          //  List<string> listA = new List<string>();
            //List<string> listb = new List<string>();

            while (!reader.EndOfStream)
            {
                if (i == 115)
                {
                    break;
                }
                lineCurr = reader.ReadLine();
                item = lineCurr.Split(',');
                /*
                var line = reader.ReadLine();
                var item = line.Split(',');
                listA.Add(item[0]);
                listb.Add(item[1]);
                */


                mySQL.SqlCommand = "INSERT INTO web.Exercise(Date,Time,Exercise,Reps,Weight) VALUES('" + item[0] + "','" + item[1] + "','" + item[2] + "','" + item[3] + "','" + item[4] + "')";
                mySQL.connect();

                i++;


            }

            return result;
            /*

            DataAccess_MySQL savetoDB = new DataAccess_MySQL();


            savetoDB.SqlCommand = "INSERT INTO web.Exercise VALUES ()";
            savetoDB.Settype = "InsertExericse";
            savetoDB.connect();
            */




        }
    }
}