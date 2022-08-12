// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
N = Math.Abs(N);
int count = 1;
int sqr = 0;
while (count <= N)
{
    sqr = count * count;
    Console.WriteLine($"Квадрат числа {count} равен: {sqr}");
    count++;
}
