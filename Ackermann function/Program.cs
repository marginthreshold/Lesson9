// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using static System.Console;
Clear();

WriteLine("Введите число m и n через пробел для расчета функции Аккермана ");
int[] parameters = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), Convert.ToInt32);

WriteLine(Ackermann(parameters[0],parameters[1]));

int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return Ackermann(m - 1, 1);
    return Ackermann(m-1, Ackermann(m,n-1));

}

