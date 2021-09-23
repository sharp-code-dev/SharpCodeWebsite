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
        public int ProgramsId { get; set; }
        [Display(Name = "First Name*")]
        [Required(ErrorMessage = "The first name is required")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name*")]
        [Required(ErrorMessage = "The last name is required")]
        public string LastName { get; set; }
        
        [Display(Name = "Email Address*")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        
        [Display(Name = "Phone Number*")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Phone number is required")]
        public string MobilePhone { get; set; }
       
       
       
        public Programs Program { get; set; }


    }
}
