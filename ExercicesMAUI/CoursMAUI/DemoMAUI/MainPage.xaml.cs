using System;
using System.Threading.Tasks;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace DemoMAUI
{
    public partial class MainPage : ContentPage
    {
        int nombreEssaisRestants = 10;
        int nombreMystere;
        Random random = new Random();

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
            nombreMystere = GenerateRandomNumber(1, 100);
            UpdateImagesVisibility();
        }

        private void OnTestNumberClicked(object sender, EventArgs e)
        {
            nombreEssaisRestants--;

            UpdateImagesVisibility();

            if (nombreEssaisRestants == 0)
            {
                resultatLabel.Text = "Perdu ! Le nombre mystère était : " + nombreMystere;
                resultatLabel.TextColor = Microsoft.Maui.Graphics.Colors.Red;
                nombreEntry.IsVisible = false;
                nombreEntry.IsEnabled = false;
                testButton.IsVisible = false;
                resetButton.IsVisible = true;
            }
            else
            {
                if (int.TryParse(nombreEntry.Text, out int nombreSaisi))
                {

                    string resultat = CompareNumbers(nombreSaisi);
                    resultatLabel.Text = resultat;

                    if (resultat == "Congratulations! You've found the mystery number!")
                    {
                        nombreEntry.IsVisible = false;
                        nombreEntry.IsEnabled = false;
                        testButton.IsVisible = false;
                        resultatLabel.Text = "Bravo ! Tu as gagné !";
                        resultatLabel.TextColor = Microsoft.Maui.Graphics.Colors.Green;
                        resetButton.IsVisible = true;
                    }
                }
                else
                {
                    resultatLabel.Text = "Veuillez saisir un nombre valide.";
                }
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

        private void UpdateImagesVisibility()
        {
            nombreEntry.IsVisible = nombreEssaisRestants > 0;
            nombreEntry.IsEnabled = nombreEssaisRestants > 0;
            testButton.IsVisible = nombreEssaisRestants > 0;
            resetButton.IsVisible = nombreEssaisRestants == 0;

            end.Children.Clear();

            for (int i = 0; i < nombreEssaisRestants; i++)
            {
                var image = new Image { Source = "end.png", HeightRequest = 30, WidthRequest = 30 };
                image.RotateTo(360, 1000); 
                end.Children.Add(image);
            }
        }

        private void OnResetClicked(object sender, EventArgs e)
        {
            nombreEssaisRestants = 10;
            nombreMystere = GenerateRandomNumber(1, 100);

            UpdateImagesVisibility();

            resultatLabel.Text = string.Empty;
        }
    }
}
