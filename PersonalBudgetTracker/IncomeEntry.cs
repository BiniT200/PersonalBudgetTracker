using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalBudgetTracker
{
    public class IncomeEntry
    {
        public string Description { get; set; } = "";
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}