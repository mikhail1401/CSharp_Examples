// Рекрусивная фунцкия - это функция,
// вызывающая сама себя

// Самое важно - описать условие выхода!

Console.WriteLine("Task 1");
// Собрать строку с числами от a до b, a<=b;

// Without recursion
string NumbersFor(int a, int b)
{
    string result = string.Empty;
    for (int i = a; i<=b; i++)
    {
        result += $"{i}";
    }
    return result;
}

// With recursion
string NumbersRec(int a, int b)
{
    if (a<=b) return $"{a}" + NumbersRec(a + 1, b);
    else return string.Empty;
}

Console.WriteLine(NumbersFor(1, 10)); // 1 2 3 4 5 6 7 8 9 10
Console.WriteLine(NumbersRec(1, 10)); // 1 2 3 4 5 6 7 8 9 10


Console.WriteLine("\nTask 2");
// Собрать строку с числами от a до b, a>=b

// Without recursion
string NumbersFor2(int a, int b)
{
    string result = string.Empty;
    for (int i = a; i>=b; i--)
    {
        result `;= $"{i}";
    }
    return result;
}

string NumbersRec2(int a, int b)
{
        if (a<=b) return NumbersRec(a+1, b) + $"{a}";
        else return string.Empty;
}

Console.WriteLine(NumbersFor2(1, 10));
Console.WriteLine(NumbersRec2(1, 10));