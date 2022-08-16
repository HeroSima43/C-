// Задача 24. Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int cycle(int a)
{
    int sum = 0;
    for(int i = 1; i <= a; i++)
    {
        sum = sum + i;
    }
    return sum;
}

Console.Write("Введите число А: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма чисел от 1 до {number} равна {cycle(number)}");
