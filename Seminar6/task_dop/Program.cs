// Дополнительная задача на рекурсию
// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N. (использовать рекурсию)
// 4 -> 24
// 5 -> 120
int Factorial(int f)
{
    if (f <= 1) return 1;
 
    return f * Factorial(f - 1);
}
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Факториал числа {N} равен: {Factorial(N)}");
