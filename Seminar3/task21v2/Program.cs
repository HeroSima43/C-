// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
int[] A = new int [3];
Console.Write("Введите координату X первой точки: ");
A[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y первой точки: ");
A[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z первой точки: ");
A[2] = Convert.ToInt32(Console.ReadLine());
int[] B = new int [3];
Console.Write("Введите координату X второй точки: ");
B[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y второй точки: ");
B[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z второй точки: ");
B[2] = Convert.ToInt32(Console.ReadLine());
double S = Math.Sqrt((A[0]-B[0])*(A[0]-B[0])+(A[1]-B[1])*(A[1]-B[1])+(A[2]-B[2])*(A[2]-B[2]));
Console.WriteLine($"Расстояние между точками ровно: {S}");
