// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();
Console.WriteLine("введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[m, n];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

for (int i = 0; i < numbers.GetLength(1); i++)
{
    double avarage = 0;
    for (int j = 0; j < numbers.GetLength(0); j++)
    {
        avarage = (avarage + numbers[j,i]);
    }
    avarage = avarage / m;
    Console.WriteLine("Среднее арифметическое столбца:" + avarage + "; ");
}
Console.WriteLine();

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 9);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}