using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    public class Validation
    {
        public static Func<string, string, bool> validate = (fname, pattern) =>
            {
                Regex re = new Regex(pattern);
                if (re.IsMatch(fname))
                    return true;
                else
                    return false;
            };

    }
}