// Напишите программу, которая принимает на вход трехзначное число, 
//а на выходе показывет показывает последнюю цифру этого числа.

// 456 -> 6
// 782 -> 2
// 918 -> 8

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool ValidateNumber(int number)
{
    if (number < 100 || number >= 1000)
    {
        Console.WriteLine("this number does not contain three digits");
        return false;
    }
    return true;
}

int number = Prompt("enter a three digit number: ");
if (ValidateNumber(number))
{
    int lastDigit = number % 10;
    number = Prompt($"last digit of {number} is {lastDigit}:");
}
