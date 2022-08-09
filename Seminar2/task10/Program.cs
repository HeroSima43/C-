// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
int digit1 = number / 100;
int digit2 = (number - digit1 *100) / 10;
Console.WriteLine($"Вторая цифра числа: {digit2}");
