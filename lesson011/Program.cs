
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)   // void метод, это метод который ничего не возращает
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; //если вводить элемент которого нет в массиве, обозначение "-1" говорит о том что неверно введено значение
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            // break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; //создай новый массив в котором будет 10 элементов, изнчально будет заполнен нулями

FillArray(array);
// array[4] = 4;
// array[6] = 4;

PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 6); //то что нужно найти, если не будет такого элемента терминал это покажет в виде "-1"
Console.WriteLine(pos);


//метод заполнения массива void FillArray(array) и метод печати его на экран void PrintArray(array)