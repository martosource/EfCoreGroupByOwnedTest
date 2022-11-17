using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace EfCoreGroupByOwnedTest7
{
    public class TestContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = "Server=localhost;Database=TestV7;integrated security=yes;Encrypt=false;";

                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Item>().Property(i => i.Name).HasMaxLength(200);
            builder.Entity<Item>().Property(i => i.Group).HasMaxLength(200);
            builder.Entity<Item>().HasOne(i => i.Category).WithMany().HasForeignKey(i => i.CategoryId);
            builder.Entity<Item>().OwnsOne(i => i.Set1);
            builder.Entity<Item>().OwnsOne(i => i.Set2);
            builder.Entity<Item>().OwnsOne(i => i.Set3);


            builder.Entity<Category>().Property(i => i.Name).HasMaxLength(200);

        }
    }
}
