/* Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт
 сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
 */

int valueM = InputInitialData("Задайте значение M: ");
int valueN = InputInitialData("Задайте значение N: ");
Console.WriteLine($"Сумма  = {PrintSum(valueM, valueN), 5}");

int InputInitialData(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int PrintSum(int beginning, int end)
{
    if (end == beginning) return end;
    return beginning + PrintSum(beginning + 1, end);
}