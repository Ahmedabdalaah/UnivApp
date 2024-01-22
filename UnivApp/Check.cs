using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UnivApp
{
    internal class Check
    {
        public bool checkName (string name)
        {
            string expresion = "^[a-zA-Z]{4,}(?: [a-zA-Z]+){0,2}$";
            if (Regex.IsMatch(name, expresion))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool checkEmail (String email)
        {
            if ((email.Contains("@")))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
