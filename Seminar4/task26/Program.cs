// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
number = Math.Abs(number);
while (number > 0)
{
    number = number / 10;
    count++;
}
Console.WriteLine(count);


//Вариант 2
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
n = Math.Abs(n);
string s = Convert.ToString(n);
Console.WriteLine(s.Length);
