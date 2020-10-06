using System;

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
        }
    }
}
