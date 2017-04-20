using Budgeter.Models.CodeFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Budgeter.Models
{
    public class DashboardViewModel
    {
        public IEnumerable <BankAccount> BankAccount { get; set; }
        public IEnumerable <Budget> Budget { get; set; }
        public IEnumerable<BudgetItem> Item { get; set; }
        public IEnumerable<Transaction> Transaction { get; set; }
    }
}