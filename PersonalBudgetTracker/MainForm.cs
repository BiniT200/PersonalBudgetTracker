namespace PersonalBudgetTracker
{
    public partial class MainForm : Form
    {
        private readonly List<IncomeEntry> incomeEntries = new();
        private decimal totalIncome = 0;

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
            lstIncomeEntries.Items.Add(
    $"{newIncome.Date:dd/MM/yyyy} - {newIncome.Description} - {newIncome.Amount:C}"
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
    }
}
