//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine($"A({n},{m}) = {AckermanFunction(n, m)}");

int AckermanFunction(int N, int M)
{
    if (N == 0)
    {
        return (M + 1);
    }
    else if ((N != 0 && M == 0))
    {
        return AckermanFunction(N - 1, 1);
    }
    else{
        return AckermanFunction(N - 1, AckermanFunction(N, M - 1));
    }
}