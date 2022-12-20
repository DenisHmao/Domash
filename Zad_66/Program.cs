// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N


Console.Clear();
Console.WriteLine("введите значение M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение N");
int n = Convert.ToInt32(Console.ReadLine());

int CalculateSum(int m, int n)
		{
			int start = m;
			int end = n;
			if(m > n)
			{
				start = n;
				end = m;
			}
			return (end + start)*(end - start + 1)/2;
		}
		Console.WriteLine(CalculateSum(m,n));