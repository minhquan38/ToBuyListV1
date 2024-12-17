namespace ToBuyListV1.Models
{
    public class Budget
    {
        public int Id { get; set; }

        // Monthly spending limit
        public decimal MonthlyBudget { get; set; }

        // Yearly spending limit
        public decimal YearlyBudget { get; set; }

        // Total amount spent within the current month
        public decimal TotalSpent { get; set; } = 0;

        // Foreign key to associate this budget with a specific user
        public int UserId { get; set; }

        // Navigation property to reference the user who owns this budget
        public User User { get; set; }
    }
}
