// Задача 46. Задайте двумерный массив размеров m*n, заполненный случайными целыми числами.
// m=3, n=4.
// 1 4 8 9
// 5 -2 33 -2
// 77 3 8 1
Console.WriteLine("Задайте двумерный массив m x n");
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
