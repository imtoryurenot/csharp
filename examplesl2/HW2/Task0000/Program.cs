// напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23

// 46 -> нет
// 161 -> да

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
    bool DivBy (int number)
    {
        return (number % 7 == 0) && (number % 23 == 0); // поверили делится ли на 7 без остатка и делится ли на 23 без остатка с помощью == 0
    }

    int number = Prompt("enter your number:");
   if (DivBy (number))
   {
    Console.WriteLine("yes");
   } 
   else
   {
    Console.WriteLine("no :c");
   }