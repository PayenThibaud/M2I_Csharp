namespace SalarieHeritage.Class;

internal class Salarie
{

    // propfull => 1 attribut et sa propriété
    protected decimal _salaire;

    public virtual decimal Salaire
    {
        get => _salaire;
        set
        {
            TotalSalaires -= _salaire;
            _salaire = value;
            //TotalSalaires += value;
            TotalSalaires += _salaire;
        }
    }

    // auto-property => 1 propriété mais l'attribut est caché
    // utile si on ne fait rien de particulier au get ou au set de l'attribut en question
    public string Matricule { get; set; } = "000";
    public string Nom { get; set; } = "Salarié par défaut";
    public string Service { get; set; } = "Service par défaut";
    public string Categorie { get; set; } = "Catégorie par défaut";


    // le nombre total d’employés, le salaire total
    public static int NombreSalaries { get; protected set; } = 0;
    public static decimal TotalSalaires { get; set; } = 0;

    public static decimal MoyenneSalaires => TotalSalaires / NombreSalaries;

    public Salarie()
    {
        NombreSalaries++;
        Salaire = 16236; // SMIC pour les salariés par défaut
    }

    public Salarie(string matricule, string nom, string service, string categorie, decimal salaire) : this()
    {
        Salaire = salaire;
        Matricule = matricule;
        Nom = nom;
        Service = service;
        Categorie = categorie;
    }


    public virtual void AfficherSalaire()
    {
        Console.WriteLine($"Le salaire de {Nom} est de {Salaire} euros");
    }

    public override string ToString()
    {
        return $"Salarie - Salaire: {this.Salaire}, Matricule : {this.Matricule}, Nom : {this.Nom}, Service : {this.Service}, Categorie : {this.Categorie} ";
    }


    public static void AfficherNombreDeSalarie()
    {
        Console.WriteLine($"Nombre de salariés : {NombreSalaries}");
    }

    public static void AfficherSalaireTotal()
    {
        Console.WriteLine($"Salaire total : {TotalSalaires}");
    }
    public static void AfficherMoyenneSalaire()
    {
        if (NombreSalaries == 0)
        {
            Console.WriteLine($"Salaire moyen : {TotalSalaires}");
        }
        else
        {
            Console.WriteLine($"Salaire moyen : {TotalSalaires / NombreSalaries}");
        }
    }

    public virtual void ChangerSalaire(decimal salaire)
    {
        Salaire = salaire;
        Console.WriteLine($"On change le salaire de {Nom} à {Salaire} euros");
    }
    public static Salarie CreerSalarie(string matricule, string nom, string service, string categorie, decimal salaire)
    {
        Salarie nouveauSalarie = new Salarie(matricule, nom, service, categorie, salaire);
        return nouveauSalarie;
    }


}
