namespace MockExam.bank;

public class CheckingAccount
{
    public static void Lodge(double amount)
    {
        double balance = 500;
        balance += amount;
        Console.WriteLine("Depositing  $" + amount);
        Console.WriteLine("New balance is  $" + balance);
        
        //return balance;
    }
    
    public static void Withdraw(double amount)
    {
        double balance = 500;
        balance -= amount;
        
        Console.WriteLine("Withdrawing  $" + amount);
        if (balance < 0)
        {
            throw new InsufficientFundsException(balance);
        }
        Console.WriteLine("New balance is  $" + balance);
        
        //return balance;
    }
}