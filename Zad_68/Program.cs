// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Clear();
Console.WriteLine("введите 2 или 3");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите 3 или 2");
int n = Convert.ToInt32(Console.ReadLine());
AkkermanFunction(m,n);

void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n) + "->"+" С наступающим Новым Годом!!! "); 
}

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}
Console.WriteLine();