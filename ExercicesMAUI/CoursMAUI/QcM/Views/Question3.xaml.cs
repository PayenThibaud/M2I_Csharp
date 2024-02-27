namespace QcM.Views;

public partial class Question3 : ContentPage
{
    public Question3()
    {
        InitializeComponent();
    }

    public async void OnPushClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Victoire());
    }

    public async void OnPopClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
    public async void OnPopAllClicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }

}