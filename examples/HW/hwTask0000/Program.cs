//Задача 4: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

System.Console.Write("enter your number > ");
int b = Convert.ToInt32(Console.ReadLine());

int start = 0;

while (start < b-1)
{
    System.Console.Write($"{start = start+2}" + (",")); // не понимаю, почему повялвяется двойная запятая
}
