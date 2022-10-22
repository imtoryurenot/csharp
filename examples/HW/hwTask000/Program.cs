//Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("this programm is gonna help you to fint out if the number is divided by 2, enter your number>");

int a = Convert.ToInt32(Console.ReadLine());

if (a %2 == 0) // до этого стоял / и почему-то программа работала некорректно. странно
{
    System.Console.WriteLine("it can be divided");
}

else
{
    System.Console.WriteLine("it can not be divided. choose another one :)");
}