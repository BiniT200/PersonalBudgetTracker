namespace PersonalBudgetTracker
{
    public partial class MainForm : Form
    {
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

            MessageBox.Show($"Income entered: {description} - {amount:C}");

            txtIncomeDescription.Clear();
            numIncomeAmount.Value = 0;
        }
    }
}
