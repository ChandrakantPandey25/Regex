using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Regex_UserRegistration
{
    class UC2_LastName
    {
        public void LastName()
        {
            Console.WriteLine("Enter Last Name");
           string lastName = Console.ReadLine();
            string pattern = "(^[^a-z][A-z]{1}[a-z]{1,}$)";
            if (Regex.IsMatch(lastName, pattern))
            {
                Console.WriteLine("Entered Name is valid");
            }
            else
            {
                Console.WriteLine("Entered name is Invalid... please give first character in capital and minimum 3 characters name");
                LastName();
            }

        }
    }
}
