using System;

namespace UserRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Validation v = new Validation();
            string fname, lname, emailid, num;
            while (true)
            {
                Console.WriteLine("Enter your First Name : ");
                 fname = Console.ReadLine();
                try
                {
                    if (!v.FirstNameValidation(fname))
                    {
                        throw new CustomException("Invalid first name");
                    }
                    break;
                }
                catch(CustomException ce)
                {
                    Console.WriteLine(ce.Message);
                }
               
            }

            while (true)
            {
                Console.WriteLine("Enter your Last Name : ");
                 lname = Console.ReadLine();
                try
                {
                    if (!v.LastNameValidation(lname))
                    {
                        throw new CustomException("Invalid last name");
                    }
                    break;
                }
                catch (CustomException ce)
                {
                    Console.WriteLine(ce.Message);
                }

            }

            while (true)
            {
                Console.WriteLine("Enter your emailId : ");
                 emailid = Console.ReadLine();
                try
                {
                    if (!v.EmailIDValidation(emailid))
                    {
                        throw new CustomException("Invalid emailId");
                    }
                    break;
                }
                catch (CustomException ce)
                {
                    Console.WriteLine(ce.Message);
                }
            }

            while (true)
            {
                Console.WriteLine("Enter your mobile number : ");
                 num = Console.ReadLine();
                try
                {
                    if (!v.MobileNumberValidation(num))
                    {
                        throw new CustomException("Invalid mobile number");
                    }
                    break;
                }

                catch (CustomException ce)
                {
                    Console.WriteLine(ce.Message);
                }
            }

            while (true)
            {
                Console.WriteLine("Enter a password : ");
                string pswrd = Console.ReadLine();
                try
                {
                    if (!v.PasswordValidation(pswrd))
                    {
                        throw new CustomException("Invalid password"); 
                    }
                    break;
                }
                catch (CustomException ce)
                {
                    Console.WriteLine(ce.Message);
                }
            }
            

            Console.WriteLine("Registration Successful.");
            Console.WriteLine("Name :" + fname + " " + lname);
            Console.WriteLine("Email ID : " + emailid);
            Console.WriteLine("Contact Number : " + num);
        }
    }
}
