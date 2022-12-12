/* Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке
 от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
 */

int valueN = InputInitialData("Введите число N: ");
Console.WriteLine(PrintNumbers(valueN, 1));

string PrintNumbers(int start, int stop)
{
    if (start <= 0) return ("0");
    if (start == stop)
    {
        return start.ToString();
    }
    return ($"{start}{",",-3}{PrintNumbers(--start, stop)}");
}

int InputInitialData(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
