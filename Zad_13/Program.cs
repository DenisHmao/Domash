// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.Write(" Введите любое число: "); 
 
int ThirdDigit(int number)
  {
    int result = -1;
        if (number >= 100)
            {
                while (number > 999)
                {
                    number = number / 10;
                }
                result = number % 10;
            }
            return result; 
        }
int num = int.Parse(Console.ReadLine());

if (ThirdDigit(num) == -1)
Console.WriteLine(num + " -> " + "третьей цифры нет");
else
//Console.WriteLine($"Третья цифра {ThirdDigit(num)}");
Console.WriteLine(num + " -> " + ThirdDigit(num));