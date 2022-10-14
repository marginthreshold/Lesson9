// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using static System.Console;
Clear();

WriteLine("Введите число M и N через пробел");
int[] parameters = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), Convert.ToInt32);
WriteLine($"Сумма чисел между {parameters[0]} и {parameters[1]} равна: ");
WriteLine(SumBetweenTwoNumbers(parameters[0], parameters[1]));

int SumBetweenTwoNumbers(int max, int min)
{
    if (max == min) return min;
    else
        return max > min ? max + SumBetweenTwoNumbers(max - 1, min) : min + SumBetweenTwoNumbers(min - 1, max);
}









