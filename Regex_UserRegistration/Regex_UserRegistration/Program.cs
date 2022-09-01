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
            Console.WriteLine("Enter 4 to validate mobile number");
            Console.WriteLine("Enter 5 to validate PassWord");
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
                case 4:
                    UC4_PhoneNumber mobileNumber = new UC4_PhoneNumber();
                    mobileNumber.MobileNumber();
                    break;
                case 5:
                    UC5_PassWord password = new UC5_PassWord();
                    password.Password();
                    break;

            }
        }
    }
}
