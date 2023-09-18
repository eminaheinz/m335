using System;
using System.IO;
using System.Text.Json;
using Microsoft.Maui.Controls;
using MobileApp.Facts;

namespace MobileApp.News;

public partial class NewsPage : ContentPage
{
    public NewsPage()
    {
        InitializeComponent();
        var jsonData = new JsonData<NewsItem>();
        jsonData.LoadMauiAsset("news.json").ContinueWith((task) =>
        {
            var newsItems = task.Result;

            if (newsItems != null && newsItems.Count > 0)
            {
                //Chat-Gpt Generated Code
                var firstNewsItem = newsItems[0];
                newsHeadlineLabel.Text = firstNewsItem.Headline;
                newsContentLabel.Text = firstNewsItem.Content;
                newsDateLabel.Text = firstNewsItem.Date;

                var secondNewsItem = newsItems[1];
                newsBurgerHeadlineLabel.Text = secondNewsItem.Headline;
                newsBurgerContentLabel.Text = secondNewsItem.Content;
                newsBugerDateLabel.Text = secondNewsItem.Date;
            }
        }, TaskScheduler.FromCurrentSynchronizationContext());
    }
}