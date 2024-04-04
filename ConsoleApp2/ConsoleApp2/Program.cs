// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            double result;
            char sign;

           double Factorial_a(double a)
            {
                if (a == 1) return 1;

                return a * Factorial_a(a - 1);
            }
            double Factorial_b(double b)
            {
                if (b == 1) return 1;

                return b * Factorial_b(b - 1);
            }
            Console.WriteLine("Знаки действия  +,  -,  *,  /, %, ^, !,  ");
            Console.WriteLine(" 1) Синус b, 2) Синус b, 3) Косинус a, 4) Косинус b, 5) Тангенс а,  6) Тангенс b, 7) Котангенс a, 8) Котангенс b  ");

            Console.Write("Введите первое число: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите Второе число: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите знак действия : ");
            sign = Convert.ToChar(Console.ReadLine());

            if (sign == '+')
            {
                result = a + b;
                Console.WriteLine("Сумма чисел равна " + result);
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();
            }
            else if (sign == '-')
            {
                result = a - b;
                Console.WriteLine("Разность чисел равна " + result);
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();
            }
            else if (sign == '*')
            {
                result = a * b;
                Console.WriteLine("Произведение  чисел равно " + result);
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();
            }

            else if (sign == '/')
            {
                if (b == 0)
                {
                    Console.WriteLine("Ошибка. Делитель не может быть равным нулю.");
                    Console.WriteLine("Для выхода нажмите любую клавишу...");
                    Console.ReadKey();
                }
                else
                {
                    result = a / b;
                    Console.WriteLine("Частное чисел равна " + result);
                    Console.WriteLine("Для выхода нажмите любую клавишу...");
                    Console.ReadKey();
                }

                if (sign == '!')
                {

                }


            }
            else if (sign == '%')
            {
                if (b == 0)
                {
                    Console.WriteLine("Ошибка. Делитель не может быть равным нулю.");
                    Console.WriteLine("Для выхода нажмите любую клавишу...");
                    Console.ReadKey();
                }
                else
                {
                    result = a % b;
                    Console.WriteLine("Остаток от деления " + result);
                    Console.WriteLine("Для выхода нажмите любую клавишу...");
                    Console.ReadKey();
                }
            }
            if(sign == '^')
            {
                result = Math.Pow(a, b);
                Console.WriteLine("Степень " + result);
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();
            }
            if(sign == '!')
            {
                double c = Factorial_a(a);
                Console.WriteLine("Факториал a: " + c);
                
                double d = Factorial_b(b);
                Console.WriteLine("Факториал b: " + d);
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();

            }


            
        


            else if (sign == '1')
            {
                Console.WriteLine($"Синус a равен: {Math.Sin(a)}");
            }
            else if (sign == '2')
            {
                Console.WriteLine($"Синус b равен: {Math.Sin(b)}");
            }
            else if (sign == '3')
            {
                Console.WriteLine($"Косинус a равен: {Math.Cos(a)}");
            }
            else if (sign == '4')
            {
                Console.WriteLine($"Косинус b равен: {Math.Cos(b)}");
            }
            else if (sign == '5')
            {
                Console.WriteLine($"Тангенс a равен: {Math.Tan(a)}");
            }
            else if (sign == '6')
            {
                Console.WriteLine($"Тангенс b равен: {Math.Tan(b)}");
            }
            else if (sign == '7')
            {
                Console.WriteLine($"Котангенс a равен: {1 / Math.Tan(a)}");
            }
            else if (sign == '8')
            {
                Console.WriteLine($"Котангенс b равен: {1 / Math.Tan(b)}");
            }


            else
            {
                Console.WriteLine("Ошибка. Вы ввели неверный знак.");
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();


            }

        }
        
        
    }
   
}
