// Дополнительная задача (необязательная)
// Задача 28*: Напишите программу, в которой задается массив чисел(ввод может быть с клавиатуры, либо можете сами задавать массив чисел) и выдаёт произведение чисел от 1 до N, каждого элемента этого массива.
// {2, 3, 4} -> 2, 6, 24
// {5, 3, 6, 2, 5, 1} -> 6, 720, 2, 120, 1
Console.Write("Введите количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int [N];
for (int i = 0; i < N; i++)
{
    Console.Write($"Ввод {i}-го элемента массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
int pro = 0;
int Factorial(int f)
{
    if (f == 1) return 1;
 
    return f * Factorial(f - 1);
}
for (int j = 0; j < N; j++)
{
    pro = Factorial(array[j]);
    Console.WriteLine($"Элемент с индексом {j}. Произведение чисел от 1 до {array[j]} равно: {pro}");
}
