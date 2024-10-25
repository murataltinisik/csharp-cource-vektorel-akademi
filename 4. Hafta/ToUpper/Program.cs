
// To Upper
string MyToUpper(string text)
{
    string newString = "";

    for (int i = 0; i < text.Length; i++)
    {
        // Get Ascii code
        int ascii = text[i];

        // Is lower character to get, if not, convert to upper character
        if (ascii >= 97 && ascii <= 122) ascii = ascii - 32;

        // Add new String
        newString += (char)ascii;
    }

    return newString;
}

// Usage
string text = MyToUpper("Murat Altınışık");

// Write
Console.Write(text);