using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Welp.Models;

// DAL (Data Access Layer)

namespace Welp.DAL
{
    public class WelpContext : DbContext
    {
        public WelpContext() : base("WelpContext")
        {

        }

        public DbSet<BusinessType> BusinessTypes { get; set; }
        public DbSet<Business> Businesses { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}