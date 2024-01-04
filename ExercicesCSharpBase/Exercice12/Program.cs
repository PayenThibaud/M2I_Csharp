Console.WriteLine("--- Dans quelle catégorie mon enfant est-il... ? ---");
Console.Write("Entrez l'âge de votre enfant : ");
string nombre = Console.ReadLine();

if (int.TryParse(nombre, out int age))
    if (age >= 18)
    {
        Console.WriteLine("votre fils à déjà + de 18 ans !");
    }
    else if (age >= 13)
    {
        Console.WriteLine("Votre enfant est dans la catégorie \"Cadet\" !");
    }
    else if (age >= 11)
    {
        Console.WriteLine("Votre enfant est dans la catégorie \"Minime\" !");
    }
    else if (age >= 9)
    {
        Console.WriteLine("Votre enfant est dans la catégorie \"Pupille\" !");
    }
    else if (age >= 7)
    {
        Console.WriteLine("Votre enfant est dans la catégorie \"Poussin\" !");
    }
    else if (age >= 3)
    {
        Console.WriteLine("Votre enfant est dans la catégorie \"Baby\" !");
    }
    else
    {
        Console.WriteLine("Votre enfant est encore un bébé !");
    }
else
    Console.WriteLine("Rentrez un age !");