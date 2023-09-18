using System.Text.Json;


namespace MobileApp.Facts;

public partial class FactsPage : ContentPage
{
	public FactsPage()
	{
        InitializeComponent();
        var jsonData = new JsonData<FactsItem>();
        jsonData.LoadMauiAsset("facts.json").ContinueWith((task) =>
        {
            var newsItems = task.Result;

            if (newsItems != null && newsItems.Count > 0)
            {
                //Chat-Gpt Generated Code
                var firstNewsItem = newsItems[0];
                fact1HeadlineLabel.Text = firstNewsItem.Headline;
                fact1ContentLabel.Text = firstNewsItem.Content;
                fact1DateLabel.Text = firstNewsItem.Date;

                var secondNewsItem = newsItems[1];
                fact2HeadlineLabel.Text = secondNewsItem.Headline;
                fact2ContentLabel.Text = secondNewsItem.Content;
                fact2DateLabel.Text = secondNewsItem.Date;
            }
        }, TaskScheduler.FromCurrentSynchronizationContext());
    }
}