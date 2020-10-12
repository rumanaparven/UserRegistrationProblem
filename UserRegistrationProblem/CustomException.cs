using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Text;

namespace UserRegistrationProblem
{
    class CustomException: ApplicationException
    {
        public CustomException(string message) : base(message)
        {

        }
    }
}
