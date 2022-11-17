// example1

void Method1()
{
    Console.WriteLine("by me");
}
Method1(); // - вызвать этот метод (обязательны скобки вот такие - () без них будет)


// example2

void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2("still me");


void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
    Console.WriteLine(msg);
    i++;
    }   
}
Method21(msg: "still me" , 4); // - текст который хотим увидеть и количество раз msg в данном случае это то что именно хотим отобразить
Method21(count: 4, msg: "new msg"); 

// далее идут методы, которые что-то возвращают, но ничего не принимают

//example3

int Method3() // обязательно должен быть тип данных (поэтому вместо войд инт)
{
    return DateTime.Now.Year;
}
int year = Method3(); // использовать индификатор переменной и через оператор присваивания положить нужное значение
// Console.WriteLine(year);

// что-то принимают, что-то возвращают

// example4

// string Method4(int count, string text) // string Method4() - возвращаем строку и передаем (int count, char c) - компануем ее каунт раз
// {
//     int i = 0;
//     string result = String.Empty; // кладем туда какое-то значение и в данном случае это пустая строка
   
// while (i < count)
//    {
// i++;
// result = result + text;
//     }
//     return result;
// }
// string res = Method4(10, "qe1qe2");
// Console.WriteLine(res);

// цикл счетчика - for (он все собирает в одном месте)

// for (int i = 0; i <10; i++)
// {
//    Console.WriteLine(i)
// }


string Method4(int count, string text) // string Method4() - возвращаем строку и передаем (int count, char c) - компануем ее каунт раз
{
    string result = String.Empty; // кладем туда какое-то значение и в данном случае это пустая строка
    for ( int i = 0;i < count; i++)  // инициализация счетчика; проверка условия; делается инкримент = увеличение счетчика
   {
    result = result + text;
    }
    return result;
}
string res = Method4(10, "q1");
Console.WriteLine(res);

// цикл в цикле
// for(int i = 0; i < 10; i++)
// {
// for(int j = 0; j < 10; j++)
// {
//     Console.WriteLine(i*j)
// }
// Console.WriteLine()
// }

 for (int i = 2;i <= 10; i++) //пока и меньше или равно 10 добавляй одно значение
 {
    for (int j = 2;j <= 10; j++) 
    {
        Console.WriteLine($"{i} * {j} = {i * j}"); // интерполяция строк
    }
    Console.WriteLine();
 }

// Работа с текстом
//Что значит “Дан текст”?.
// Что значит “черточками”?
// Какого алфавита?
// Маленькие буквы “к” заменить большими “К”, а большие “С” заменить маленькими “с”.
// Ясна ли задача?
 
 string text = "— Я думаю, — сказал князь, улыбаясь, — что, " 
             + "ежели бы вас послали вместо нашего милого Винценгероде, "
             + "вы бы взяли приступом согласие прусского короля. "
             + "Вы так красноречивы. Вы дадите мне чаю?";


// string s = "qwerty"
//             012
// s [3] // r 

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

// int lenght = text.Length;
// for (int i = 0; i < lenght; i++)
// {

//     if(text[i] == oldValue) result = result + $"{newValue}";
//     else result = result + $"{text[i]}";
// }

// return result;
// }

// string newText = Replace(text, ' ', '|');

// Console.WriteLine(newText);
// Console.WriteLine();

// newText = Replace(newText,  'к', 'К');
// Console.WriteLine(newText);

// newText = Replace(newText,  'а', 'V');
// Console.WriteLine(newText);

int [] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int [] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"{array [i]} ");
    
    }
    Console.WriteLine();
}

void SelectionSort(int [] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j; // - этот элемент кода только ищет максимальную позицию

        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array [minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);