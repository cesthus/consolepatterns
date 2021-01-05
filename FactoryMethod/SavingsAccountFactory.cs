using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class SavingsAccountFactory : ICreditUnionFactory
    {
        public ISavingsAccount GetSavingsAccount(string accountNumber)
        {
            if (accountNumber.Contains("CITI")) { return new CitiSavingsAcct();  }
            else if(accountNumber.Contains("NATIONAL"))
            {
                return new NationalSavingsAcct();
            }
            else
            {
                throw new ArgumentException("Invalid account number");
            }
        }
    }
}
