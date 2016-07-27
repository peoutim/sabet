// File: BankAccount.cs
using System;

class BankAccount
{
    // create a field of type decimal and call it balance
    private decimal balance;
    
    // optional: good to have a constructor
    public BankAccount()
    {
        balance = 0;
    }
    
    // Do the Depoist
    public void Deposit(decimal deposit)
    {
        balance = balance + deposit;
    }

    // Do the Withdrawal
    public void Withdrawal(decimal withdraw)
    {
        balance = balance - withdraw;
    }

    // Return the Final Balance
    public decimal GetBalance()
    {
        return balance;
    }   
}

class Test
{
    static void Main()
    {
        BankAccount acct = new BankAccount();

        acct.Deposit(200m);
        acct.Withdrawal(40m);
        acct.Deposit(40m);
        
        Console.WriteLine("Balance {0:C}", acct.GetBalance());

        Console.ReadLine();
    }
}