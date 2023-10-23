using System;

class Account
{
    private string accountName;
    private double balance;

    public Account(string accountName, double initialBalance)
    {
        this.accountName = accountName;
        balance = initialBalance;
    }

    public void Withdrawal(double amount)
    {
        balance -= amount;
    }

    public void Deposit(double amount)
    {
        balance += amount;
    }

    public double Balance()
    {
        return balance;
    }

    public override string ToString()
    {
        return $"{accountName} balance: ${balance:F2}";
    }

    public static void Transfer(Account from, Account to, double howMuch)
    {
        from.Withdrawal(howMuch);
        to.Deposit(howMuch);
    }
}
