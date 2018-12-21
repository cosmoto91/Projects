using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

namespace TestWebForm.Functions
{
    public class Aux
    {
        private static readonly string _ErrorIsEmpty = "Username or password fields can't be empty";
        private string _retHash;

        public string ErrorIsEmpty
        {
            get { return _ErrorIsEmpty; }
        }
        public string retHash
        {
            get { return _retHash; }
        }

        public bool IsEmpty(string input)
        {
            if (input == "")
                return true;
            else
                return false;
        }

        public string createHash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));

                StringBuilder sbuilder = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    sbuilder.Append(hash[i].ToString("x2"));
                }

                _retHash = sbuilder.ToString();
            }
            return _retHash;
        }
    }
}