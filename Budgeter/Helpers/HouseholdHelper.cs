using Budgeter.Models;
using Budgeter.Models.CodeFirst;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Budgeter.Helpers
{
    public class HouseholdHelper
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public bool IsUserInHousehold(string userId, int householdId)
        {
            var house = db.Households.Find(householdId);
            var flag = (house.Users.Any(u => u.Id == userId));
            return (flag);
        }

        public void AddUserToHousehold(string userId, int householdId)
        {
            if (!IsUserInHousehold(userId, householdId))
            {
                Household house = db.Households.Find(householdId);
                var newUser = db.Users.Find(userId);

                house.Users.Add(newUser);
                db.SaveChanges();

            }
        }

        public void RemoveUserFromHousehold(string userId, int householdId)
        {
            if (IsUserInHousehold(userId, householdId))
            {
                Household house = db.Households.Find(householdId);
                var delUser = db.Users.Find(userId);

                house.Users.Remove(delUser);
                db.Entry(house).State = EntityState.Modified; // just saves this obj instance.
                db.SaveChanges();

            }
        }

        public ICollection<ApplicationUser> UsersInHousehold(int householdId)
        {
            return db.Households.Find(householdId).Users.ToList();
        }

        //Check this code=>
        public ICollection<ApplicationUser> UsersNotInHousehold(int householdId)
        {
            return db.Users.Where(u => u.Household.Id != householdId).ToList();
        }
    }
}