using System;

double somme, difference, quotient, produit;
void operation(double val1, double val2)
{
     somme = val1 + val2;
     difference = (val1 >= val2) ? val1 - val2 : val2 - val1;
     quotient = val1 / val2;
     produit = val1 * val2;
}


Console.WriteLine("Saisir val1");
double val1;
while (!double.TryParse(Console.ReadLine(), out val1))
    Console.WriteLine($"Saisie invalide ! Recommence \nSaisir val1 ");

Console.WriteLine("Saisir val2");
double val2;
while (!double.TryParse(Console.ReadLine(), out val2))
    Console.WriteLine($"Saisie invalide ! Recommence \nSaisir val1 ");

operation(val1, val2);

Console.WriteLine($"Somme: {somme}, Différence: {difference}, Quotient: {quotient}, Produit: {produit}");
