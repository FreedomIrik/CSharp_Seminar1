/*
Напиcать программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя)

Написать программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго

Написать программу, которая на вход принимает одно число (N),
а на выходе порказывает все числа в промежутке от -N до N

*/


Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

int negativeNumber = number * (-1);

while (negativeNumber <= number)
{
    System.Console.WriteLine(negativeNumber);
    negativeNumber++;
}
