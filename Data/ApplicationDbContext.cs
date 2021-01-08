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
        public DbSet<SharpCodeWebsite.Models.Registration> Registration { get; set; }
        public DbSet<SharpCodeWebsite.Models.Contact> Contact { get; set; }
        public DbSet<SharpCodeWebsite.Models.Programs> Programs { get; set; }
    }
}
