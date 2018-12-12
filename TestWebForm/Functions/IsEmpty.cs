using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWebForm.Functions
{
    public class Aux
    {
        //string value;

        public bool IsEmpty(string input)
        {
            if (input == "")
                return true;
            else
                return false;
        }
    }
}