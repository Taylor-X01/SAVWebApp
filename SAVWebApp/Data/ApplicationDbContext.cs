using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using SAVWebApp.Models;

namespace SAVWebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SAVWebApp.Models.Client> Client { get; set; }
        public DbSet<SAVWebApp.Models.Request> Request { get; set; }
    }
}
