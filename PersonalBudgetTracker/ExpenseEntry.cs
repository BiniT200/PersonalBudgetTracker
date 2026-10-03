namespace PersonalBudgetTracker
{
    public class ExpenseEntry : Transaction
    {
        public string Category { get; set; } = "";

        public override string GetSummary()
        {
            return $"{Date:dd/MM/yyyy} - Expense - {Description} - {Category} - {Amount:C}";
        }
    }
}