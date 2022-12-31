//5.Write a console application to take a string as input and count number of letters,
//digits & punctuation marks in it
Console.WriteLine("Program to count of letter, digit and special characters");
Console.WriteLine("Enter String");
string str=Console.ReadLine();
int totalCharacter = 0, totalLetterChar = 0, totalDigitChar = 0, totalSpecialChar = 0;

char[] strArray = str.ToCharArray();
foreach (var item in strArray)
{
    if (char.IsDigit(item))
        totalDigitChar++;
    if (char.IsLetter(item))
        totalLetterChar++;
    if (!char.IsLetterOrDigit(item))
        totalSpecialChar++;
    totalCharacter++;
}

Console.WriteLine("--------------------------------------------------------");
Console.WriteLine($"Entered String : {str}") ;
Console.WriteLine("--------------------------------------------------------");
Console.WriteLine($"Total Characters In String : {totalCharacter}");
Console.WriteLine($"Total Letter Character String : {totalLetterChar}");
Console.WriteLine($"Total Digit Character String : { totalDigitChar}");
Console.WriteLine($"Total Special Character String : {totalSpecialChar}");
Console.WriteLine("--------------------------------------------------------");
Console.ReadKey();