Console.Clear();
Console.Write(" Введите 3-х значное число: "); 
int first = int.Parse(Console.ReadLine());
int result = (first /10 % 10);
Console.WriteLine(first + "->" + result); 