using System;

namespace OOP

{ 
 class Program
    {
        private static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount();

            bankAccount.SetId(5);

            bankAccount.SetBalance(123);

            Console.WriteLine(bankAccount.GetBalance());

            Console.WriteLine(bankAccount.GetId());

            BankAccountUpdated account1 = new BankAccountUpdated();

            account1._balance = 160;

            BankAccountUpdated account2 = new BankAccountUpdated(124);

            Console.WriteLine(account1._id);

            Console.WriteLine(account2._id);

            Console.WriteLine(account1._balance);

            Console.WriteLine(account2._balance);

            Console.WriteLine();

            account1.Transaction(account2, 40);

            Console.WriteLine(account1._balance);

            Console.WriteLine(account2._balance);

            Console.WriteLine(new StringReverter().StringReverse("ABCD"));

            Console.ReadKey();
        }
    }
}
