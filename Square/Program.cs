using System;

Console.WriteLine("Введите число: ");
int value = Convert.ToInt32(Console.ReadLine());
Number number = new Number(value);
Console.WriteLine($"Квадрат числа: {number.Square()}");
