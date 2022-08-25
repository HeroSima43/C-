// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

void PrintBinary(int a)
{
    if (a <= 0)
    {
        return;
    }
    PrintBinary(a/2);
    Console.Write(a % 2);
}


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

PrintBinary(number);
