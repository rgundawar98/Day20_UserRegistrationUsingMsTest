using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day20UserRegistration
{
    public class Registration
    {
        public bool Check_First_Name(string name)
        {
            string pattern = "^[A-Z]{1}[a-z]{2,}$";
            if(Regex.IsMatch(name , pattern))
            {
                Console.WriteLine("{0} is valid",name);
                return true;
            }
            else
            {
                Console.WriteLine("{0} is not valid", name);
                return false;
            }
        }
    }
}
