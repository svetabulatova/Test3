// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату по x первой точки");
double x1=Convert.ToDouble (Console.ReadLine());
Console.WriteLine("Введите координату по у первой точки");
double y1=Convert.ToDouble (Console.ReadLine());
Console.WriteLine("Введите координату по z первой точки");
double z1= Convert.ToDouble (Console.ReadLine());
Console.WriteLine("Введите координату по x второй точки");
double x2=Convert.ToDouble (Console.ReadLine());
Console.WriteLine("Введите координату по у второй точки");
double y2=Convert.ToDouble (Console.ReadLine());
Console.WriteLine("Введите координату по z второй точки");
double z2= Convert.ToDouble (Console.ReadLine());

double res=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
Console.WriteLine($"{res:f2}");