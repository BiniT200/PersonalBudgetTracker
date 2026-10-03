using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalBudgetTracker
{
    public class IncomeEntry : Transaction
    {
        public override string GetSummary()
        {
            return $"{Date:dd/MM/yyyy} - Income - {Description} - {Amount:C}";
        }
    }
}