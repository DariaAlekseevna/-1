// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите три числа ");
double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
double c = Convert.ToDouble(Console.ReadLine());

double max = a;
if (b > max) {max = b;}
if (c > max) {max = c;}

Console.Write("максимальное число = ");
Console.WriteLine(max);