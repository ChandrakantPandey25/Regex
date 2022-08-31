using System;

namespace Regex_UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regex Program");
            Console.WriteLine("Enter 1 to validate firstname");
            switch(Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    UC1_FirstName firstname = new UC1_FirstName();
                    firstname.FirstName();
                    break;


            }
        }
    }
}
