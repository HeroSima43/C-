// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
int [] array = new int [6];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-9, 10);
}
Console.WriteLine('[' + string.Join(", ", array) + ']');
for (int j = 0; j < array.Length; j++)
{
    if (array[j] > 0)
    {
        array[j] = - array[j];
    }
    else if (array[j] < 0)
    {
        array[j] = Math.Abs(array[j]);
    }
}
Console.WriteLine('[' + string.Join(", ", array) + ']');
