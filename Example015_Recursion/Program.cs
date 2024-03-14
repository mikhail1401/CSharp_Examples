﻿// Рекрусивная фунцкия - это функция,
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


Console.WriteLine("Task 2");
// Собрать строку с числами от a до b, a>=b

// Without recursion
string NumbersFor2(int a, int b)
{
    string result = string.Empty;
    for (int i = a; i>=b; i--)
    {
        result += $"{i}";
    }
    return result;
}

string NumbersRec2(int a, int b)
{
        if (a>=b) return $"{a}" + NumbersRec2(a - 1, b);
        else return string.Empty;
}

Console.WriteLine(NumbersFor2(10, 1));
Console.WriteLine(NumbersRec2(10, 1));


Console.WriteLine("Task 3");
// Сумма чисел от 1 до n

// Regular solution
int SumFor(int n)
{
    int result = 0;
    for (int i = 1; i <= n; i++) result += i;
    return result;
}


// With recursion
int SumForRec(int n)
{
    if (n== 0) return 0;
    else return n + SumForRec(n-1);
}

Console.WriteLine(SumFor(4));
Console.WriteLine(SumForRec(4));