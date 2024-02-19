using MockExam.bank;
using MockExam.models;

namespace MockExam
{
    internal abstract class Program
    {
        private static void Main(string[] args)
        {
            var cat = new Cat();
            cat.Speak();
            
            var dog = new Dog();
            dog.Speak();
            
            var animal = new Animal();
            animal.Speak();

            var calculator = new Calculator.Calculator();
            
            Console.WriteLine(calculator.add(1, 2));
            Console.WriteLine(calculator.add(1.0, 2.0));
            Console.WriteLine(calculator.add(1, 2, 3));
            
            BankDemo bankDemo = new BankDemo();
            bankDemo.Run();
        }
    }
}

