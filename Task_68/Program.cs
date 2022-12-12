/* Задача 68: Напишите программу вычисления
 функции Аккермана с помощью рекурсии.
 Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

int valueM = InputInitialData("Задайте значение M: ");
int valueN = InputInitialData("Задайте значение N: ");
Console.WriteLine($"Сумма = {AkkermanFunction(valueM, valueN),3}");

int InputInitialData(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int AkkermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if ((m != 0) && (n == 0))
        return AkkermanFunction(m - 1, 1);
    else
        return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
}