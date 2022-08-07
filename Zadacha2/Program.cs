/* Задача 2: Напишите программу, которая на вход принимает два числа 
и выдаёт, какое число большее, а какое меньшее*/

Console.WriteLine("Введите число №1");

int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число №2");

int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
   Console.WriteLine("Число №1 {0} максимальное, число №2 {1} минимальное", number1 , number2);
   
}
else
Console.WriteLine("Число №1 {0} минимальное, число №2 {1} максимальное", number1 , number2);
