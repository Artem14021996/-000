// See https://aka.ms/new-console-template for more information

// string Method4(int count, string text)  //переименовать символ/текст меняестя везде
// {
//     int i = 0;
//     string result = String.Empty;   //пустая строка можно обозначить как ""

//     while(i < count)
//     {
//         result = result + text;
//         i++;
//     }

//     return result;
// }

// string res = Method4(10, "z");
// Console.WriteLine(res);

string Method4(int count, string text)  //переименовать символ/текст меняестя везде
{
   
    string result = String.Empty;   //пустая строка можно обозначить как ""
    for(int i = 0; i < count; i++)  //в счетчике [for] можно собрать все вместе формула получается короче и красивее
    {
        result = result + text;
    }

    return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);
