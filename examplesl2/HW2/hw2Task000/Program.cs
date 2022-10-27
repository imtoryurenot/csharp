// Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать строки для расчета.
// 645 -> 5
// 78 -> третьей цифры нет
// 326792 -> 6

Console.WriteLine("enter your number:"); 
    int number = int.Parse(Console.ReadLine()); // - целое число  
    int temp = number; 
    int capacity = 0; 
 
while (temp > 0) 
    { 
        temp = (temp / 10); // уменьшаем разрядность (1000 в 100; 100 в 10; 10 в 0) 
        capacity++; 
    }
if (capacity >3) 
{
    temp = 10;
    for (int i=1; i<capacity - 3; i++)
    {
        temp = temp * 10;
    }
    Console.WriteLine(temp); // на столько будем делить
    temp = number / temp;
    Console.WriteLine(temp); // получим первые три цифры
    temp = temp % 10;
    Console.WriteLine(temp); // а это последняя цифра из трех, ее и надо вывести

}
else
{
    Console.WriteLine("there is no 3rd digit in this number");    
}
