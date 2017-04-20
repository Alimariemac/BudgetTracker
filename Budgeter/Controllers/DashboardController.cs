using Budgeter.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Budgeter.Controllers
{
    public class DashboardController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Dashboard
        public ActionResult Index()
        {
            DashboardViewModel model = new DashboardViewModel();         
            var user = db.Users.Find(User.Identity.GetUserId());
            var bankAccounts = db.BankAccounts/*.Where(b => b.Household.Id == user.Household.Id)*/;
            var budget = db.Budgets/*.Where(b => b.Household.Id == user.Household.Id)*/;
            var item = db.BudgetItems/*.Where(i => i.Budget.Household.Id == user.Household.Id)*/;
            var transaction = db.Transactions/*.Where(t=>t.BankAccount.Household.Id == user.Household.Id)*/;
            decimal totalAccounts = 0;

            foreach (var acct in bankAccounts)
            {
                var tran = db.Transactions.Where(t => t.BankAccount.Id == acct.Id);
                decimal tranAmount = 0;
                foreach (var x in tran)
                {
                    tranAmount += x.Amount;
                };
                acct.Balance += tranAmount;
                totalAccounts += acct.Balance;
            }
            
            model.BankAccount = bankAccounts;
            model.Budget = budget;
            model.Item = item;
            ViewBag.totalAccounts = totalAccounts;
            return View(model);
        }
    }
}