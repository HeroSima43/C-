// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
Console.Write("Введите количество элементов массива: ");
int i = Convert.ToInt32(Console.ReadLine());
int[] array = new int [i];
Random Z = new Random();
for (int count = 0; count < i; count++)
{
    array[count] = Convert.ToInt32(Z.Next(0, 2));
    Console.Write(array[count] + ", ");
}
