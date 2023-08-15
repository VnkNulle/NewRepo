using System;

class BankAccount
{
    private string accountName;
    private double balance;

    public BankAccount(string accountName, double startingBalance)
    {
        this.accountName = accountName;
        balance = startingBalance;
    }

    public void Deposit(double amount)
    {
        balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficient funds.");
        }
    }

    public string ShowUserNameAndBalance()
    {
        string balanceString = balance >= 0 ? $"${balance:F2}" : $"-${Math.Abs(balance):F2}";
        return $"{accountName}, {balanceString}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        BankAccount benben = new BankAccount("Benson", 17.25);
        Console.WriteLine(benben.ShowUserNameAndBalance());

        BankAccount benben2 = new BankAccount("Benson", -17.5);
        Console.WriteLine(benben2.ShowUserNameAndBalance());
    }
}
