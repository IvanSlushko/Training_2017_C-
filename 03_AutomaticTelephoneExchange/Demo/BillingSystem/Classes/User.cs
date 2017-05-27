using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.Classes
{
    public class User
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public decimal Money { get; private set; }

        public User(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            //default in a purse
            Money = 30m;           
        }

        public void AddMoneyToAccount(decimal money)
        {
            Money += money;
        }

        public void RemoveMoneyFromAccount(decimal money)
        {
            Money -= money;
        }

    }
}
