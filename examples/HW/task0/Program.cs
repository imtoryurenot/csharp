// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

//Например:
//4 -> 16 
//-3 -> 9 
//-7 -> 49

System.Console.Write("enter the number >"); // show a hint on the screen
string inputString = Console.ReadLine();       //  this one is to get entered line from console
int value = Convert.ToInt32(inputString);     //   преобразуем к целому типу

int square = value * value;                 //     вычисляем квадрат числа
System.Console.WriteLine(square);          //      выводим его на экран (commant + alt + f = текст форматировать)