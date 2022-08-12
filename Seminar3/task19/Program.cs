// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

//Вариант 1.
Console.Write("Вариант 1. Введите пятизначное число: ");
int N = Convert.ToInt32(Console.ReadLine());
N = Math.Abs(N);
int digit1 = N / 10000;
int digit2 = (N - digit1 * 10000) / 1000;
int digit3 = (N - digit1 * 10000 - digit2 * 1000) / 100;
int digit4 = (N - digit1 * 10000 - digit2 * 1000 - digit3 * 100) / 10;
int digit5 = (N - digit1 * 10000 - digit2 * 1000 - digit3 * 100) % 10;
if (N < 9999 ^ N > 99999)
{
    Console.WriteLine("Вариант 1. В числе не пять цифр!!!");
}
else if (digit1 == digit5 && digit2 == digit4)
{
    Console.WriteLine("Вариант 1. Число является полиндромом!!!");
}
else
{
    Console.WriteLine("Вариант 1. Это не полиндром :(");
}

// Вариант 2.
Console.Write("Вариант 2. Введите пятизначное число: ");
int A = Convert.ToInt32(Console.ReadLine());
A = Math.Abs(A);
string Z = Convert.ToString(A);
if (A < 9999 ^ A > 99999)
{
    Console.WriteLine("В числе не пять цифр!!!");
}
else if (Z[0] == Z[4] && Z[1] == Z[3])
{
    Console.WriteLine("Вариант 2. Число является полиндромом!!!");
}
else
{
    Console.WriteLine("Вариант 2. Это не полиндром :(");
}
