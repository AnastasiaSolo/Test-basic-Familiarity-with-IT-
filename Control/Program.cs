string[] word = { "Hello", "how", "are", "you", };
for (int i = 0; i < word.Length; i++)
    Console.WriteLine(word[i]);
Console.WriteLine("____________________");

var result = new string[word.Length];
var Size = 0;
foreach (var value in word)
{
    if (value.Length <= 3)
    {
        result[Size] = value;
        Size++;
    }
}

Console.WriteLine(string.Join(Environment.NewLine, result, 0, Size));
