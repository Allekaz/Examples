Console.Clear();

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 23;
int b1 = 14;
int c1 = 56;
int a2 = 115;
int b2 = 24;
int c2 = 6500;
int a3 = 72;
int b3 = 5;
int c3 = 78;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);

int max = Max(
Max(a1, b1, c1), 
Max(a2, b2, c2), 
Max(a3, b3, c3));

Console.WriteLine(max);