using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Budgeter.Models.CodeFirst
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int BudgetItemId { get; set; }
        public int TransactionId { get; set; }

        public virtual BudgetItem BudgetItem { get; set; }
        public virtual Transaction Transaction { get; set; }
    }
}