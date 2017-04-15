using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Budgeter.Models.CodeFirst
{
    public class Household
    {
        public Household()
            {
                this.Accounts = new HashSet<Account>();
                this.Budgets = new HashSet<Budget>();
                this.Users = new HashSet<ApplicationUser>();
            }
        public int Id { get; set; }
        public string Name { get; set; }
        
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<Budget> Budgets { get; set; }
        public virtual ICollection<ApplicationUser> Users { get; set; }


    }
}