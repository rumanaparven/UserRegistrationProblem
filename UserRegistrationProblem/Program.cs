﻿using System;

namespace UserRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Validation v = new Validation();
            Console.WriteLine("Enter your First Name : ");
            string fname = Console.ReadLine();
            while (!v.FirstNameValidation(fname))
            {
                Console.WriteLine("Enter a valid first name : ");
                fname = Console.ReadLine();
            }

            Console.WriteLine("Enter your Last Name : ");
            string lname = Console.ReadLine();
            while (!v.LastNameValidation(lname))
            {
                Console.WriteLine("Enter a valid last name : ");
                lname = Console.ReadLine();
            }

            Console.WriteLine("Enter your emailId : ");
            string emailid = Console.ReadLine();
            while (!v.EmailIDValidation(emailid))
            {
                Console.WriteLine("Enter a valid emailID : ");
                emailid = Console.ReadLine();
            }

            Console.WriteLine("Enter your mobile number : ");
            string num = Console.ReadLine();
            while (!v.MobileNumberValidation(num))
            {
                Console.WriteLine("Enter a valid mobile number : ");
                num = Console.ReadLine();
            }

            Console.WriteLine("Enter a password : ");
            string pswrd = Console.ReadLine();
            while (!v.PasswordValidation(pswrd))
            {
                Console.WriteLine("Enter a valid password : ");
                pswrd = Console.ReadLine();
            }

            Console.WriteLine("Registration Successful.");
            Console.WriteLine("Name :" + fname + " " + lname);
            Console.WriteLine("Email ID : " + emailid);
            Console.WriteLine("Contact Number : " + num);
        }
    }
}
