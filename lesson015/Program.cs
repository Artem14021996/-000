//=====Работа с текстом
// дан текст. в тексте все пробелы нужно заменить черточками,
// маленькие буквы "к" нужно заменить большими "К",
// а большие "С" заменить маленькими "с".

string text = "- я думаю, - сказл князь, улыбаясь, - что,"
            + "ежели бы вас послали вместо нашего милого Винценгороде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так крассоречивы. Вы дадите мне чаю?";

//string s = "qwerty"
//            012345
// s[3]  //  r

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;

    int length = text.Length;
    for(int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);
