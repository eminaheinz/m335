namespace MobileApp.Recipes;

public partial class RecipePage : ContentPage
{
	public RecipePage()
	{
		InitializeComponent();
	}
    private async void OnBurgerButtonClicked(object sender, EventArgs e)
    {
        var newsPage = new Burger();

        await Navigation.PushAsync(newsPage);
    }
    private async void OnPastaButtonClicked(object sender, EventArgs e)
    {
        var newsPage = new Pasta();

        await Navigation.PushAsync(newsPage);
    }
    private async void OnFajitasRecipButtonClicked(object sender, EventArgs e)
    {
        var newsPage = new Fajitas();

        await Navigation.PushAsync(newsPage);
    }
}