using System;

class BankAccount
{
    private double balance;


    public BankAccount(double initialDeposit)
    {
        SetBalance(initialDeposit);
    }


    public double GetBalance()
    {
        return balance;
    }


    public void SetBalance(double amount)
    {
        this.balance = amount;
    }


    public void DepositFunds(double amount)
    {
        SetBalance(GetBalance() + amount);
    }


    public double WithdrawBalance(double amount)
    {
        if(amount >= balance)
        {
            amount = balance;
            SetBalance(amount);
        }
        else 
        {
            SetBalance(GetBalance() - amount);
        }

        return amount;
    }
}


class SavingsAccount : BankAccount
{
    private double interest;


    public SavingsAccount(double initialDeposit, double interestRate) : base(initialDeposit)
    {
        SetInterestRate(interest);
    }


    public double GetInterestRate()
    {
        return interest / 100;
    }


    public void SetInterestRate(double interest)
    {
        this.interest = interest;
    }


    public double AddInterest()
    {
        double balance = GetBalance();
        double interest = GetInterestRate();
        double interestAmount = balance * interest;

        double newBalance = balance + interestAmount;

        SetBalance(newBalance);

        return newBalance;
    }
}


class TimeMaturityAccount : SavingsAccount
{

}


class CheckingAccount : BankAccount
{

}


class OverdraftAccount : BankAccount
{
    
}