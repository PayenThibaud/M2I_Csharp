void operation(double val1, double val2, out double somme, out double difference, out double quotient, out double produit)
{
     somme = val1 + val2;
     difference = (val1 >= val2) ? val1 - val2 : val2 - val1;
     quotient = val1 / val2;
    produit = val1 * val2;
}

double somme, difference, quotient, produit;

Console.WriteLine("Saisir val1");
double val1;
while (!double.TryParse(Console.ReadLine(), out val1))
    Console.WriteLine($"Saisie invalide ! Recommence \nSaisir val1 ");

Console.WriteLine("Saisir val2");
double val2;
while (!double.TryParse(Console.ReadLine(), out val2))
    Console.WriteLine($"Saisie invalide ! Recommence \nSaisir val1 ");

operation(val1, val2, out somme, out difference, out quotient, out produit);

Console.WriteLine($"Somme: {somme}, Différence: {difference}, Quotient: {quotient}, Produit: {produit}");
