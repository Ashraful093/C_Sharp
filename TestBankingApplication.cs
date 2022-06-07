using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_2
{
    public class TestBankingApplication
    {
        public static void Main()
        {
            BankingAccount account1 = new BankingAccount("Argho Das", "Current", 5000);
            BankingAccount account2 = new BankingAccount("Ashraful Islam", "Savings", 1300);
            BankingAccount account3 = new BankingAccount("Ricky ", "Overdraft", 600);
            Console.WriteLine("3 Accounts Created");
            Console.WriteLine(account1);
            Console.WriteLine(account2);
            Console.WriteLine(account3);
            if (account1.deposit(150))
            {
                Console.WriteLine("Deposit Successful");
                Console.WriteLine(account1);
            };
            if (!account2.withdraw(1500))
            {
                Console.WriteLine("Unable to withdraw full amount");
                Console.WriteLine(account2);
            }
            if (account3.withdraw(1000))
            {
                Console.WriteLine("Succesful in withdrawing extra from overdraft");
                Console.WriteLine(account3);

            }

            account2.setAccountType("Overdraft");
            account1.setAccountType("Savings");
            Console.WriteLine("Accounts After Modification");
            Console.WriteLine(account1);
            Console.WriteLine(account2);
            Console.WriteLine(account3);
        }
    }
}
