/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

using System.Runtime.ExceptionServices;

System.Console.WriteLine("Введите первое число число");
int firstNum = Convert.ToInt32 (Console.ReadLine());

System.Console.WriteLine("Введите второе число");
int secondNum = Convert.ToInt32 (Console.ReadLine ());

if (firstNum > secondNum)
{
    System.Console.WriteLine(firstNum + ">" + secondNum);

}
else if (secondNum > firstNum)
{
    System.Console.WriteLine(secondNum + ">" + firstNum);

}
else
{
    System.Console.WriteLine(firstNum + "=" + secondNum);

}
