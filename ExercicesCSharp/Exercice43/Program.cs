void compter_lettre_a(params string[] chaines)
{
    int compteur = 0;
    foreach (string chaine in chaines)
    {
        for (int i = 0; i < chaine.Length; i++)
        {
            if (chaine[i] == 'a' || chaine[i] == 'A')
            {
                compteur++;
            }
        }
    }
    Console.WriteLine($"Résultat : {compteur}");
}

 compter_lettre_a("Thibaud", "Payen");