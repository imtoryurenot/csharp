// напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

int num = new Random().Next(10, 100);

    int lastDigit = num / 10;
    int firstDigit = num % 10;
    
        if (firstDigit > lastDigit || firstDigit < lastDigit)
        {
        System.Console.WriteLine($"{firstDigit} is the biggest digit of this random {num}");
        }
else
    {
    System.Console.WriteLine($"{lastDigit} is the biggest digit of this random {num}");
    }