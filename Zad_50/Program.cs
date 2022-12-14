// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();
Console.WriteLine("позиция в строке");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("позиция в столбце");
int n = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[9, 9];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

if (m > numbers.GetLength(0) || n > numbers.GetLength(1))
{
    Console.WriteLine("такого числа в массиве нет");
}
else
{
    Console.WriteLine($"значение элемента {m} строки и {n} столбца равно {numbers[m - 1, n - 1]}");
}


void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
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
