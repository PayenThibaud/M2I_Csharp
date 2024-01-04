Console.WriteLine("--- La nombre est-il divisible par... ? ---");
Console.Write("Entrez un chiffre/nombre entier : ");
double nombre = Convert.ToDouble(Console.ReadLine());

Console.Write("Entrez un chiffre/nombre diviseur : ");
double diviseur = Convert.ToDouble(Console.ReadLine());


if ( nombre % diviseur == 0)
{
    Console.WriteLine("Le chiffre/nombre est divisible par " + diviseur);
}
else
{
    Console.WriteLine("Le chiffre/nombre n'est pas divisible par " + diviseur);
}