using Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class BarReviewDbContext : IdentityDbContext<User, IdentityRole, string>
    {
        public virtual DbSet<Bar> Bars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=BarReview; Integrated Security = true");
            }
        }

        public BarReviewDbContext()
        {

        }
        public BarReviewDbContext(DbContextOptions<BarReviewDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }
    }
}
