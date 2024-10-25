string MySubstring(string input, int start, int length)
{
    // Create New String
    string newString = String.Empty;
    
    // Loop
    for (int i = start, j = 0; i < input.Length; i++, j++)
    {
        newString += input[i];
        if (j == length) break;
    }

    return newString;
}

// Usage
string text = MySubstring("Murat Altınışık", 5, 7);

// Write
Console.WriteLine(text);    