Console.WriteLine("--- Dans quelle catégorie mon enfant est-il ? ---");
Console.Write("Entrez l'âge de votre enfant (3 à 18 ans) : ");
string nombreAge = Console.ReadLine();

if (double.TryParse(nombreAge, out double age))
{
    string categorie = "error";

    switch (age)
    {
        case <= 2:
            Console.WriteLine("Veuillez entrer un âge valide.");
            break;
        case <= 6:
            categorie = "Baby";
            break;

        case <= 8:
            categorie = "Poussin";
            break;

        case <= 10:
            categorie = "Pupille";
            break;

        case <= 12:
            categorie = "Minime";
            break;

        case <= 18:
            categorie = "Cadet";
            break;

        default:
            Console.WriteLine("Veuillez entrer un âge valide.");
            break;
    }

    if (categorie != "error")
        Console.WriteLine("Votre enfant est dans la catégorie \"" + categorie + "\" !");
}
else
{
    Console.WriteLine("Veuillez entrer un âge valide.");
}