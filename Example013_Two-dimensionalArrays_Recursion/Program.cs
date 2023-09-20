// Two-deimansional arrays and recursion
// Syntax: 
// string[,] table = new string[2, 3];     - table with 2 rows and 3 columns

string[,] table = new string[2, 5];
// Row and Column Indeces start with 0
// table[0, 0]   table[0, 1]   table[0, 2]   table[0, 3]   table[0, 4]  
// table[1, 0]   table[1, 1]   table[1, 2]   table[1, 3]   table[1, 4]
// String get initialized by the constand String.Empty

table[1, 2] = "word";

for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        System.Console.WriteLine($"-{table[rows, columns]}-");
    }
}


Console.WriteLine("\nMatrix");
int[,] matrix = new int[3, 4];

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)   // GetLength(0) - returns number of the rows
    {
        for (int j = 0; j < matr.GetLength(1); j++)   // GetLength(1) - returns number of the columns
        {
            System.Console.Write($"{matr[i, j]} ");
        }
        
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1, 10);
        }
    }
}

PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);