using System;

namespace Regex_UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regex Program");
            Console.WriteLine("Enter 1 to validate firstname");
            Console.WriteLine("Enter 2 to validate lastname");
            switch(Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    UC1_FirstName firstname = new UC1_FirstName();
                    firstname.FirstName();
                    break;
                case 2:
                    UC2_LastName lastName = new UC2_LastName();
                    lastName.LastName();
                    break;


            }
        }
    }
}
