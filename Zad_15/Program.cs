// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


        Console.Clear();
        Console.Write(" Введите цифру от 1 до 7: ");
        int num = int.Parse(Console.ReadLine());
   
    if (num >= 1 && num <= 5) { Console.WriteLine (num + "->" + "Нет" ); }
       else if (num >= 6 && num <= 7)
       { Console.Write(num + "->" + " Ура! Выходной"); }
     else  
        { Console.Write(num + "->" + " Не верная цифра"); } 
     Console.ReadLine(); 