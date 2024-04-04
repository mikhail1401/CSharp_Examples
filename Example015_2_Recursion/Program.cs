// Алгоритм обхода директории
// (Посмотреть все папки и файлы, находящиеся в данной папке) 

string path = "C:/Users/mfedotov.TRADEZERO/OneDrive - TradeZero/Documents/Personal Documents/Studying";
DirectoryInfo di = new DirectoryInfo(path);

Console.WriteLine(di.CreationTime);

FileInfo[] fi =di.GetFiles();

for (int i = 0; i < fi.Length; i++)
{
    Console.WriteLine(fi[i].Name);
}


Console.WriteLine();
// Using recursion
void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);

    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }

    FileInfo[] files = catalog.GetFiles();
    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }
}

string path2 = "C:/Users/mfedotov.TRADEZERO/OneDrive - TradeZero/Documents/Personal Documents/Studying/C#/Examples/Example001_HelloConsole";
CatalogInfo(path2);