
int Max(int a, int b, int c);
{
    int result = a;
    if (b > result) result = b;
    if (c > result) result = c;
    return result;
}

//               0   1   2   3   4   5   6   7   8    номер массива
int[] array = { 21, 42, 63, 47, 55, 36, 77, 78, 29 };
// array[0] = 22;
// Console.WriteLine(array[0]);

int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8]));

Console.WriteLine(result);

