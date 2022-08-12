// Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
Console.Write("Введите номер четверти: ");
int A = Convert.ToInt32(Console.ReadLine());
if (A == 1)
{
    Console.WriteLine("X > 0, Y > 0.");
}
else if (A == 2)
{
    Console.WriteLine("X < 0, Y > 0.");
}
else if (A == 3)
{
    Console.WriteLine("X < 0, Y < 0.");
}
else if (A == 4)
{
    Console.WriteLine("X > 0, Y <0.");
}
else
{
    Console.WriteLine("Вы ввели несуществующую четверть.");
}
