// Get Values
Console.Write("Sayısal Bir Değer Giriniz: ");
bool isNumber = int.TryParse(Console.ReadLine(), out int number);

// Is value numbered
if (!isNumber)
{
    Console.WriteLine("Geçerli bir değer giriniz!");
    return;
}

// Is value between 1 and 3999
if (!(number >= 1 && number <= 3999))
{
    Console.WriteLine("Girilen değer 1 ila 3999 arasında olmalıdır");
    return;
}

// Roman Numerals
string[] thousands = { "", "M", "MM", "MMM" };
string[] ones = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
string[] tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
string[] hundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };

// Result
string result = thousands[number / 1000]
                + hundreds[(number % 1000) / 100]
                + tens[(number % 100) / 10]
                + ones[number % 10];

// Finish Result
Console.WriteLine(result);