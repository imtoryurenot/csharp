//Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда 
//5 -> Пятница

System.Console.WriteLine ("enter number of the day of the week  :");

string value = Console.ReadLine();
int dayoftheweek = Convert.ToInt32(value);

if (dayoftheweek == 1)
{
    System.Console.WriteLine("monday");
}
if (dayoftheweek == 2)
{
    System.Console.WriteLine("tuesday");
}
if (dayoftheweek == 3)
{
    System.Console.WriteLine("wedensday");
}
if (dayoftheweek == 4)
{
    System.Console.WriteLine("thursday");
}
if (dayoftheweek == 5)
{
    System.Console.WriteLine("friday");
}
if (dayoftheweek == 6)
{
    System.Console.WriteLine("saturday");
}
if (dayoftheweek == 7)
{
    System.Console.WriteLine("sunday");
}
if (dayoftheweek < 1 || dayoftheweek > 8) 
{
    System.Console.WriteLine("there is no such day, sorry dude! u must be drunk");
}