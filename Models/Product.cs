namespace ToBuyListV1.Models
{
    public class Product
    {
        public int Id { get; set; }

        // Name of the product the user wants to purchase
        public string Name { get; set; }

        // URL to fetch or view the product's details
        public string Url { get; set; }

        // Price of the product, fetched from the URL or manually entered
        public decimal Price { get; set; }

        // Last time the price was updated from the URL
        public DateTime LastUpdated { get; set; } = DateTime.UtcNow;

        // Priority level, lower number means higher priority
        public int Priority { get; set; }

        // Flag to track whether the product has been purchased
        public bool IsPurchased { get; set; } = false;

        // Foreign key to associate this product with a specific user
        public int UserId { get; set; }

        // Navigation property to reference the user who owns this product
        public User User { get; set; }
    }
}
