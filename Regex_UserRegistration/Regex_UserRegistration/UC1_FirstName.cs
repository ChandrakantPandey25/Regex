using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Regex_UserRegistration
{
    public class UC1_FirstName
    {
        public void FirstName()
        {
            Console.WriteLine("Enter the name");
            string firstName = Console.ReadLine();
            string pattern = "(^[^a-z][A-z]{1}[a-z]{1,}$)";
            if (Regex.IsMatch(firstName, pattern))
                Console.WriteLine("entered name is valid");
            else
            {
                Console.WriteLine("Entered name is Invalid... please give first character in capital and minimum 3 characters name");
                FirstName();
            }
        }
    }
}
