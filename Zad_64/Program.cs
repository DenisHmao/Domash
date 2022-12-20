//  Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Clear();
Console.WriteLine("введите значение N");
int m = Convert.ToInt32(Console.ReadLine());
int n = 1;
		void PrintInterval(int m, int n)
		{
			int start = m;
			int end = n;
			if(m > n)
			{
				start = n;
                end = m;
			}
			for(int i = end; i >= start; i--)
			{
				Console.Write($"{i} ");
			}
		}
		PrintInterval(m, n);
	Console.WriteLine();
		
		