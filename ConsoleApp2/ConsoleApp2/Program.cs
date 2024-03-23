// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System;

Console.Write("Input a: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Input b: ");
double b = Convert.ToDouble(Console.ReadLine());
// базовые функции
double c = a + b;
Console.WriteLine($"Сумма: {c}");
double d = a - b;
Console.WriteLine($"Разность: {d}");
double c1 = a * b;
Console.WriteLine($"Умножение: {c1}");
double d1 = a / b;
Console.WriteLine($"Деление: {d1}");
double d2 = a % b;
Console.WriteLine($"Остаток от деления: {d2}");
// триганометрические функции (В радианах)
Console.WriteLine($"Синус b: {Math.Sin(b)}");

Console.WriteLine($"Синус a: {Math.Sin(a)}");
Console.WriteLine($"Косинус b: {Math.Cos(b)}");

Console.WriteLine($"Косинус a: {Math.Cos(a)}");
Console.WriteLine($"Тангенс b : {Math.Tan(b)}");

Console.WriteLine($"Тангенс a : {Math.Tan(a)}");
Console.WriteLine($"Котангенс b : { 1 / Math.Tan(b)}");
Console.WriteLine($"Котангенс a : {1 / Math.Tan(a)}");