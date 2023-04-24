// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число: ");
int Number = int.Parse(Console.ReadLine());
WriteNumbers(Number, 1);
Console.WriteLine();
void WriteNumbers(int Num, int num)
{
     if (Num >= num)
{
     Console.Write($"{Num} ");
     Num--;
     WriteNumbers(Num, num);
}
} 
