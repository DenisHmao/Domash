// создаем массив данных, из массива
Console.Clear();
string[] array1 = new string[5] {"12345", "привет", "кот", "лес", "грязь"};
string[] array2 = new string[array1.Length];

void SecondArray(string[] array1, string[] array2) //Если строка удовлетворяет условию кладем значение в новый массив
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}