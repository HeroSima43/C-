// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int [] array = new int [6];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-9, 10);
}
Console.WriteLine('[' + string.Join(", ", array) + ']');
int sum = 0;
for (int j = 1; j < array.Length; j = j + 2)
{
    sum = sum + array[j];
}
Console.WriteLine($"Сумма элементов на нечетных позициях равна: {sum}");
