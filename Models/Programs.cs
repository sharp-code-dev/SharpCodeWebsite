using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharpCodeWebsite.Models
{
    public class Programs
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public List <Registration> Registrations { get; set; }
    }
}
