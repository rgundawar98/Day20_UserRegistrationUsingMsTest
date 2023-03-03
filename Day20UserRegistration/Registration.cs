﻿using System;
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

        public bool Check_Last_Name(string Lastname)
        {
            string pattern = "^[A-Z]{1}[a-z]{2,}$";
            if(Regex.IsMatch(Lastname, pattern))
            {
                Console.WriteLine("{0} is valid", Lastname);
                return true;
            }
            else
            {
                Console.WriteLine("{0} is not valid", Lastname);
                return false;
            }
        }
        
        public bool Check_For_Email(string Email)
        {
            string pattern = "^[A-Za-z]{1,}?[.][A-Za-z]{1,}?[@][a-z]{1,}?[.][a-z]{1,}?[.][a-z]{1,}$"; 
            if(Regex.IsMatch(Email , pattern))
            {
                Console.WriteLine("{0} is valid",Email);
                return true;
            }
            else
            {
                Console.WriteLine("{0} is not valid", Email);
                return false;
            }
        }
    }
}
