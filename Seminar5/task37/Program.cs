// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
int [] array = new int [7];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-9, 10);
}
Console.WriteLine('[' + string.Join(", ", array) + ']');
int l2 = 0;
if (array.Length % 2 == 0)
{
    l2 = array.Length / 2;
}
else
{
    l2 = array.Length / 2 + 1;
}
int [] array2 = new int [l2];

int x = 0;
int y = array.Length - 1;
int A = array[x];
int Z = array[y];
if (array.Length % 2 == 0)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        array2[i] = A * Z;
        A = array[x + (i + 1)];
        Z = array[y - (i + 1)];
    }
}
else
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        array2[i] = A * Z;
        A = array[x + (i + 1)];
        Z = array[y - (i + 1)];
    }
    array2[array.Length / 2] = array[array.Length / 2];
}
Console.WriteLine('[' + string.Join(", ", array2) + ']');
