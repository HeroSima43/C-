// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
string B = Convert.ToString(A);
int N = B.Length;
int sum = 0;
for (int i = 0; i < N; i++)
{
    sum = sum + int.Parse(B[i].ToString());
}
Console.WriteLine($"Сумма цифр в числе равна: {sum}");
