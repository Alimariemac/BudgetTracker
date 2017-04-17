namespace Budgeter.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using Models.CodeFirst;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Budgeter.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Budgeter.Models.ApplicationDbContext context)
        {

            var userManager = new UserManager<ApplicationUser>(
             new UserStore<ApplicationUser>(context));

            if (!context.Users.Any(u => u.Email == "Aliciamaccara@gmail.com"))
            {
                userManager.Create(new ApplicationUser
                {
                    UserName = "Aliciamaccara@gmail.com",
                    Email = "Aliciamaccara@gmail.com",
                    FirstName = "Alicia",
                    LastName = "MacCara",
                    DisplayName = "Alimariemac"
                }, "Testpassword123!");
            }


            var userId = userManager.FindByEmail("Aliciamaccara@gmail.com").Id;

            if (!context.Categories.Any(u => u.Name == "Food"))
            { context.Categories.Add(new Category { Name = "Food" }); }
            if (!context.Categories.Any(u => u.Name == "Rent"))
            { context.Categories.Add(new Category { Name = "Rent" }); }
            if (!context.Categories.Any(u => u.Name == "Utilities"))
            { context.Categories.Add(new Category { Name = "Utilities" }); }
            if (!context.Categories.Any(u => u.Name == "Cellphone"))
            { context.Categories.Add(new Category { Name = "Cellphone" }); }
            if (!context.Categories.Any(u => u.Name == "Transportation"))
            { context.Categories.Add(new Category { Name = "Transportation" }); }
            if (!context.Categories.Any(u => u.Name == "Clothing"))
            { context.Categories.Add(new Category { Name = "Clothing" }); }
            if (!context.Categories.Any(u => u.Name == "Hygiene"))
            { context.Categories.Add(new Category { Name = "Hygiene" }); }
            if (!context.Categories.Any(u => u.Name == "Education"))
            { context.Categories.Add(new Category { Name = "Education" }); }
            if (!context.Categories.Any(u => u.Name == "Loan Payment"))
            { context.Categories.Add(new Category { Name = "Loan Payment" }); }
            if (!context.Categories.Any(u => u.Name == "Salary Pay"))
            { context.Categories.Add(new Category { Name = "Salary Pay" }); }
            if (!context.Categories.Any(u => u.Name == "Taxes"))
            { context.Categories.Add(new Category { Name = "Taxes" }); }
            if (!context.Categories.Any(u => u.Name == "Misc"))
            { context.Categories.Add(new Category { Name = "Misc" }); }
        }
    }
}
