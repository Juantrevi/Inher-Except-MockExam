namespace MockExam.Calculator;

public class Calculator
{
    public int add(int a, int b)
    {
        return a + b;
    }

    public int add(double a, double b)
    {
        return (int) (a + b);
    }
    
    public int add(int a, int b, int c)
    {
        return a + b + c;
    }
}