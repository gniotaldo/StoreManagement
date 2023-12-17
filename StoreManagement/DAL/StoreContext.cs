using StoreManagement.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace StoreManagement.DAL
{
    public class StoreContext : DbContext
    {

        public StoreContext() : base("StoreContext")
        {
        }

        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}