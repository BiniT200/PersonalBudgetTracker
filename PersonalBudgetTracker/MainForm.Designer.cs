namespace PersonalBudgetTracker
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            grpIncome = new GroupBox();
            btnAddIncome = new Button();
            numIncomeAmount = new NumericUpDown();
            lblIncomeAmount = new Label();
            txtIncomeDescription = new TextBox();
            lblIncomeDescription = new Label();
            grpIncomeSummary = new GroupBox();
            lblTotalIncome = new Label();
            lstIncomeEntries = new ListBox();
            grpExpense = new GroupBox();
            label1 = new Label();
            txtExpenseDescription = new TextBox();
            label2 = new Label();
            numExpenseAmount = new NumericUpDown();
            label3 = new Label();
            cmbExpenseCategory = new ComboBox();
            btnAddExpense = new Button();
            grpIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numIncomeAmount).BeginInit();
            grpIncomeSummary.SuspendLayout();
            grpExpense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numExpenseAmount).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F);
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(448, 54);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Personal Budget Tracker";
            // 
            // grpIncome
            // 
            grpIncome.Controls.Add(btnAddIncome);
            grpIncome.Controls.Add(numIncomeAmount);
            grpIncome.Controls.Add(lblIncomeAmount);
            grpIncome.Controls.Add(txtIncomeDescription);
            grpIncome.Controls.Add(lblIncomeDescription);
            grpIncome.Location = new Point(24, 76);
            grpIncome.Name = "grpIncome";
            grpIncome.Size = new Size(363, 223);
            grpIncome.TabIndex = 1;
            grpIncome.TabStop = false;
            grpIncome.Text = "Add Income";
            // 
            // btnAddIncome
            // 
            btnAddIncome.Location = new Point(6, 154);
            btnAddIncome.Name = "btnAddIncome";
            btnAddIncome.Size = new Size(112, 34);
            btnAddIncome.TabIndex = 4;
            btnAddIncome.Text = "Add Income";
            btnAddIncome.UseVisualStyleBackColor = true;
            btnAddIncome.Click += btnAddIncome_Click;
            // 
            // numIncomeAmount
            // 
            numIncomeAmount.DecimalPlaces = 2;
            numIncomeAmount.Location = new Point(6, 117);
            numIncomeAmount.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numIncomeAmount.Name = "numIncomeAmount";
            numIncomeAmount.Size = new Size(180, 31);
            numIncomeAmount.TabIndex = 3;
            // 
            // lblIncomeAmount
            // 
            lblIncomeAmount.AutoSize = true;
            lblIncomeAmount.Location = new Point(12, 89);
            lblIncomeAmount.Name = "lblIncomeAmount";
            lblIncomeAmount.Size = new Size(106, 25);
            lblIncomeAmount.TabIndex = 2;
            lblIncomeAmount.Text = "Amount ($):";
            lblIncomeAmount.Click += lblIncomeAmount_Click;
            // 
            // txtIncomeDescription
            // 
            txtIncomeDescription.Location = new Point(6, 55);
            txtIncomeDescription.Name = "txtIncomeDescription";
            txtIncomeDescription.Size = new Size(249, 31);
            txtIncomeDescription.TabIndex = 2;
            // 
            // lblIncomeDescription
            // 
            lblIncomeDescription.AutoSize = true;
            lblIncomeDescription.Location = new Point(6, 27);
            lblIncomeDescription.Name = "lblIncomeDescription";
            lblIncomeDescription.Size = new Size(106, 25);
            lblIncomeDescription.TabIndex = 2;
            lblIncomeDescription.Text = "Description:";
            // 
            // grpIncomeSummary
            // 
            grpIncomeSummary.Controls.Add(lblTotalIncome);
            grpIncomeSummary.Controls.Add(lstIncomeEntries);
            grpIncomeSummary.Location = new Point(447, 76);
            grpIncomeSummary.Name = "grpIncomeSummary";
            grpIncomeSummary.Size = new Size(419, 223);
            grpIncomeSummary.TabIndex = 2;
            grpIncomeSummary.TabStop = false;
            grpIncomeSummary.Text = "Income Summary";
            // 
            // lblTotalIncome
            // 
            lblTotalIncome.AutoSize = true;
            lblTotalIncome.Location = new Point(6, 187);
            lblTotalIncome.Name = "lblTotalIncome";
            lblTotalIncome.Size = new Size(166, 25);
            lblTotalIncome.TabIndex = 1;
            lblTotalIncome.Text = "Total Income: $0.00";
            // 
            // lstIncomeEntries
            // 
            lstIncomeEntries.FormattingEnabled = true;
            lstIncomeEntries.Location = new Point(6, 30);
            lstIncomeEntries.Name = "lstIncomeEntries";
            lstIncomeEntries.Size = new Size(274, 154);
            lstIncomeEntries.TabIndex = 0;
            // 
            // grpExpense
            // 
            grpExpense.Controls.Add(btnAddExpense);
            grpExpense.Controls.Add(cmbExpenseCategory);
            grpExpense.Controls.Add(label3);
            grpExpense.Controls.Add(numExpenseAmount);
            grpExpense.Controls.Add(label2);
            grpExpense.Controls.Add(txtExpenseDescription);
            grpExpense.Controls.Add(label1);
            grpExpense.Location = new Point(24, 326);
            grpExpense.Name = "grpExpense";
            grpExpense.Size = new Size(363, 394);
            grpExpense.TabIndex = 3;
            grpExpense.TabStop = false;
            grpExpense.Text = "Add Expense";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 0;
            label1.Text = "Description:";
            label1.Click += label1_Click;
            // 
            // txtExpenseDescription
            // 
            txtExpenseDescription.Location = new Point(6, 71);
            txtExpenseDescription.Name = "txtExpenseDescription";
            txtExpenseDescription.Size = new Size(249, 31);
            txtExpenseDescription.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 118);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 2;
            label2.Text = "Amount ($):";
            // 
            // numExpenseAmount
            // 
            numExpenseAmount.DecimalPlaces = 2;
            numExpenseAmount.Location = new Point(12, 146);
            numExpenseAmount.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numExpenseAmount.Name = "numExpenseAmount";
            numExpenseAmount.Size = new Size(180, 31);
            numExpenseAmount.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 180);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 4;
            label3.Text = "Category:";
            // 
            // cmbExpenseCategory
            // 
            cmbExpenseCategory.FormattingEnabled = true;
            cmbExpenseCategory.Items.AddRange(new object[] { "Rent", "", "Groceries", "", "Transport", "", "Family Support", "", "Entertainment", "", "Other" });
            cmbExpenseCategory.Location = new Point(12, 208);
            cmbExpenseCategory.Name = "cmbExpenseCategory";
            cmbExpenseCategory.Size = new Size(182, 33);
            cmbExpenseCategory.TabIndex = 5;
            cmbExpenseCategory.SelectedIndexChanged += cmbExpenseCategory_SelectedIndexChanged;
            // 
            // btnAddExpense
            // 
            btnAddExpense.Location = new Point(12, 247);
            btnAddExpense.Name = "btnAddExpense";
            btnAddExpense.Size = new Size(133, 34);
            btnAddExpense.TabIndex = 6;
            btnAddExpense.Text = "Add Expense";
            btnAddExpense.UseVisualStyleBackColor = true;
            btnAddExpense.Click += btnAddExpense_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 714);
            Controls.Add(grpExpense);
            Controls.Add(grpIncomeSummary);
            Controls.Add(grpIncome);
            Controls.Add(lblTitle);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personal Budget Tracker";
            grpIncome.ResumeLayout(false);
            grpIncome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numIncomeAmount).EndInit();
            grpIncomeSummary.ResumeLayout(false);
            grpIncomeSummary.PerformLayout();
            grpExpense.ResumeLayout(false);
            grpExpense.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numExpenseAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private GroupBox grpIncome;
        private Label lblIncomeDescription;
        private TextBox txtIncomeDescription;
        private Label lblIncomeAmount;
        private NumericUpDown numIncomeAmount;
        private Button btnAddIncome;
        private GroupBox grpIncomeSummary;
        private ListBox lstIncomeEntries;
        private Label lblTotalIncome;
        private GroupBox grpExpense;
        private Label label1;
        private TextBox txtExpenseDescription;
        private Label label2;
        private Label label3;
        private NumericUpDown numExpenseAmount;
        private ComboBox cmbExpenseCategory;
        private Button btnAddExpense;
    }
}
