Console.WriteLine("--- Quelle taille dois-je prendre ? ---");
Console.Write("Entrez votre taille (en cm) : ");
string nombreCm = Console.ReadLine();
Console.Write("Entrez votre poids (en kg) : ");
string nombreKg = Console.ReadLine();

if (double.TryParse(nombreCm, out double cm) &&
    double.TryParse(nombreKg, out double kg))
{
    kg = Math.Round(kg);
    cm = Math.Round(cm);

    if (kg >= 43 && kg <= 77 && cm >= 145 && cm <= 183)
    {
        if (kg >= 43 && kg <= 47 && cm >= 145 && cm < 172)
        {
            Console.WriteLine("Prenez la taille 1");
        }


        if (kg >= 48 && kg <= 53 && cm >= 145 && cm < 183)
        {
            if (cm >= 169 && cm < 183)
            {
                Console.WriteLine("Prenez la taille 2");
            }
            else
            {
                Console.WriteLine("Prenez la taille 1");
            }
        }



        if (kg >= 54 && kg <= 59 && cm >= 145 && cm <= 183)
        {
            if (cm >= 166 && cm < 178)
            {
                Console.WriteLine("Prenez la taille 2");
            }
            else
            {
                if (cm >= 178 && cm <= 183)
                {
                    Console.WriteLine("Prenez la taille 3");
                }
                else
                {
                    Console.WriteLine("Prenez la taille 1");
                }
            }
        }


        if (kg >= 60 && kg <= 65 && cm >= 145 && cm <= 183)
        {
            if (cm >= 163 && cm < 175)
            {
                Console.WriteLine("Prenez la taille 2");
            }
            else
            {
                if (cm >= 175 && cm <= 183)
                {
                    Console.WriteLine("Prenez la taille 3");
                }
                else
                {
                    Console.WriteLine("Prenez la taille 1");
                }
            }
        }


        if (kg >= 66 && kg <= 71 && cm >= 160 && cm <= 183)
        {
            if (cm >= 172 && cm <= 183)
            {
                Console.WriteLine("Prenez la taille 3");
            }
            else
            {
                Console.WriteLine("Prenez la taille 2");
            }
        }


        if (kg >= 72 && kg <= 77 && cm >= 163 && cm < 183)
        {
            Console.WriteLine("Prenez la taille 3");
        }
    }
    else
    {
        Console.WriteLine("Aucune taille ne vous correspond");
    }
}
else
{
    Console.WriteLine("Rentrez des longueurs valides !");
}
