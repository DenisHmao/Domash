﻿// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Введите длинну масива  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
RandomNum(numbers);
Console.WriteLine("массив: ");
PrintArray(numbers);
int sum = 0;

for (int x = 0; x < numbers.Length; x+=2)
    sum += numbers[x];

   Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов cтоящих на нечётных позициях = {sum}");

void RandomNum(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10);
        }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}