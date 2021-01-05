using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var factory = new SavingsAccountFactory() as ICreditUnionFactory;
            var citiAccount = factory.GetSavingsAccount("CITI-232");
            var nationalAccount = factory.GetSavingsAccount("NATIONAL-977");

            Console.WriteLine($"Citi balance is ${citiAccount.Balance}" + 
                $" and national balance is ${nationalAccount.Balance}");

            Console.ReadKey();
        }
    }
}
