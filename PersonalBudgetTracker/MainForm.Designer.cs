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
            lblIncomeDescription = new Label();
            txtIncomeDescription = new TextBox();
            lblIncomeAmount = new Label();
            numIncomeAmount = new NumericUpDown();
            btnAddIncome = new Button();
            grpIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numIncomeAmount).BeginInit();
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
            grpIncome.Size = new Size(300, 223);
            grpIncome.TabIndex = 1;
            grpIncome.TabStop = false;
            grpIncome.Text = "Add Income";
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
            // txtIncomeDescription
            // 
            txtIncomeDescription.Location = new Point(6, 55);
            txtIncomeDescription.Name = "txtIncomeDescription";
            txtIncomeDescription.Size = new Size(249, 31);
            txtIncomeDescription.TabIndex = 2;
            // 
            // lblIncomeAmount
            // 
            lblIncomeAmount.AutoSize = true;
            lblIncomeAmount.Location = new Point(6, 89);
            lblIncomeAmount.Name = "lblIncomeAmount";
            lblIncomeAmount.Size = new Size(106, 25);
            lblIncomeAmount.TabIndex = 2;
            lblIncomeAmount.Text = "Amount ($):";
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 544);
            Controls.Add(grpIncome);
            Controls.Add(lblTitle);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personal Budget Tracker";
            grpIncome.ResumeLayout(false);
            grpIncome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numIncomeAmount).EndInit();
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
    }
}
