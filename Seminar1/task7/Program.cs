Console.Write("Введите трехзначное число: ");
int N = Convert.ToInt32(Console.ReadLine());
int A = N / 100;
int B = (N - (A * 100)) / 10;
int C = N - (A * 100  + B * 10);
Console.Write(C);
