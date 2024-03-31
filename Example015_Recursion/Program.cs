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

// Using recursion
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

// Using recursion
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

Console.WriteLine(SumFor(4));      // 10
Console.WriteLine(SumForRec(4));   // 10


Console.WriteLine("Task 4");
// Факториал числа

// Regular solution
int FactorialFor(int n)
{
    int result = 1;
    for (int i=1; i<=n; i++) result *= i;
    return result;
}

// Using recursion
int FactorialForRec(int n)
{
    if (n == 1) return n;
    else return n * (FactorialForRec(n - 1));
}

Console.WriteLine(FactorialFor(4));     // 24
Console.WriteLine(FactorialForRec(4));  // 24


Console.WriteLine("Task 5");
// Вычислить a^n

// Regular solution
int PowerFor(int a, int n)
{
    int result = 1;
    for (int i=1; i<=n; i++) result*=a;
    return result;
}

// Using recursion
int PowerForRec(int a, int n)
{
    return n == 0 ? 1 : PowerForRec(a, n-1) * a;
    // if (n==0) return 1;
    // else return PowerForRec(a, n-1) * a;
}

// Mathematically enhanced recursion solution
int PowerForRecMath(int a, int n)
{
    if (n==0) return 1;
    else if (n%2 == 0) return PowerForRecMath(a*a, n/2);
    else return PowerForRecMath(a, n-1) * a;
}

Console.WriteLine(PowerFor(2, 4));          // 16
Console.WriteLine(PowerForRec(2, 4));       // 16
Console.WriteLine(PowerForRecMath(2, 4));   // 16


Console.WriteLine("Task 6");
// Перебор слов 
// В некотором машинном алфавите имеются четыре бувы
// "а", "и", "с", и "в". Покажите все слова,
// состоящие из Т букв, которые можно построить из букв
// этого алфавита.


// Regular solution
void FindWords()
{
    char[] letters = {'a', 'b', 'c', 'd'};

    int count = letters.Length;

    int n=1;

    for (int i=0; i<count; i++)
    {
        for (int j=0; j<count; j++)
        {
            for (int k=0; k<count; k++)
            {
                for (int l=0; l<count; l++)
                {
                    for (int m=0; m<count; m++)
                    {
                        Console.WriteLine($"{n++, -5}{letters[i]}{letters[j]}{letters[k]}{letters[l]}{letters[m]}");
                                            // "-5" is a formatting specifier which specifies the minimum width of the output.
                                            // "-" means left alignment and spaces to the right
                                            // "+" means right alignment and spaces to the left
                    }
                }
            }
        }
    }
}

// Using recursion
int count=1;
void FindWordsRec(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{count++, -5}{new String(word)}");
        return;
    }
    for (int i=0; i<alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWordsRec(alphabet, word, length+1);
    }
}

FindWords();
