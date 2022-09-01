using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace Regex_UserRegistration
{
    class UC5_PassWord
    {
        public void Password()
        {
            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();
            string pattern = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[&%$#@^*!~]).{8,}$";

            if (Regex.IsMatch(password, pattern))
            {
                Console.WriteLine("Password valid");
                Password();
            }
            else
            {
                Console.WriteLine("Invalid Password");
                Password();
            }
        }
    }
}
