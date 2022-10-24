//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

//System.Console.WriteLine("Hi! this programm is gonna help you to find max of those 3 numbers that you are gonna enter here, so please enter the first number:");

////int a = Convert.ToInt32(Console.ReadLine());

//System.Console.WriteLine("enter the second number:"); 

//int b = Convert.ToInt32(Console.ReadLine());

//System.Console.WriteLine("enter the third number:");

//int c = Convert.ToInt32(Console.ReadLine());

//int[] nums = {a, b, c};

///int findmax(){
// return nums.Max();
//}
//System.Console.WriteLine($"thats the biggest one is {findmax()}");


// АЛТЕРНАТИВНЫЙ ВАРИАНТ ТОГО ЖЕ КОДА

int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int numberA = Prompt("Hi! this programm is gonna help you to find max of those 3 numbers that you are gonna enter here, so please enter the first number");
int numberB = Prompt("enter the second number:");
int numberC = Prompt("enter the third number:");

int max = numberA;

if (numberB > max)
{
    max = numberB;
}
if (numberC > max)
{
    max = numberC;
}
System.Console.WriteLine($"thats the biggest one is {max}");