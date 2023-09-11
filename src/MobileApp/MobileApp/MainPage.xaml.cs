using MobileApp.News;
using MobileApp.Facts;
using MobileApp.Restaurant;
using MobileApp.Recipes;

namespace MobileApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnNewsButtonClicked(object sender, EventArgs e)
        {
            var newsPage = new NewsPage();

            await Navigation.PushAsync(newsPage);
        }
        private async void OnFactsButtonClicked(object sender, EventArgs e)
        {
            var newsPage = new FactsPage();

            await Navigation.PushAsync(newsPage);
        }
        private async void OnRecipButtonClicked(object sender, EventArgs e)
        {
            var newsPage = new RecipePage();

            await Navigation.PushAsync(newsPage);
        }
        private async void OnRestaurantButtonClicked(object sender, EventArgs e)
        {
            var newsPage = new RestaurantPage();

            await Navigation.PushAsync(newsPage);
        }
    }
}