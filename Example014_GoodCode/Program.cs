using System.Linq;

// How to write good code

// Don't repeat youself
// You won't need it
// Keep it simple, stupid

// Use libraries like System.Linq on top:

string text = "(1,2) (2,3) (4,5) (6,7)"
                .Replace("(", "")
                .Replace(")", "");

var data = text.Split(" ")
            .ToArray();

for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);
}
