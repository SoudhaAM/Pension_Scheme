using Microsoft.EntityFrameworkCore;
using PravasiPensionScheme.Entities;

namespace PravasiPensionScheme.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        //public DbSet<Plan> Plans => Set<Plan>();
    }
}
