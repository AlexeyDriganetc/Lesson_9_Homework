// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int f(int m, int n)
{
    if (m == n)
        return n;
    return f(m, n - 1) + n;
}

Console.Clear();
Console.Write("Введите начальное число: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите конечное число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(f(m, n));

/*           f(3,8) + 8 
              f(3,7)  + 7 
               f(3,6)  + 6 
                 f(3,5)  + 5
                  f(3,4)  + 4 
                    f(3,3)  + 3 
                      n

*/