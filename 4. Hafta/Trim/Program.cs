string MyTrim(string input)
{
    // Create numberOfSpace 
    int numberOfSpace = 0;
    
    // Create new string referance
    string newString = String.Empty;

    for (int i = 0; i < input.Length; i++)
    {
        // Get Ascii code "space" keywords
        int ascii = input[i];
        
        // Check is value "space" character.
        if (ascii == 32)
        {
            numberOfSpace++;
            if (numberOfSpace == 1) newString += (char)ascii;
        }
        else
        {
            numberOfSpace = 0;
            newString += (char)ascii;
        }
    }
        
    // Return New String
    return newString;
}

// Usage
string text = MyTrim("        MURAT ALTINIŞIK             ");

// Write
Console.Write(text);