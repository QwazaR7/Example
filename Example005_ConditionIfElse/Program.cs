Console.Write("Enter your name: ");
string username = Console.ReadLine();

if (username.ToLower() == "влад")
{
    Console.WriteLine("Ура, это же Влад!!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}