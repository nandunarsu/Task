using System;

namespace Task
{
    class Calculator
    {
        public void Calc() {
            int res;
            Console.WriteLine("Enter values for a and b");
            int a;
            a = int.Parse(Console.ReadLine());
            int b;
            b = int.Parse(Console.ReadLine());
            char ch;
            ch = char.Parse(Console.ReadLine());
            switch (ch)
            {
                case '+':res = a + b;
                    Console.WriteLine(res);
                    break;
                case '-':res = a - b;
                    Console.WriteLine(res);
                    break;
                case '*':res = a * b;
                    Console.WriteLine(res);
                    break;
                case '/':if (b != 0)
                    {
                        res = a / b;
                        Console.WriteLine(res);
                    }
                    else
                    {
                        Console.WriteLine("Division by zero is not possible");
                    }
                    break;
                default:Console.WriteLine("Invalid");
                    break;
            }
        }
    }
}
