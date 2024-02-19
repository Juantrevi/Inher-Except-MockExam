namespace MockExam.bank;

public class BankDemo
{
    public void Run()
    {
        try
        {
            CheckingAccount.Withdraw(1000);
        }
        catch (InsufficientFundsException e)
        {
            Console.WriteLine(e.Message);
        }

        try
        {
            CheckingAccount.Withdraw(200);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        
        CheckingAccount.Lodge(2000);
    }
    
}