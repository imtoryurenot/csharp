// Напишите программу вычисления модуля числа.

Console.Write("Please type the number >");

int number = int.Parse(Console.ReadLine());

int mod = number;

if (number<0)
{
    mod = -number;
}
Console.WriteLine($"{mod} is you module of {number}"); //$"{mod} - просто другая версия (mod + " is your module bitch")

