// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();
int chislo(string str)
{
    Console.Write(str);
    return Convert.ToInt32(Console.ReadLine());
}

int num = chislo("Введите число: ");

for (int i = 1; i <= num; i++)
{
    Console.Write($"{i * i * i} ");
}
