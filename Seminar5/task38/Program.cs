// Задача 38: Задайте с клавиатуры массив вещественных (double) чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Console.Write("Введите количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());
double [] array = new double [N];
for (int i = 0; i < N; i++)
{
    Console.Write($"Введите значение {i}-го элемента массива: ");
    array[i] = Convert.ToDouble(Console.ReadLine());
}
Console.WriteLine("Заданный массив: " + '[' + string.Join(", ", array) + ']');
double max = array[0];
for (int j = 1; j < N; j++)
{
    if (array[j] > max)
    {
        max = array[j];
    }
}
Console.Write($"Значение максимального элемента массива: {max}");
double min = array[0];
for (int j = 1; j < N; j++)
{
    if (array[j] < min)
    {
        min = array[j];
    }
}
Console.WriteLine();
Console.Write($"Значение минимального элемента массива: {min}");
Console.WriteLine();
Console.Write($"Разнима между максимальным и минимальным элементами массива составляет: {max - min}");
