using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Regex_UserRegistration
{
    class UC4_PhoneNumber
    {
        public void MobileNumber()
        {
            Console.WriteLine("Enter Mobile Number");
            string mobileNumber = Console.ReadLine();
            string pattern = "^91[ ][0-9]{10}$";
            if (Regex.IsMatch(mobileNumber, pattern))
                Console.WriteLine("Mobile Number is Valid");
            else
            {
                Console.WriteLine("Not Valid Mobile Number");
                MobileNumber();
            }
        }
    }
}
