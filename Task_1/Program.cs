string CreateStringFromChar(char[,] CharArr)
{
    string result = string.Empty;
    for (int i = 0; i < CharArr.GetLength(0); i++)
    {
        for (int j = 0; j < CharArr.GetLength(1); j++)
        {
            result += CharArr[i,j];
        }
    }
    return result;
}

void PrintCharArray(char[,] CharArr)
{
    for (int i = 0; i < CharArr.GetLength(0); i++)
    {
        for (int j = 0; j < CharArr.GetLength(1); j++)
        {
            Console.Write($"{CharArr[i,j]}  ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
char[,] CharArray = {{'a','b','c'},{'f','g','l'}};
Console.WriteLine("Массив:");
PrintCharArray(CharArray);

Console.WriteLine($"\nСтрока: {CreateStringFromChar(CharArray)}");