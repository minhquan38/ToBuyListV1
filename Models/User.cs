namespace ToBuyListV1.Models
{
    public class User
    {
        public int Id { get; set; }

        // The unique identifier provided by Google for each user
        public string OAuthId { get; set; }

        // User’s email address from Google account
        public string Email { get; set; }

        // Optional display name fetched from Google
        public string DisplayName { get; set; }

        // Navigation property for the user's products
        public List<Product> Products { get; set; } = new List<Product>();

        // Navigation property for the user's budget
        public Budget UserBudget { get; set; }
    }
}
