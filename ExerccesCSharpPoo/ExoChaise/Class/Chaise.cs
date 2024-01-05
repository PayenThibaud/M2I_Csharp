using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoChaise.Class;

internal class Chaise
{
    // Attributs
    private int _pieds = 4;
    private string _materiaux = "bois";
    private string _couleur = "Naturelle";

    // Propriétés
    public int Pieds
    {
        get => _pieds;
        set => _pieds = value;
    }
    public string Materiaux { get => _materiaux; set => _materiaux = value; }
    public string Couleur { get => _couleur; set => _couleur = value; }


    // Constructeurs (crée une nouvelle instance de Dinosaur)
    public Chaise(){}//constructeur par défaut, il est vide, si on ne le crée pas, c# le crée implicitement

    public Chaise(int pieds, string materiaux, string couleur) // ici on a des paramètres d'entrées du constructeur
    {
        this.Pieds = pieds;// équivalent : Nom = nom;
        Materiaux = materiaux;
        Couleur = couleur;
    }

    // Méthodes
    public void Afficher()
    {
        Console.WriteLine($"Je suis une Chaise, avec {this.Pieds} pieds en {Materiaux} et de couleur {Couleur}");
    }
}
