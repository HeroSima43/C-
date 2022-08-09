Console.Write("Введите число #1: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число #2: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int ostatok = numberA % numberB;
if (ostatok == 0)
{
    Console.WriteLine("Кратно!");
}
else
{
    Console.WriteLine($"Остаток от деления: {ostatok}");
}
