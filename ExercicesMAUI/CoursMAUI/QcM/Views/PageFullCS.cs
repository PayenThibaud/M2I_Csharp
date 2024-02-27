namespace QcM.Views;

public class PageFullCS : ContentPage
{
	public PageFullCS()
	{
		Content = new VerticalStackLayout
		{
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Crédit"
                }
            }
		};
	}
}