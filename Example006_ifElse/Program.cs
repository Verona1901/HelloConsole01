Console.WriteLine("Ведите имя пользователя:");
string username = Console.ReadLine ();
if (username.ToLower () == "nika")
{
    Console.WriteLine("Ура, это же NIKA!");
}
else
{
Console.Write("Привет,");
Console.WriteLine(username);
}