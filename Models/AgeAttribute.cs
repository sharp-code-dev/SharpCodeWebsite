using System;

namespace SharpCodeWebsite.Models
{
    internal class AgeAttribute : Attribute
    {
        public string ErrorMessage { get; set; }
    }
}