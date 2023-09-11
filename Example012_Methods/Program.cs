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
    string result = String.Empty;

    // int i = 0;
    // while (i<count)
    // {
    //     result= result + text;
    //     i++;
    // }

    for (int i=0; i<count; i++)
    {
        result = result + text;
    }

    return result;
}
string result = Method4(5, "Slava Rossii! ");
Console.WriteLine(result);


Console.WriteLine("\nFor loop");
// for loop
for (int i=2; i<=10; i++)
{
    for (int j=2; j<=10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}


Console.WriteLine("\nWorking with text");
// Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточчками,
// маленькие буквы "k" заменить большими "K",
// а большие "V" маленькими "v".

string text = "- YA dumayu, - skazal knyaz', ulybayas', - chto, "
              + "yesli by vy ubili vmesto nashego milogo Vintsengeroda,"
              + "vy prinyali soglasheniye prusskogo korolya."
              + "Vy tak krasnorechivy. Vy dadite mne chayu?";

// string = "qwerty"
//           012
// s[3] - "r"

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;

    int length = text.Length;
    for (int i=0; i<length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);

string newText2 = Replace(newText, 'k', 'K');
Console.WriteLine(newText2);

string newText3 = Replace(newText2, 'V', 'v');
Console.WriteLine(newText3);


Console.WriteLine("\nWorkign with arrays");
// 1. Найти позицию минимального эелемента в неосортированной части массива.
// 2. Произвести обмен этого значения со значением первой неотсортированной позиции
// 3. Повторять пока есть не отсортированные элементы

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i=0; i<count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

PrintArray(arr);

void SelectionSort(int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        int minPosition = i;

        for (int j=i+1; j<array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

SelectionSort(arr);
PrintArray(arr);
