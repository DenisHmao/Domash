// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Clear();
int chislo(string str)
{
    Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = chislo("Введите координату X первой точки: ");
int y1 = chislo("Введите координату Y первой точки: ");
int z1 = chislo("Введите координату Z первой точки: ");
int x2 = chislo("Введите координату X второй точки: ");
int y2 = chislo("Введите координату Y второй точки: ");
int z2 = chislo("Введите координату Z второй точки: ");

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Расстояние: = {length}");

