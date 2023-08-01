Console.Write("Enter the user name: ");
string username = Console.ReadLine();

if (username.ToLower() == "masha")
{
    Console.WriteLine("Yahoo, this is Masha!");
}
else
{
    Console.Write("Hi, ");
    Console.WriteLine(username);
}