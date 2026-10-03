namespace PersonalBudgetTracker
{
    public abstract class Transaction
    {
        public string Description { get; set; } = "";
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }

        public abstract string GetSummary();
    }
}