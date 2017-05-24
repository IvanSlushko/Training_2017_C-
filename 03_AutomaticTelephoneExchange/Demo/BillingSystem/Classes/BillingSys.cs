using AutoTeleExchange.Classes;
using AutoTeleExchange.Interfaces;
using BillingSystem.Interfaces;

namespace BillingSystem.Classes
{
    public class BillingSys : IBillingSystem
    {

        private IStorage<CallInfo> _storage;

        public BillingSys(IStorage<CallInfo> storage)
        {
            _storage = storage;
        }

      
    }
}
