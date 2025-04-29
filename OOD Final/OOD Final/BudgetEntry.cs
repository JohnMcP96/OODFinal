using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Final
{
    public class BudgetEntry
    {
        public decimal GrossIncome { get; set; }
        public decimal NetIncome { get; set; }
        public decimal Taxes { get; set; }
        public decimal Expenses { get; set; }
        public decimal Surplus { get; set; }
    }
}

