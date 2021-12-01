using System;

public class Account
{
    private double balance;

    public Account()
    {

    }

    public Account(double initial_deposit)
    {
        balance = initial_deposit;
    }

    public void DepositFunds(double funds)
    {
        balance += funds;
    }

    public double WithdrawFunds(double funds)
    {
        if(funds > balance) {
            Console.WriteLine("YOU DON'T HAVE THAT MUCH AMOUNT IN YOUR ACCOUNT!");
            funds = balance;
        }

        balance -= funds;

        return funds;
    }

    public double GetBalance()
    {
        return balance;
    }
}


public class Teller
{
    public static void Main(string[] args)
    {
        // User Account 1
        Account account1 = new Account(1000.0);

        Console.WriteLine("Available Balance : " + account1.GetBalance());

        Console.WriteLine("\nDeposit Rs.1450.0");
        account1.DepositFunds(1450.0);
        Console.WriteLine("After Deposit Total Amount: Rs" + account1.GetBalance());

        Console.WriteLine("\nWithdraw Rs.2000.0");
        Console.WriteLine("After Withdraw Rs." + account1.WithdrawFunds(2000.0) + ", Total Amount: Rs" + account1.GetBalance());

        Console.WriteLine("\nWithdraw Rs.1000.0");
        Console.WriteLine("After Withdraw Rs." + account1.WithdrawFunds(1000.0) + ", Total Amount: Rs" + account1.GetBalance());
    }
}