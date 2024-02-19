namespace MockExam.bank
{
    public class InsufficientFundsException : Exception
    {
        public InsufficientFundsException(double amount) : base("Insufficient funds in your account.")
        {
            Console.WriteLine("Sorry but you are short $ " + Math.Abs(amount) + " for this transaction");
        }
    }
}