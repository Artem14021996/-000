// Двумерные массивы
// string [,] table = new string[2,3]; таблица чисел.
// int[,] matrix = new int[5,8]; первой указывать 5 - строки, второй указывать 8 - столбцы.


//индекс с 0
string[,] table = new string[3, 4];
//String.Empty - константа нумерации строк
// table[0,0]  table[0,1]  table[0,2]  table[0,3]  table[0,4] и так далее нумерация столбцов

// table[1,0]  table[1,1]  table[1,2]  table[1,3]  table[1,4] и так далее нумерация строк

// table[1, 2] = "слово";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }




void PrintArray(int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
    Console.WriteLine();
    } 
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)  //matr.GetLength(0) - количество строк
    {
        for (int j = 0; j < matr.GetLength(1); j++)  //matr.GetLength(1) - колочество столбцов
        {
            matr[i,j] = new Random().Next(1, 10);// [1, 10) - полуинтервал
        }
    }
}
int[,] matrix = new int[3,4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);