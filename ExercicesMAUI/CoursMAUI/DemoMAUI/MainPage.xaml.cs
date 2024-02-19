using System;
using Microsoft.Maui.Controls;

namespace DemoMAUI
{
    public partial class MainPage : ContentPage
    {
        int nombreMystere;
        Random random = new Random();

        public MainPage()
        {
            InitializeComponent();
            nombreMystere = GenerateRandomNumber(1, 100); // Générer un nombre mystère entre 1 et 100
        }

        private void OnTestNumberClicked(object sender, EventArgs e)
        {
            // Récupérer le nombre saisi dans l'Entry
            if (int.TryParse(nombreEntry.Text, out int nombreSaisi))
            {
                // Appeler la méthode CompareNumbers pour comparer le nombre saisi au nombre mystère
                string resultat = CompareNumbers(nombreSaisi);
                resultatLabel.Text = resultat;
            }
            else
            {
                resultatLabel.Text = "Veuillez saisir un nombre valide.";
            }
        }

        private int GenerateRandomNumber(int minValue, int maxValue)
        {
            return random.Next(minValue, maxValue + 1);
        }

        private string CompareNumbers(int number)
        {
            if (number > nombreMystere)
            {
                resultatLabel.TextColor = Microsoft.Maui.Graphics.Colors.Red;
                return "Too high!";
            }
            else if (number < nombreMystere)
            {
                resultatLabel.TextColor = Microsoft.Maui.Graphics.Colors.Blue;
                return "Too low!";
            }
            else
            {
                resultatLabel.TextColor = Microsoft.Maui.Graphics.Colors.Green;
                return "Congratulations! You've found the mystery number!";
            }
        }




    }
}
