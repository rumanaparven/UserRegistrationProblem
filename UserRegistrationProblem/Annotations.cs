using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UserRegistrationProblem
{
    public class Annotations
    {
        //[Required(ErrorMessage ="First Name is required")]
        [StringLength(20,MinimumLength =3,ErrorMessage ="Length should be minimum 3 characters and maximum 20 characters")]
        [DataType(DataType.Text)]
        [RegularExpression(("^[A-Z][a-z]{3,20}$"),ErrorMessage ="Invalid First Name")]
        public string firstName { get; set; }

        //[Required(ErrorMessage = "Last Name is required")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Length should be minimum 3 characters and maximum 20 characters")]
        [DataType(DataType.Text)]
        [RegularExpression(("^[A-Z][a-z]{3,20}$"), ErrorMessage = "Invalid Last Name")]
        public string lastName { get; set; }

        //[Required(ErrorMessage = "EmailID is required")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Length should be minimum 6 characters and maximum 50 characters")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(("^([a-z\\d]+)(\\.([a-z\\d_+-\\.]+))?@([a-z\\d-]+)\\.([a-z]{2,3})((\\.[a-z]{2})?)$"), ErrorMessage = "Invalid EmailId")]
        public string emailID { get; set; }

        //[Required(ErrorMessage = "Phone number is required")]
        [StringLength(20, MinimumLength = 10, ErrorMessage = "Number minimum 10 digits and maximum 20 digits")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(("^[+][0-9]{2}\\s[7-9]{1}[0-9]{9}$"), ErrorMessage = "Invalid Phone Number")]
        public string phoneNumber { get; set; }

       

        //[Required(ErrorMessage = "Password is required")]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "Length should be minimum 8 characters and maximum 20 characters")]
        [DataType(DataType.Password)]
        [RegularExpression((@"(^(?=.*[A-Z])(?=.*[0-9])(?=.*[@#+-\._])[A-Za-z0-9@#-+\._]{8,}$)"), ErrorMessage = "Invalid Password")]
        public string password { get; set; }
    }
}
