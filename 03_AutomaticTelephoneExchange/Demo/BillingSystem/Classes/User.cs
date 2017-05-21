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
        public int Money { get; private set; }

        public User(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Money = 10;
        }

        public void AddMoneyToAccount(int money)
        {
            Money += money;
        }

        public void RemoveMoneyFromAccount(int money)
        {
            Money -= money;
        }
    }
}
