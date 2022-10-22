//Напишите программу, которая на вход принимает значение, а  на выходе показывает обратное значение.
//1 -> 1
//2 -> 0.5
//0.25 -> 4

System.Console.WriteLine("Enter the number");
string inputString = Console.ReadLine();
double Number = Convert.ToDouble(inputString );
double ReversNumber= 1/Number;
System.Console.WriteLine($"{ReversNumber:F2}"); // - вместо вот этого System.Console.WriteLine(ReversNumber); 
// формат вывода, округление. число после запятой будет иметь два знака

