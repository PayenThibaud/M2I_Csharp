using Microsoft.Maui.Controls;

namespace QcM.Views;

public partial class Question2 : ContentPage
{
    public Question2()
    {
        InitializeComponent();
    }

    public async void OnPushClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Question3());
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