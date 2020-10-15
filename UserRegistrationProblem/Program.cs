using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UserRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            bool valid;
            Annotations anotation = new Annotations();
            ValidationContext context = new ValidationContext(anotation, null, null);
            List<ValidationResult> result = new List<ValidationResult>();
            while (true)
            {
                Console.WriteLine("Enter your First Name : ");
                anotation.firstName = Console.ReadLine();
                valid = Validator.TryValidateObject(anotation, context, result, true);
                if (!valid)
                {
                    foreach (ValidationResult results in result)
                    {

                        Console.WriteLine("{0}", results.ErrorMessage);
                    }
                    
                }
                else
                {
                    break;
                }
               
            }

            while (true)
            {
                Console.WriteLine("Enter your Last Name : ");
                anotation.lastName = Console.ReadLine();
                valid = Validator.TryValidateObject(anotation, context, result, true);
                if (!valid)
                {
                    foreach (ValidationResult results in result)
                    {
                        Console.WriteLine("{0}", results.ErrorMessage);
                    }

                }
                else
                {
                    break;
                }

            }

            while (true)
            {
                Console.WriteLine("Enter your emailId : ");
                anotation.emailID = Console.ReadLine();
                valid = Validator.TryValidateObject(anotation, context, result, true);
                if (!valid)
                {
                    foreach (ValidationResult results in result)
                    {
                        Console.WriteLine("{0}", results.ErrorMessage);
                    }

                }
                else
                {
                    break;
                }
            }

            while (true)
            {
                Console.WriteLine("Enter your mobile number : ");
                anotation.phoneNumber = Console.ReadLine();
                valid = Validator.TryValidateObject(anotation, context, result, true);
                if (!valid)
                {
                    foreach (ValidationResult results in result)
                    {
                        Console.WriteLine("{0}", results.ErrorMessage);
                    }

                }
                else
                {
                    break;
                }
            }

            while (true)
            {
                Console.WriteLine("Enter a password : ");
                anotation.password = Console.ReadLine();
                valid = Validator.TryValidateObject(anotation, context, result, true);
                if (!valid)
                {
                    foreach (ValidationResult results in result)
                    {
                        Console.WriteLine("{0}", results.ErrorMessage);
                    }

                }
                else
                {
                    break;
                }
            }
            

            Console.WriteLine("Registration Successful.");
            Console.WriteLine("Name :" + anotation.firstName + " " + anotation.lastName);
            Console.WriteLine("Email ID : " + anotation.emailID);
            Console.WriteLine("Contact Number : " + anotation.phoneNumber);
        }
    }
}
