using Budgeter.Models.CodeFirst;
using System;

namespace Budgeter.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTimeOffset Date { get; set; }
        public decimal Amount { get; set; }
        public bool Type { get; set; }
        public bool Reconciled { get; set; }
        public decimal ReconciledAmount { get; set; }
        public bool Deleted { get; set; }

        public int CategoryId { get; set; }
        public int BankAccountId { get; set; }
        public string CreatorUserId { get; set; }

        public virtual Category Category { get; set; }
        public virtual BankAccount BankAccount { get; set; }
        public virtual ApplicationUser CreatorUser { get; set; }

    }
}