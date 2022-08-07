/*Задача 6: Напишите программу, которая на вход принимает число 
и выдаёт, является ли число чётным */

Console.WriteLine("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());

if(number%2 == 0)
{
    System.Console.WriteLine("Число {0} четное", number);
}
else
System.Console.WriteLine("Число {0} нечетное", number);