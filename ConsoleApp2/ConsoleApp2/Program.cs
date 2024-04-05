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
           string sign;

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
            Console.Write("Введите первое число: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите Второе число: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Знаки действия: \n1) Сумма\n2) Разность\n3) Произведение \n4) Частное\n5) Остаток от деления\n6) Степень\n7) Факториал числа a\n8) Факториал числа b\n9) Квадратный корень a\n10) Квадратный корень b\n" +
           "11) Синус a\n12) Синус b\n13) Косинус a\n14) Косинус b\n15) Тангенс а\n16) Тангенс b\n17) Котангенс a \n18) Котангенс b\n19) Модуль числа a \n20) Модуль числа b \n21) Логарифм числа a по основанию b  \n" +
           "22) Логарифм числа b по основанию a   \n23) Натуральный Логарифм числа a равен \n24) Натуральный Логарифм числа b \n25) Десятичный Логарифм числа a \n26) Десятичный Логарифм числа b    ");
            Console.Write("Введите знак действия : ");
            sign = Convert.ToString(Console.ReadLine());
            
           

            if (sign == "1")
            {
                result = a + b;
                Console.WriteLine("Сумма чисел равна " + result);
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();
            }
            else if (sign == "2")
            {
                result = a - b;
                Console.WriteLine("Разность чисел равна " + result);
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();
            }
            else if (sign == "3")
            {
                result = a * b;
                Console.WriteLine("Произведение  чисел равно " + result);
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();
            }

            else if (sign == "4")
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

               


            }
            else if (sign == "5")

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
                    Console.WriteLine("Остаток от деления: " + result);
                    Console.WriteLine("Для выхода нажмите любую клавишу...");
                    Console.ReadKey();
                }
            }
            if(sign == "6")
            {
                result = Math.Pow(a, b);
                Console.WriteLine("Степень: " + result);
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();
            }
            if(sign == "7")

            {
                double c = Factorial_a(a);
                Console.WriteLine("Факториал a: " + c);
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();

            }
            if (sign == "8")

            {
                double d = Factorial_b(b);
                Console.WriteLine("Факториал b: " + d);
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();

            }
            if (sign == "9")

            {
                Console.WriteLine($"Квадратный корень  числа a равен: {Math.Sqrt(a)}");
               
              Console.WriteLine("Для выхода нажмите любую клавишу...");
              Console.ReadKey();
            }
            if (sign == "10")

            {
               
                Console.WriteLine($"Квадратный корень числа b равен: {Math.Sqrt(b)}");
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();
            }
           else if(sign == "19")
            {
                if (a<0)
                {
                    a = (-1) * a;
                    Console.WriteLine("Модуль числа a равен: "+ a);
                    Console.WriteLine("Для выхода нажмите любую клавишу...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Все впорядке");
                    Console.WriteLine("Для выхода нажмите любую клавишу...");
                    Console.ReadKey();
                }
            }
            else if (sign == "20")
            {
                if (b < 0)
                {
                    b = (-1) * b;
                    Console.WriteLine("Модуль числа b равен: " + b);
                    Console.WriteLine("Для выхода нажмите любую клавишу...");
                    Console.ReadKey();
                }
            }
            if(sign == "21")
            {
                Console.WriteLine($"Логарифм числа a по основанию b равен:{Math.Log(a, b)} ");
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();
            }
            if (sign == "22")
            {
                Console.WriteLine($"Логарифм числа b по основанию a равен:{Math.Log(b, a)} ");
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();
            }
            if (sign == "23")
            {
                Console.WriteLine($"Натуральный Логарифм числа a равен:{Math.Log(a)} ");
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();
            }
            if (sign == "24")
            {
                Console.WriteLine($"Натуральный Логарифм числа b равен:{Math.Log(b)} ");
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();
            }
            if(sign == "25")
            {
                Console.WriteLine($" Десятичный Логарифм числа a равен:{Math.Log(a, 10)} ");
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();
            }
            if (sign == "26")
            {
                Console.WriteLine($" Десятичный Логарифм числа b  равен:{Math.Log(b, 10)} ");
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();
            }

            else if (sign == "11")
            {
                Console.WriteLine($"Синус a равен: {Math.Sin(a)}");
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();
            }
            else if (sign == "12")
            {
                Console.WriteLine($"Синус b равен: {Math.Sin(b)}");
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();
            }
            else if (sign == "13")
            {
                Console.WriteLine($"Косинус a равен: {Math.Cos(a)}");
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();
            }
            else if (sign == "14")
            {
                Console.WriteLine($"Косинус b равен: {Math.Cos(b)}");
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();
            }
            else if (sign == "15")
            {
                Console.WriteLine($"Тангенс a равен: {Math.Tan(a)}");
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();
            }
            else if (sign == "16")


            {
                Console.WriteLine($"Тангенс b равен: {Math.Tan(b)}");
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();
            }
            else if (sign == "17")
            {
                Console.WriteLine($"Котангенс a равен: {1 / Math.Tan(a)}");
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();
            }
            else if (sign == "18")
            {
                Console.WriteLine($"Котангенс b равен: {1 / Math.Tan(b)}");
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();
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
   

