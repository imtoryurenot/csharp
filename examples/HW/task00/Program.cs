//Напишите программу, которая на вход принимает два числа и проверяет, является ли второе число квадратом первого.
//a = 5; b = 25 -> да 
//a = 2 b = 10 -> нет 
//a = 9; b = -3 -> нет 
//a = -3 b = 9 -> да

System.Console.WriteLine("enter the first number :");

string number1 = Console.ReadLine();
int a = Convert.ToInt32(number1);

System.Console.WriteLine("enter the second number :");

string number2 = Console.ReadLine();
int b = Convert.ToInt32(number2);

if (a * a == b)
{
    System.Console.WriteLine("yes");
}
else
{
    System.Console.WriteLine("no");
}  