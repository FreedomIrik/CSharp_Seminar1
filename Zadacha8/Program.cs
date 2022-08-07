/* Задача 8: Напишите программу, которая на вход принимает число
(N), а на выходе показывает все чётные числа от 1 до N.*/

Console.Write("Введите положительное число N: ");

int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    System.Console.WriteLine("Ошибка: Введенное число отрицательное");
}

int runNumber = number / number;

while (runNumber <= number)
{
    System.Console.WriteLine(runNumber);
    runNumber++;
}