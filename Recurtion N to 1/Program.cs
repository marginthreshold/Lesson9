// В решении задач ОБЯЗАТЕЛЬНОЕ использование рекурсии!
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


using static System.Console;
Clear();

WriteLine("Введите число N");
int top = int.Parse(ReadLine()!);
Descending(top);


void Descending(int max)
{
    if (max == 0) return;
    else
    Write($"{max} ");
    Descending(max - 1);

}
