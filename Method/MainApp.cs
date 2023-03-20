using System;

namespace Method
{
    class Calculator
    {
        static void Main(string[] args)
        {
            return a + b;
        }
        public static int Minus(int a, int b)
        {
            return a - b;
        }

    }
}
    class MainApp
{
    public static void Main()
    {
        int result = Calculator.plus(3, 4);
        Console.WriteLine(result);

        result = Calculator.Minus(5, 2);
        Console.WriteLine(reresult);
    }
}
