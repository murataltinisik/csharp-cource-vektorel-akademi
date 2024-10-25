string MyReplace(string input, string[] oldValues, string[] newValues)
{
    // Create empty string value, for return
    string value = string.Empty;
    
    // Get Input Characters
    char[] inputCharacters = input.ToCharArray();

    // Change old value to new value
    for (int i = 0; i < inputCharacters.Length; i++)
        for (int j = 0; j < oldValues.Length; j++)
            if (Convert.ToString(inputCharacters[i]) == oldValues[j])
                inputCharacters[i] = Convert.ToChar(newValues[j]);

    // New String inputCharacters
    value = new string(inputCharacters);
    
    // Return
    return value;
}

// Usage
string name = MyReplace("Mürat Altinisik", ["ı", "ş", "ü"], ["i", "s", "u"]);

// Write
Console.WriteLine(name);