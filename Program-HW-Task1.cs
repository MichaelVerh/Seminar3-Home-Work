// Напишите программу, которая принимает на вход пятизначное число и проверяет является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число");
String Number=Console.ReadLine();
if (Number.Length==5)
{   if (Number[0]==Number[4] && Number[1]==Number[3])
    {
        Console.WriteLine($"Число {Number} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {Number} не является палиндромом");
    }
}
else
{
    Console.WriteLine("Неверный ввод");
}    