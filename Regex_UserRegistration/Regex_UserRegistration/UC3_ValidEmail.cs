using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Regex_UserRegistration
{
    class UC3_ValidEmail
    {
        public void ValidEmail()
        {
            Console.WriteLine("Enter email");
            string email = Console.ReadLine();
            string pattern = "^[a-zA-Z0-9]{3,25}([.][0-9a-zA-Z]{1,7})*@[a-zA-Z]+[.]+[a-zA-Z]{2,4}+([.][a-zA-Z]{2,3})*$";
            
            if (Regex.IsMatch(email, pattern))
            {
                Console.WriteLine("entered email is valid");               
                ValidEmail();
            }
            else
            {
                Console.WriteLine("entered email invalid");              
                ValidEmail();
            }
        }
    }
}
