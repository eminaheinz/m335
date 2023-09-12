using System;
using System.IO;
using System.Text.Json;
using Microsoft.Maui.Controls;

namespace MobileApp.News;

public partial class NewsPage : ContentPage
{
    public NewsPage()
    {
        InitializeComponent();
        LoadMauiAsset().ContinueWith((task) =>
        {
            var newsItems = task.Result;

            if (newsItems != null && newsItems.Count > 0)
            {
                var firstNewsItem = newsItems[0];
                newsHeadlineLabel.Text = firstNewsItem.Headline;
                newsContentLabel.Text = firstNewsItem.Content;
                newsDateLabel.Text = firstNewsItem.Date;
            }
        }, TaskScheduler.FromCurrentSynchronizationContext());
    }
    async Task<List<NewsItem>> LoadMauiAsset()
    {
        try
        {
            using var stream = await FileSystem.OpenAppPackageFileAsync("news.json");
            using var reader = new StreamReader(stream);
    
            var content = await reader.ReadToEndAsync();
            var newsItems = JsonSerializer.Deserialize<List<NewsItem>>(content);

            
            return newsItems;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null;
        }
    }


}