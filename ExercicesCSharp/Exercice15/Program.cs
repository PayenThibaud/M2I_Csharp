Console.WriteLine("--- Quelle sera le montant de l'indemnité de licenciement ? ---");
Console.Write("Merci de saisir le dernier salire (en euros) : ");
string nombreEuro = Console.ReadLine();
Console.Write("Merci de saisir votre âge : ");
string nombreAge = Console.ReadLine();
Console.Write("Merci de saisir le nombre d'années d'ancienneté : ");
string nombreAncien = Console.ReadLine();

if (double.TryParse(nombreEuro, out double euro) &&
    double.TryParse(nombreAge, out double age) &&
    double.TryParse(nombreAncien, out double ancien))
{
    double TotalIndem;
  if (ancien >=10)
    {
        TotalIndem = 10 * euro / 2 + euro * (ancien - 10);
    }
    else
    {
        TotalIndem = ancien * euro / 2;
    }

  if (age >=50)
    {
        TotalIndem = TotalIndem + 5 * euro;
    }
  else if (age >= 46)
    {
        TotalIndem = TotalIndem + 2 * euro;
    }

    Console.WriteLine("Votre indemnité est de : " + TotalIndem);
}
else
{
    Console.WriteLine("Rentrez des données valide !");
}