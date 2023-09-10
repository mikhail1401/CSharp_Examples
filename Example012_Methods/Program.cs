// Method Types.


Console.WriteLine("Type 1");
// Type 1.
// Doesn't take any arguments and doesn't return anything.
void Method1()
{
    System.Console.WriteLine("This is the example of Method1");
}
Method1();


Console.WriteLine("\nType 2");
// Type 2.
// Takes arguments but doesn't return anything.
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Method2 example");

// Different way of passing multiple arguments
void Method21(string msg, int count)
{
    int i = 0;
    while (i<count)
    {
        Console.Write(msg);
        i++;
    }
}
Method21(count: 4, msg: "Some text ");  // Order of the arguments doesn't matter when we specify them


Console.WriteLine("\n\nType3");
// Type 3.
// Doesn't take any arguments but returns something.
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);


Console.WriteLine("\nType4");
// Type 4.
// Takes arguments and returns something.
string Method4(int count, string text)
{
    int i = 0;
    string result = "";

    while (i<count)
    {
        result= result + text;
        i++;
    }
    return result;
}
string result = Method4(5, "Slava Rossii! ");
Console.WriteLine(result);