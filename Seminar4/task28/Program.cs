// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int Cycle(int a = 1)
{   
    int pro = 1;
    for (int i = 1; i <= a; i++)
    {
        pro = pro * i;
    }
    return pro;
}

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Произведение чисел от 1 до {N} равно {Cycle(N)}");
