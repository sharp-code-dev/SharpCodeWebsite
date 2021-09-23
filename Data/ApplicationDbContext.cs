using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using SharpCodeWebsite.Models;

namespace SharpCodeWebsite.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
<<<<<<< HEAD
        public DbSet<Registration> Registration { get; set; }
=======
        public DbSet<SharpCodeWebsite.Models.Registration> Registration { get; set; }
        public DbSet<SharpCodeWebsite.Models.Contact> Contact { get; set; }
        public DbSet<SharpCodeWebsite.Models.Programs> Programs { get; set; }
>>>>>>> 249614fde37484fe9d71fc5e79a67090753c7cf9
    }
}
