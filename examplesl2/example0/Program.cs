int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2> result) result = arg2;
    if (arg3> result) result = arg3;
    return result;
}


int a1 = 1;
int b1 = 2;
int c1 = 3;

int a2 = 12;
int b2 = 21;
int c2 = 33;

int a3 = 13;
int b3 = 23467;
int c3 = 37;

//int max1 = Max(a1,b1,c1);
//int max2 = Max(a2,b2,c2);
//int max3 = Max(a3,b3,c3);
//int max = Max(max1, max2, max3);

int max = Max(
Max(a1,b1,c1),
Max(a2,b2,c2),
Max(a3,b3,c3));


Console.WriteLine(max); // max = имя переменной, а Max c большой команда

// int max = a1;
// if(b1 > max) max = b1;
// if(c1 > max) max = c1;

// if(a2 > max) max = a1;
// if(b2 > max) max = b2;
// if(c2 > max) max = c2;

// if(a3 > max) max = a3;
// if(b3 > max) max = b3;
//if(c3 > max) max = c3;
//Console.WriteLine(max); - хаотичный вариант, int (название переменное) = чему она равна.




