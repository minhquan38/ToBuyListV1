using Microsoft.EntityFrameworkCore;
using ToBuyListV1.Models;

namespace ToBuyListV1
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Budget> Budgets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Users
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    OAuthId = "google-oauth-id-1",
                    Email = "user1@example.com",
                    DisplayName = "John Doe"
                },
                new User
                {
                    Id = 2,
                    OAuthId = "google-oauth-id-2",
                    Email = "user2@example.com",
                    DisplayName = "Jane Smith"
                }
            );

            // Seeding Product data
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Laptop",
                    Url = "https://example.com/laptop",
                    Price = 1200.00m,         // Example price
                    LastUpdated = DateTime.UtcNow,
                    Priority = 1,             // Highest priority
                    IsPurchased = false,      // Not purchased yet
                    UserId = 1                // Assuming User with ID 1 exists
                },
                new Product
                {
                    Id = 2,
                    Name = "Smartphone",
                    Url = "https://example.com/smartphone",
                    Price = 800.00m,          // Example price
                    LastUpdated = DateTime.UtcNow.AddDays(-7), // Last updated a week ago
                    Priority = 2,             // Second priority
                    IsPurchased = false,      // Not purchased yet
                    UserId = 1                // Assuming User with ID 1 exists
                },
                new Product
                {
                    Id = 3,
                    Name = "Headphones",
                    Url = "https://example.com/headphones",
                    Price = 150.00m,          // Example price
                    LastUpdated = DateTime.UtcNow,
                    Priority = 3,             // Third priority
                    IsPurchased = true,       // Already purchased
                    UserId = 2                // Assuming User with ID 2 exists
                }
            );

            // Seed Budgets
            modelBuilder.Entity<Budget>().HasData(
                new Budget
                {
                    Id = 1,
                    MonthlyBudget = 2000.00m,  // Example monthly limit
                    YearlyBudget = 24000.00m, // Example yearly limit
                    TotalSpent = 500.00m,     // Example total spent for the month
                    UserId = 1                // Assuming a User with ID 1 exists
                },
                new Budget
                {
                    Id = 2,
                    MonthlyBudget = 1500.00m, // Example monthly limit
                    YearlyBudget = 18000.00m, // Example yearly limit
                    TotalSpent = 300.00m,     // Example total spent for the month
                    UserId = 2                // Assuming a User with ID 2 exists
                }
            );
        }
    }
}
