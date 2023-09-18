namespace MobileApp.Restaurant;

public partial class RestaurantPage : ContentPage
{
	public RestaurantPage()
	{
        InitializeComponent();
        var jsonData = new JsonData<RestaurantItem>();
        jsonData.LoadMauiAsset("restaurant.json").ContinueWith((task) =>
        {
            var newsItems = task.Result;

            if (newsItems != null && newsItems.Count > 0)
            {
                //Chat-Gpt Generated Code
                var firstRestaurantItem = newsItems[0];
                headlineLabel1.Text = firstRestaurantItem.Headline;
                address1.Text = "Adresse: " + firstRestaurantItem.Address;
                telNum1.Text = "Telefon: " + firstRestaurantItem.TelNum;
                website1.Text = "Webseite: " + firstRestaurantItem.Website;

                var secondRestaurantItem = newsItems[1];
                headlineLabel2.Text = secondRestaurantItem.Headline;
                address2.Text = "Adresse: " + secondRestaurantItem.Address;
                telNum2.Text = "Telefon: " + secondRestaurantItem.TelNum;
                website2.Text = "Webseite: " + secondRestaurantItem.Website;
            }
        }, TaskScheduler.FromCurrentSynchronizationContext());
    }
}