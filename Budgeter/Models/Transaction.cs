using Budgeter.Models.CodeFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Budgeter.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTimeOffset Date { get; set; }
        public decimal Amount { get; set; }
        public string Type { get; set; }
        public bool Reconciled { get; set; }
        public decimal ReconciledAmount { get; set; }

        public int CategoryId { get; set; }
        public int CreatorUserId { get; set; }

        public virtual Category Category { get; set; }
        public virtual ApplicationUser CreatorUser { get; set; }

    }
}