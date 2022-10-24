//Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int value = Prompt ("this programm is gonna help you to fint out if the number is divided by 2, enter your number>");

if (value % 2 == 0) // до этого стоял / и почему-то программа работала некорректно. странно
{
    System.Console.WriteLine($"bingo! {value} can be divided");
}

else
{
    System.Console.WriteLine($" nah! {value} can not be divided. choose another one :)");
}