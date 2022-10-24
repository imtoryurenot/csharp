// напишите программу, которая на вход будет принимать два числа
// и выводить, является ли второе число кратным первому. если число 2 не кратно числу 1,
// то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
    int DivBy (int B, int A) // вычисляем остаток от деления В на А (2 / 4 = 0 целых и 2 в остатке)
    {
        return (B % A);
    }
       int A = Prompt("enter first number: ");
       int B = Prompt ("enter second number: ");

       if (DivBy (A, B) == 0)
       {
        Console.WriteLine ("tuple"); // кратно в мире IT
       }
else 
{
    Console.WriteLine (DivBy(A, B));
}
