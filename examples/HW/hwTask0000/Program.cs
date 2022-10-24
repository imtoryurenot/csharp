//Задача 4: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

int Prompt(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int value = Prompt ("enter your number");
int num = 2;

while (value < 1)
{
        value = Prompt("nonono try again");
}

if (value == 1)
{
    Console.WriteLine("nonono try again");
}
else
{
while (value >= num)
    {
    value = Prompt($", {num}");
    num = num + 2;
    }
}