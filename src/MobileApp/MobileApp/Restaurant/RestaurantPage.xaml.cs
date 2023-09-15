namespace MobileApp.Restaurant;

public partial class RestaurantPage : ContentPage
{
	public RestaurantPage()
	{
		InitializeComponent();
	}
    private void OnNoNameButtonClicked(object sender, EventArgs e)
    {
        System.Diagnostics.Process.Start("https://www.noname-chur.ch/");
    }
    private void OnMekongButtonClicked(object sender, EventArgs e)
    {
        System.Diagnostics.Process.Start("https://www.mekong-chur.ch/");
    }
}