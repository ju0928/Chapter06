using System;

namespace Method
{
    class Calculator
    {
        public static int plus(int a, int b)
        {
            return a + b;
        }
        public static int minus(int a, int b)
        {
            return a - b;
        }
    }
    class MainApp
    {
        public static void Main()
        {
            int result = Calculator.plus(3, 4);
            Console.WriteLine(result);

            result = Calculator.minus(5, 3);
            Console.WriteLine(result);
        }
    }
}