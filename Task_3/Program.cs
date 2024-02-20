bool Palindrom(string str)
{
    string temp = string.Empty;
    for ( int i = str.Length - 1; i >= 0; i--)
    {
        temp += str[i];
    }
    if (temp == str)
    {
        return true;
    }
    return false;
}

Console.Write("Введите текст: ");
string TextFromConsole = Console.ReadLine();
bool Paldrom = Palindrom(TextFromConsole);
if (Paldrom)
{
    Console.WriteLine($"Строка является палиндромом");
}
else 
{
    Console.WriteLine($"Строка не является палиндромом");
}