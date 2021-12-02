using System;

public class MainClass
{
    public static void Main(string[] args)
    {
        HourlyEmployee employee = new HourlyEmployee("Mani", "Raj", 1000);
        
        employee.AddHours(5);
        
        employee.AddHours(10);

        string employeeWage = employee.PrintPayCheck();

        Console.WriteLine(employeeWage);
    }
}

public abstract class Employee
{
    private string firstName;
    private string lastName;
    private double wage;
    
    public Employee(string firstName, string lastName, double wage)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.wage = wage;
    }
    
    public string GetFirstName()
    {
        return firstName;
    }
    
    public string GetLastName()
    {
        return lastName;
    }
    
    public double GetWage()
    {
        return wage;
    }
    
    public abstract double CalculatePay();
    
    public string PrintPayCheck()
    {
        string fullName = firstName + " " + lastName;
        
        return ("Name: " + fullName + "\nSalary: " + CalculatePay());
    }
}


public class HourlyEmployee : Employee
{
    private int hours;
    
    public HourlyEmployee(string firstName, string lastName, double wage) : base(firstName, lastName, wage)
    {
        
    }
    
    public override double CalculatePay()
    {
        return GetWage() * hours;
    }
    
    public void AddHours(int hours) {
        this.hours += hours;
    }
    
    public void ResetHours()
    {
        hours = 0;
    }
}
