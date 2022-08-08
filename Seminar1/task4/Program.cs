// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите число № 1: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число № 2: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число № 3: ");
int numberС = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if (numberB > max)
{
    max = numberB;
}
if (numberС > max)
{
    max = numberС;
}
Console.Write("Максимальное число: ");
Console.WriteLine(max);
