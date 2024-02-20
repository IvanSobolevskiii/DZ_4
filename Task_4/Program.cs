int CountingSpacesInLine (string str)
{
    int result = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] == ' ')
        {
            result++;
        }
    }
    return result;
}

string[] SplitString(string text, int CountSpaces)
{
    string [] result = new string[CountSpaces + 1];
    int TempIndex = 0;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] != ' ')
        {
            result[TempIndex] +=  text[i];
        }
        else
        {
            TempIndex++;
        }
    }
    return result;
}

string FlipStringArray (string[] StringArray)
{
    string result = string.Empty;
    for ( int i = 1; i < StringArray.Length + 1; i++ ) // Перебор массива со строками начиная с конца ^1 -> i = 1 | 1 < 3
    {
        result += $"{StringArray[^i]} ";
    }
    return result;
}



Console.Write("Введите текст с пробелами: ");
string text = Console.ReadLine();

string text2 = FlipStringArray(SplitString(text, CountingSpacesInLine(text)));

Console.WriteLine($"Итог: {text2}");