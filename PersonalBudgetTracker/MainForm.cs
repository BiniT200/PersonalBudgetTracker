namespace PersonalBudgetTracker
{
    public partial class MainForm : Form
    {
        private readonly List<IncomeEntry> incomeEntries = new();
        private decimal totalIncome = 0;
        private readonly List<Transaction> transactions = new();
        private decimal totalExpenses = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddIncome_Click(object sender, EventArgs e)
        {
            string description = txtIncomeDescription.Text.Trim();
            decimal amount = numIncomeAmount.Value;

            if (description == "")
            {
                MessageBox.Show("Please enter an income description.");
                return;
            }

            if (amount <= 0)
            {
                MessageBox.Show("Please enter an amount greater than zero.");
                return;
            }
            IncomeEntry newIncome = new IncomeEntry
            {
                Description = description,
                Amount = amount,
                Date = DateTime.Now
            };

            incomeEntries.Add(newIncome);
            transactions.Add(newIncome);
            lstIncomeEntries.Items.Add(newIncome.GetSummary()
);

            totalIncome += newIncome.Amount;
            lblTotalIncome.Text = $"Total Income: {totalIncome:C}";

            MessageBox.Show(
     $"Income saved: {description} - {amount:C}\n" +
     $"Total entries: {incomeEntries.Count}"
 );

            txtIncomeDescription.Clear();
            numIncomeAmount.Value = 0;
        }

        private void lblIncomeAmount_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbExpenseCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            string description = txtExpenseDescription.Text.Trim();
            decimal amount = numExpenseAmount.Value;
            string category = cmbExpenseCategory.Text.Trim();

            if (description == "")
            {
                MessageBox.Show("Please enter an expense description.");
                return;
            }

            if (amount <= 0)
            {
                MessageBox.Show("Please enter an amount greater than zero.");
                return;
            }

            if (category == "")
            {
                MessageBox.Show("Please select an expense category.");
                return;
            }

            ExpenseEntry newExpense = new ExpenseEntry
            {
                Description = description,
                Amount = amount,
                Category = category,
                Date = DateTime.Now
            };

            transactions.Add(newExpense);
            lstIncomeEntries.Items.Add(newExpense.GetSummary());
            totalExpenses += newExpense.Amount;

            MessageBox.Show(
                $"Expense saved: {description} - {amount:C}\n" +
                $"Category: {category}\n" +
                $"Total expenses: {totalExpenses:C}"
            );

            txtExpenseDescription.Clear();
            numExpenseAmount.Value = 0;
            cmbExpenseCategory.SelectedIndex = -1;
        }
    }
}
