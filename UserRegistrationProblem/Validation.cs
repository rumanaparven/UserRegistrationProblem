using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    public class Validation
    {
        public Boolean FirstNameValidation(string fname)
        {
            Regex re = new Regex("^[A-Z][a-z]{2,}$");
            if (re.IsMatch(fname))
                return true;
            else
                return false;
        }

        public Boolean LastNameValidation(string lname)
        {
            Regex re = new Regex("^[A-Z][a-z]{2,}$");
            if (re.IsMatch(lname))
                return true;
            else
                return false;
        }

        public Boolean EmailIDValidation(string email)
        {
            Regex re = new Regex("^([a-z\\d]+)(\\.([a-z\\d_+-\\.]+))?@([a-z\\d-]+)\\.([a-z]{2,3})((\\.[a-z]{2})?)$");
            if (re.IsMatch(email))
                return true;
            else
                return false;
        }

        public Boolean MobileNumberValidation(string num)
        {
            Regex re = new Regex("^[+][0-9]{2}\\s[7-9]{1}[0-9]{9}$");
            if (re.IsMatch(num))
                return true;
            else
                return false;
        }

        public Boolean PasswordValidation(string pswrd)
        {
            Regex re = new Regex(@"(^(?=.*[A-Z])(?=.*[0-9])(?=.*[@#+-\._])[A-Za-z0-9@#-+\._]{8,}$)");
            if (re.IsMatch(pswrd))
                return true;
            else
                return false;
        }
        public string MoodAnalyser(string message)
        {
            if (message.Contains("HAPPY"))
                return "HAPPY";
            else
                return "SAD";
        }
    }
}
