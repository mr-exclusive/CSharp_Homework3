// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

Console.Write("Enter a positive integer: ");
int number = int.Parse(Console.ReadLine());

Console.Write($"{number} -> ");

for (int i = 1; i <= number; i++)
{
    if (i > 1) Console.Write(", ");

    Console.Write(Math.Pow(i, 3));
}