Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = -N;
while (count <= N)
{
    Console.Write(" ");
    Console.Write(count);
    count = count + 1;
}