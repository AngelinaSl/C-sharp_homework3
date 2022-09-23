/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
Console.Clear();
Console.WriteLine("Найдем расстояние между двумя точками.");
Console.Write("Введите первую координату точки А: ");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую координату точки А: ");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третью координату точки А: ");
int Z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую координату точки В: ");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую координату точки В: ");
int Y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третью координату точки В: ");
int Z2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Точка А ({X1},{Y1},{Z1}); Точка В ({X2},{Y2},{Z2}).");
double d = Math.Sqrt(Math.Pow((X2-X1), 2) + Math.Pow((Y2-Y1), 2) + Math.Pow((Z2 - Z1), 2));
Console.WriteLine($"Расстояние между точками = {Math.Round(d, 2)}.");