//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) 
{
    Console.Write("Введено некорректное число, введите целое положительное число");
}

int count = 0;
int N = number;

if (number == 1)
{
    Console.Write("нет чётных чисел");
}
else while (count < N)
{
    if (number % 2 == 0)
{
     Console.Write(number);
     Console.Write(" ");
     number--;
     count++;
} 
else 
{
    number--;
    count++;
}

 }

