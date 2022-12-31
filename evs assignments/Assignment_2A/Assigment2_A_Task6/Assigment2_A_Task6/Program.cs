Console.WriteLine("Enter String");
string? line = Console.ReadLine();
string[] words = line.Split(new[] { " " }, StringSplitOptions.None);
string word = "";
int ctr = 0;
foreach (String s in words)
{
    if (s.Length > ctr)
    {
        word = s;
        ctr = s.Length;
    }
}

Console.WriteLine(word);