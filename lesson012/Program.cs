﻿// существует 4 вида функций(методов): 1) не принимают и не возвращ.
                                     //2) принимают и не возвращ.
                                     //3) не принимают но возвращ.
                                     //4) принимают и возвращ.
// 4 вид более распространенный

//Вид 1

/*void Method1()
{
    Console.WriteLine("Автор ....");
}

Method1();*/







//Вид 2

/*void Method2(string msg)
{
    Console.WriteLine(msg);
}

Method2(msg: "Текст сообщения");*/

/*void Method21(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;   //прибавление на 1 называют крементом, убавление на 1 декрементом.
    }
}

 Method21(msg: "Текст", count: 4);
 Method21(count: 4, msg: "Новый текст"); */


//Вид 3

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
//Console.WriteLine(year);

//Вид 4 

string Method4(int count, string text)  //переименовать символ/текст меняестя везде
{
    int i = 0;
    string result = String.Empty;   //пустая строка можно обозначить как ""

    while(i < count)
    {
        result = result + text;
        i++;
    }

    return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);