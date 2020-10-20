using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UserRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName, emailID, phoneNumber,password;



            while (true)
            {
                Console.WriteLine("Enter your First Name : ");
                 firstName = Console.ReadLine();
                bool valid = Validation.validate(firstName, "^[A-Z][a-z]{2,}$");
                if (!valid)
                {
                    Console.WriteLine("Invalid Input");
                   
                }
                else
                {
                    break;
                }
               
            }

            while (true)
            {
                Console.WriteLine("Enter your Last Name : ");
                lastName = Console.ReadLine();
                bool valid = Validation.validate(lastName, "^[A-Z][a-z]{2,}$");
                if (!valid)
                {
                    Console.WriteLine("Invalid Input");
                    

                }
                else
                {
                    break;
                }

            }

            while (true)
            {
                Console.WriteLine("Enter your emailId : ");
                emailID = Console.ReadLine();
                bool valid = Validation.validate(emailID, "^([a-z\\d]+)(\\.([a-z\\d_+-\\.]+))?@([a-z\\d-]+)\\.([a-z]{2,3})((\\.[a-z]{2})?)$");
                if (!valid)
                {
                    Console.WriteLine("Invalid Input");
                   

                }
                else
                {
                    break;
                }
            }

            while (true)
            {
                Console.WriteLine("Enter your mobile number : ");
                phoneNumber = Console.ReadLine();
                bool valid = Validation.validate(phoneNumber, "^[+][0-9]{2}\\s[7-9]{1}[0-9]{9}$");
                if (!valid)
                {
                    Console.WriteLine("Invalid Input");
                    

                }
                else
                {
                    break;
                }
            }

            while (true)
            {
                Console.WriteLine("Enter a password : ");
                password = Console.ReadLine();
                bool valid = Validation.validate(password, @"(^(?=.*[A-Z])(?=.*[0-9])(?=.*[@#+-\._])[A-Za-z0-9@#-+\._]{8,}$)");
                if (!valid)
                {
                    Console.WriteLine("Invalid Input");
                   

                }
                else
                {
                    break;
                }
            }
            

            Console.WriteLine("Registration Successful.");
            Console.WriteLine("Name :" + firstName + " " + lastName);
            Console.WriteLine("Email ID : " + emailID);
            Console.WriteLine("Contact Number : " + phoneNumber);
        }
    }
}
