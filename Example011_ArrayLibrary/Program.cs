﻿void FillArray(int[] collection)    // void is a method that doesn't return anything. We can't use "return" in it
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}


void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}


int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;  // If result equals to "-1", then the element has been found
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];  // Creates an array consiting of 10 zeros

FillArray(array);
PrintArray(array);

Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
