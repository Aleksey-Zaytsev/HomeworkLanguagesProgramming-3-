// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

Console.Write("Введите координату Х первой точки: ");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y первой точки: ");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z первой точки: ");
int Z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Х второй точки: ");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y второй точки: ");
int Y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z второй точки: ");
int Z2 = Convert.ToInt32(Console.ReadLine());
double result = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2) + Math.Pow(Z2 - Z1, 2));
Console.Write ("Расстояние между этими точками в 3D пространстве равно: ");
Console.Write(Math.Round(result, 2));