using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.Models;

namespace DataLibrary.DataContext
{
    public class ELearningContext:IdentityDbContext
    {
        public ELearningContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<User> User { get; set; }

       
    }
}
