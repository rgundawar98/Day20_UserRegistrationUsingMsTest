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

        public bool Check_For_Mobile_Number(string MobileNumber)
        {
            string pattern = "^[0-9]{2,}[' '][0-9]{10}$";
            if(Regex.IsMatch(MobileNumber,pattern))
            {
                Console.WriteLine("{0} is valid", MobileNumber);
                return true;
            }
            else
            {
                Console.WriteLine("{0} is not valid", MobileNumber);
                return false;
            }
        }
        public bool Password_Contains_Eight_Character(string Password)
        {
            string Pattern = "^[A -Za-z0-9@,.#*$&]{8,}$";// "^[A-Za-z0-9$,@,#,&,*].{8,}$"; 
            if (Regex.IsMatch(Password,Pattern))
            {
                Console.WriteLine("{0} is valid",Password);
                return true;
            }
            else
            {
                Console.WriteLine("{0} is not valid", Password);
                return false;
            }
        }

        public bool Password_Contains_Atleast_One_UpperCase(string Password)
        {
            string pattern = "^[A-Za-z0-9]{1,}[A-Za-z0-9@,.#$*&]{7,}$";
            if(Regex.IsMatch(Password,pattern))
            {
                Console.WriteLine("{0} is valid", Password);
                return true;
            }
            else
            {
                Console.WriteLine("{0} is not valid", Password);
                return false;
            }
        }
    }
}
