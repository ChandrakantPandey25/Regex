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
            Console.WriteLine("Enter 3 to validate email");
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
                case 3:
                    UC3_ValidEmail validEmail = new UC3_ValidEmail();
                    validEmail.ValidEmail();
                    break;


            }
        }
    }
}
