using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

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
    }
}