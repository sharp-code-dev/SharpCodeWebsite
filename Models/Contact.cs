using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SharpCodeWebsite.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "The full name is required")]
        public string FullName { get; set; }
        
        [Required(ErrorMessage = "You must provide a phone number")]
        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^[0]\d{10}$", ErrorMessage = "Not a valid phone number")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        [Display(Name = "Message")]
        [Required(ErrorMessage = "Please enter your message to us!")]
        public string Message { get; set; }


    }
}
