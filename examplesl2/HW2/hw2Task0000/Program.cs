// Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет


Console.Write("hi! please enter the number >");

int number = Convert.ToInt32(Console.ReadLine());

if (number <1 || number >=8)
{
Console.WriteLine("thats an incorrect number, try again");
}
if (number <= 5)
{
    Console.WriteLine("thats not your day off. sorry dude");
}
else
{
     Console.WriteLine("yay thats your day off. you can chill now, dude");
}