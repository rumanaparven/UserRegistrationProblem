using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    class Validation
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
            Regex re = new Regex("^([a-z\\d]+)(\\.([a-z\\d_+-\\.]+))?@([a-z\\d-]+)\\.([a-z]{2})((\\.[a-z]{2})?)$");
            if (re.IsMatch(email))
                return true;
            else
                return false;
        }
    }
}
