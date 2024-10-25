bool MyStartsWith(string input, char s)
{
    if (input[0] == s) return true;

    return false;
}

// Usage
string name = "Murat Altınışık";

// Write
Console.WriteLine(name);
Console.WriteLine(MyStartsWith(name, 'M'));
Console.WriteLine(MyStartsWith(name, 'Y'));
