//Напишите программу, которая выводит случайное трёхзначное число и удаляет 
//вторую цифру этого числа. Не использовать строки для расчета.
//456 -> 46 
//782 -> 72
//918 -> 98

int num = new Random().Next(100, 1000);

System.Console.WriteLine(num);

int res = (num / 100) * 10 + (num % 10); // очень долго сидела с этой задачей по какой-то причине -_- (стоит математику подучить побольше, да?)
{
    System.Console.WriteLine($" {num} and here is your random number without second digit {res}");
}