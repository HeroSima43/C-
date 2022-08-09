Console.Write("Введите число #1: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число #2: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int sqrA = numberA * numberA;
int sqrB = numberB * numberB;
if (numberA == sqrB ^ numberB == sqrA)
{
    Console.WriteLine("ДА!");
}
else
{
    Console.WriteLine("Нет");
}
