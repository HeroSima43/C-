//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
N = Math.Abs(N);
int count = 1;
int sqr = 0;
while (count <= N)
{
    sqr = count * count * count;
    Console.WriteLine($"Куб числа {count} равен: {sqr}");
    count++;
}
