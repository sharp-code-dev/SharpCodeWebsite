using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SharpCodeWebsite.Models
{
    public class Registration
    {
        public int Id { get; set; }
        [Display(Name = "First Name*")]
        [Required(ErrorMessage = "The first name is required")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name*")]
        [Required(ErrorMessage = "The last name is required")]
        public string LastName { get; set; }
        [Display(Name = "Age*")]
        [Required(ErrorMessage = "Age is required")]
        [Age(ErrorMessage = "Invalid Age")]
        public int Age { get; set; }
        [Display(Name = "Birth Date*")]
        [Required(ErrorMessage = "Birth Date is required.")]
        [RegularExpression(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$", ErrorMessage = "Invalid date format.")]
        public string BirthDate { get; set; }
        [Display(Name = "Email Address*")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        
        [Display(Name = "Phone Number*")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Phone number is required")]
        public string MobilePhone { get; set; }
        [Display(Name = "State*")]
        [Required(ErrorMessage = "State is required")]
        public string State { get; set; }
        [Display(Name = "Country*")]
        [Required(ErrorMessage = "State is required")]
        public string Country { get; set; }
        [Display(Name = "Select Program*")]
        [Required(ErrorMessage = "Program is required")]
        public string Program { get; set; }


    }
}
