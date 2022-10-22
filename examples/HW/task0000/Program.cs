//3. Напишите программу вычисления функции:
// x = f(a)

// -______________________-

// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке 
//от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

System.Console.Write("enter your number > ");
int value = Convert.ToInt32(Console.ReadLine());

int count = value * -1;

while (count <= value)
{
    System.Console.Write(count + ", ");
    count++;
}