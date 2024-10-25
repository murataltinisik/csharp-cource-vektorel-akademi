bool MyEndsWith(string input, char s)
{
    if (input[input.Length - 1] == s) return true;

    return false;
}

// Usage
string name = "Murat Altınışık";

// Write
Console.WriteLine(name);
Console.WriteLine(MyEndsWith(name, 'k'));
Console.WriteLine(MyEndsWith(name, 'm'));
