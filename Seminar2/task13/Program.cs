// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100)
{
    Console.WriteLine("У числа нет третьей цифры!");
}
else
{
    string s = Convert.ToString(number);
    int third = int.Parse(s[2].ToString());
    Console.WriteLine($"Третья цифра числа: {third}");
}
