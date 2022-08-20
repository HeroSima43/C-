// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да
int [] array = new int [6];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-9, 10);
}
Console.WriteLine('[' + string.Join(", ", array) + ']');
Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
int Z = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == A)
    {
        Z++;
    }
}
if (Z > 0)
{
    Console.WriteLine($"Число {A} присутствует в массиве!");
}
else
{
    Console.WriteLine($"Числа {A} в массиве нет!");
}
