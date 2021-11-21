using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double a, b;
                char command;
                Console.Write("Введите число: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Выберите одну из операций (+, -, *, /): ");
                command = Console.ReadKey().KeyChar;
                Console.WriteLine();
                Console.Write("Введите второе число: ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                switch (command)
                {
                    case '+':
                        Console.WriteLine("Результат: " + CalculatorCommands.Sum(a, b));
                        break;
                    case '-':
                        Console.WriteLine("Результат: " + CalculatorCommands.Substract(a, b));
                        break;
                    case '*':
                        Console.WriteLine("Результат: " + CalculatorCommands.Multiply(a, b));
                        break;
                    case '/':
                        Console.WriteLine("Результат: " + CalculatorCommands.Divide(a, b));
                        break;
                    default:
                        Console.WriteLine("Неверый ввод... ");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();

        }
    }
}
