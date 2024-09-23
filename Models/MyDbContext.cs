using Microsoft.EntityFrameworkCore;

namespace Online_Mobile_Shopping_Project.Models
{
    public class MyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Online_Mobile_Shopping_Project3;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User_Product>().HasKey(u => new { u.userid, u.productid });
            modelBuilder.Entity<User>().HasIndex(e => e.email).IsUnique();
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<User_Product> UserProducts { get; set; }   
    }
}
