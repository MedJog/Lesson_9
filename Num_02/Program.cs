// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число: ");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма {SumNumbers(M, N)}");



int SumNumbers(int number1, int number2)
{
    if (number1 == number2)
    {
        return number1;
    }
    if (number1 < number2)
    {
    return (number1 + SumNumbers(++number1, number2));
    }
    else
    {
    return (number2 + SumNumbers(number1, ++number2));
    }
} 
