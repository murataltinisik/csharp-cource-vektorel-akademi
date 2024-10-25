
// To Upper
string MyToUpper(string text)
{
    string newString = "";

    for (int i = 0; i < text.Length; i++)
    {
        // Get Ascii code
        int ascii = text[i];

        // Is upper character to get, if not, convert to lower character
        if (ascii >= 65 && ascii <= 90) ascii = ascii + 32;

        // Add new String
        newString += (char)ascii;
    }

    return newString;
}

// Usage
string text = MyToUpper("MURAT ALTINIŞIK");

// Write
Console.Write(text);