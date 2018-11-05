using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    class MainBankProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******                     *******");
            Console.WriteLine("****** Bank functionality  *******");

            Account myBankAcc = new Account(500, 500);
            myBankAcc.Deposit(500);
            Console.WriteLine(myBankAcc);
            myBankAcc.Withdraw(1000);
            Console.WriteLine(myBankAcc);
            myBankAcc.Withdraw(500);
            Console.WriteLine(myBankAcc);
            Console.Read();
        }
    }
}
