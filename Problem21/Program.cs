// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.WriteLine("Enter coordinates for point A: ");
Console.Write("x = ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("y = ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("z = ");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter coordinates for point B: ");
Console.Write("x = ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("y = ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("z = ");
int z2 = int.Parse(Console.ReadLine());

double distance = Math.Abs(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)));
Console.WriteLine("Distance between A and B: " + Math.Round(distance, 2));