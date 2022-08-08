// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите число № 1: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число № 2: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
{
    Console.Write("Максимальное число: ");
    Console.WriteLine(numberA);
    Console.Write("Минимальное число: ");
    Console.WriteLine(numberB);
}
else
{
    Console.Write("Максимальное число: ");
    Console.WriteLine(numberB);
    Console.Write("Минимальное число: ");
    Console.WriteLine(numberA);
}