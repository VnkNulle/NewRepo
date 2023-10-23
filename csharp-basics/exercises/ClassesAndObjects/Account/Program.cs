using System;

class Program
{
    static void Main(string[] args)
    {
        Account bartosAccount = new Account("Barto's account", 100.00);
        bartosAccount.Deposit(20.00);
        Console.WriteLine(bartosAccount);

        Account mattsAccount = new Account("Matt's account", 1000.00);
        Account myAccount = new Account("My account", 0.00);

        mattsAccount.Withdrawal(100.00);
        myAccount.Deposit(100.00);

        Console.WriteLine(mattsAccount);
        Console.WriteLine(myAccount);

        Account accountA = new Account("A", 100.00);
        Account accountB = new Account("B", 0.00);
        Account accountC = new Account("C", 0.00);

        Account.Transfer(accountA, accountB, 50.00);
        Account.Transfer(accountB, accountC, 25.00);

        Console.WriteLine(accountA);
        Console.WriteLine(accountB);
        Console.WriteLine(accountC);
    }
}
