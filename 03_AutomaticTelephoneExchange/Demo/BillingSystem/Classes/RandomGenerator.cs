using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BillingSystem.Classes
{
    public class RandomGenerator
    {
        Random rand = new Random(DateTime.Now.Millisecond);
        public int GetRandom (int minValue, int maxValue)
        {
            return (rand.Next(minValue, maxValue));
        }
    }
}
