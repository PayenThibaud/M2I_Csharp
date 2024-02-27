namespace QcM.Views;

public partial class Question1 : ContentPage
{
    public Question1()
    {
        InitializeComponent();
    }

    public async void OnPushClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Question2());
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