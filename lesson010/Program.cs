int[] array = { 11, 52, 86, 65, 85, 54, 65, 87 };

int n = array.Length;
int find = 65;  //номер из массива

int index = 0;

while (index < n)
{

    if (array[index] == find)
    {
        Console.WriteLine(index); //определяет индекс массива
        break; //прервать, найдет только 1 индекс в массиве
    }
        //index = index + 1
        index++;
}