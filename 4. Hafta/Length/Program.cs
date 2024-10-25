string text = "Murat Altınışık";

// Length Method
int MyLength(string text)
{
    int counter = 0;

    for (int i = 0; ; i++)
    {
        try
        {
            char c = text[i];
            counter++;
        }
        catch (IndexOutOfRangeException)
        {
            break;
        }
    }

    return counter;
}