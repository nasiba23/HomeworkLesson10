using System;

namespace HomeworkLesson10
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator<int> calculator = Add;
            int additionResult = calculator(6, 2);
            System.Console.WriteLine(additionResult);
            calculator += Divide;
            int divisionResult = calculator(6, 1);
            System.Console.WriteLine(divisionResult);
        }
        static T Add <T> (T operand1, T operand2) where T : struct
        {
            dynamic a = operand1;
            dynamic b = operand2;
            return a + b;
        }
        static T Subtract <T> (T operand1, T operand2) where T : struct
        {
            dynamic a = operand1;
            dynamic b = operand2;
            return a - b;
        }
        static T Multiply <T> (T operand1, T operand2) where T : struct
        {
            dynamic a = operand1;
            dynamic b = operand2;
            return a * b;
        }
        static T Divide <T> (T operand1, T operand2) where T : struct
        {
            dynamic resultIfDividedByZero = 0;
            dynamic a = operand1;
            dynamic b = operand2;
            if (b == 0)
            {
                Console.WriteLine("Can't delete by 0");
                return resultIfDividedByZero;
            }
            else
            {
                return a / b;
            }
        }

        public delegate T Calculator <T>(T operand1, T operand2);    
    }
}
