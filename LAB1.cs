using System;

public class Account
{
    private decimal balance; // instance variable that stores the balance

    // constructor
    public Account(decimal initialBalance)
    {
        Balance = initialBalance; // set balance using property
    }

    // credit (add) an amount to the account
    public void Credit(decimal amount)
    {
        Balance = Balance + amount; // add amount to balance
    }

    // a property to get and set the account balance
    public decimal Balance
    {
        get
        {
            return balance;
        }

        set
        {
            // validate that value is greater than or equal to 0;
            // if it is not, balance is left unchanged
            if (value >= 0)
            {
                balance = value;
            }
        }
    }
}

public class AccountTest
{
    public static void Main(string[] args)
    {
        Account account1 = new Account(50.00M);
        Account account2 = new Account(-7.53M);

        // display initial balance of each object using a property
        Console.WriteLine("account1 balance: {0:C}", account1.Balance);
        Console.WriteLine("account2 balance: {0:C}\n", account2.Balance);

        decimal depositAmount; // deposit amount read from user

        // prompt and obtain user input
        Console.Write("Enter deposit amount for account1: ");
        depositAmount = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("adding {0:C} to account1 balance\n", depositAmount);
        account1.Credit(depositAmount);

        // display balances
        Console.WriteLine("account1 balance: {0:C}", account1.Balance);
        Console.WriteLine("account2 balance: {0:C}\n", account2.Balance);

        // prompt and obtain user input
        Console.Write("Enter deposit amount for account2: ");
        depositAmount = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("adding {0:C} to account2 balance\n", depositAmount);
        account2.Credit(depositAmount);

        // display balances
        Console.WriteLine("account1 balance: {0:C}", account1.Balance);
        Console.WriteLine("account2 balance: {0:C}", account2.Balance);
    }
}
