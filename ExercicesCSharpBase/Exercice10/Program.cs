Console.WriteLine("--- La lettre est-elle une voyelle ? ---");
Console.Write("Entrez qu'UNE lettre : ");
string lettre = Console.ReadLine();

if (lettre == "a" || lettre == "e" || lettre == "i" || lettre == "o" || lettre == "y" || lettre == "u" || lettre == "A" || lettre == "E" || lettre == "I" || lettre == "O" || lettre == "Y" || lettre == "U")
{
    Console.WriteLine("Cette lettre est une voyelle !");
}
else if (lettre.Length >= 2)
{
    Console.WriteLine("Qu'\"UNE\" Lettre !"); 
}
else 
{
    Console.WriteLine("Cette lettre n'est pas une voyelle !");
}