namespace Budgeter.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
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
        }
    }
}
