using System;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var bankAccount = new BankAccount( "Arty", 10000);
            Console.WriteLine(
                $"A new bank account {bankAccount.Number} was created for {bankAccount.Owner} with ${bankAccount.Balance}");

            bankAccount.MakeWithdrawal(120, DateTime.Now, "Hammock");
            Console.WriteLine(bankAccount.Balance);

            bankAccount.MakeDeposit(500, DateTime.Now, "Add $500 to account");
            Console.WriteLine(bankAccount.Balance);

            Console.WriteLine(bankAccount.GetAccountHistory());

        }
    }
}
