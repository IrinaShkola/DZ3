// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.WriteLine("Введите координату x точки A");
double x1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату y точки A");
double y1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату z точки A");
double z1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату x точки B");
double x2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату y точки B");
double y2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату z точки B");
double z2 = Convert.ToInt32(Console.ReadLine());

double A = x2 - x1;
double B = y2 - y1;
double C = z1 - z2;
double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Длинна отрезка {length}");