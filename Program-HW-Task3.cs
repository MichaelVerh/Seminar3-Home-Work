// Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите чило");
int Number=Convert.ToInt32(Console.ReadLine());
for (int i=1; i<=Number; i++)
{
    Console.WriteLine($"{i}^3={Math.Pow(i,3)}");
}