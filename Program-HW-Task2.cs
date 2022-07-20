// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введите первую координату первого числа");
int AX=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую координату первого числа");
int AY=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третью координату первого числа");
int AZ=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первую координату второго числа");
int BX=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую координату второго числа");
int BY=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третью координату второго числа");
int BZ=Convert.ToInt32(Console.ReadLine());
double distance=Math.Sqrt(Math.Pow(AX-BX, 2)+Math.Pow(AY-BY, 2)+Math.Pow(AZ-BZ, 2));
Console.WriteLine($"Расстяние между точками в пространстве равно {distance}");