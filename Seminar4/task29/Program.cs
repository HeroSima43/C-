// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
int N = 8;
int[] array = new int [N];
for (int i = 0; i < N; i++)
{
    Console.Write($"Ввод {i}-го элемента массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Вывод элементов массива: [");
for (int j = 0; j < N - 1; j++)
{
    Console.Write($"{array[j]}" + ", ");
}
Console.Write($"{array[N - 1]}" + "]");
