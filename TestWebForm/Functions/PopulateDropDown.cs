using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWebForm.Functions
{
    public class PopulateDropDown
    {
        private string type;
        private List<string> returnedList = new List<string>();
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public List<string> ReturnedList
        {
            get { return returnedList; }
            set { returnedList = value; }
        }
         

        public void populate()
        {
            if (type == "AllDistinctExercises")
            {
                DataAccess_MySQL mySQL = new DataAccess_MySQL();
                mySQL.Settype = "retrieveAllExerciseTitles";
                mySQL.connect();

                List<string> allExerciselist = new List<string>(mySQL.DistinctExercises)
                {
                };
                ReturnedList = allExerciselist;
            }
        }
    }
}