using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWebForm.Functions
{
    public class Aux
    {
        static readonly string ErrorIsEmpty = "Username or password fields can't be empty";

        public string setErrorIsEmpty
        {
            get { return ErrorIsEmpty; }
        }

        public bool IsEmpty(string input)
        {
            if (input == "")
                return true;
            else
                return false;
        }
    }
}