using QcM.Views;

namespace QcM
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void GotoPageFullCS(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageFullCS());

            // ajouter du code ici qui s'exécutera au retour sur la MainPage
        }

        private async void GotoPushPopPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Question1());
        }

    }

}
