// Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int f(int m, int n)
{
    Console.WriteLine($"{m},  {n}");
    if (m == 0)
        return n + 1;
    else if (n == 0)
    return f(m - 1, 1);

    return f(m - 1, f(m, n-1));
}

Console.Clear();
Console.Write("Введите первое число: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(f(m, n));

/*
f (2,3) ->  f (1, f(2,2))  
                  -> f (1, f(2,1))
                           -> f (1, f(2,0))
                                    -> f (1, 1) -> f(0, f(1,0)) 
                                                   = f(1,0) + 1     = 3
                                                     -> f(0, 1) = 2
*/
