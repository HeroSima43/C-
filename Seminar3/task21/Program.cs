// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
int[] A = new int [2];
Console.Write("Введите координату X первой точки: ");
A[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y первой точки: ");
A[1] = Convert.ToInt32(Console.ReadLine());
int[] B = new int [2];
Console.Write("Введите координату X второй точки: ");
B[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y второй точки: ");
B[1] = Convert.ToInt32(Console.ReadLine());
double S = Math.Sqrt((A[0]-B[0])*(A[0]-B[0])+(A[1]-B[1])*(A[1]-B[1]));
Console.WriteLine($"Расстояние между точками ровно: {S}");
