using ExoCiternes.Class;



Citerne[] tableCiterne = new Citerne[]
        {
            new Citerne("Alpha", 5, 20, 5),
            new Citerne("Omega", 5, 20, 8),
            new Citerne("Beta", 5, 20, 10),
            new Citerne("Delta", 5, 20, 12),
            new Citerne("Azertyuiop", 5, 20, 15),
        };

Citerne.TotalEauDesCiternes();
foreach (Citerne a in tableCiterne)
{
    a.AfficherPoidTotal();
    a.RemplirCiterne(10);
    a.RetraitCiterne(30);

}
Citerne.TotalEauDesCiternes();