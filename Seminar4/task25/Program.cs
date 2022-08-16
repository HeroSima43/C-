// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Использование Math.Pow и аналогов = незачёт
Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
int step = 1;
for (int count = 1; count <= B; count++)
{
    step = step * A;
}
Console.WriteLine($"Число {A} в степени {B} равно: {step}");
