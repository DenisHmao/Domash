// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
string num = Console.ReadLine();
int len = num.Length;

if (len == 5)
{
    if (num[0] == num[4] && num[1] == num[3])
    {
        Console.WriteLine(num + "-> " + "Да");
    }
    else
    {
        Console.WriteLine(num + "-> " + "нет");
    }
}
else
{
    Console.WriteLine(num + "-> " + "Введи 5 чисел");
}