// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 0;
if (N % 2 == 0)
{
   while (count < N)
{
    count = count + 2;
    Console.WriteLine(count);
} 
}
else
{
    while (count < N - 1)
    {
        count = count + 2;
        Console.WriteLine(count);
    }
}
