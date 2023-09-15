using System.Text.Json;

namespace MobileApp.Recipes;

public partial class Burger : ContentPage
{
	public Burger()
	{
        InitializeComponent();
        LoadMauiAsset().ContinueWith((task) =>
        {
            var recipeItem = task.Result;

            if (recipeItem != null && recipeItem.Count > 0)
            {
                //Chat-Gpt Generated Code
                var recipeItems = recipeItem[0];
                ingredientsLabel.Text = string.Join("\n", recipeItems.Ingredients);

                // Update the instructions Label
                instructionsLabel.Text = string.Join("\n", recipeItems.Instruction);
                headline.Text = recipeItems.Headline;
                duration.Text = recipeItems.Duration;
                numPeople.Text = recipeItems.NumPeople;
            }
        }, TaskScheduler.FromCurrentSynchronizationContext());
    }

    private async Task<List<RecipeData>> LoadMauiAsset()
    {
        try
        {
            using var stream = await FileSystem.OpenAppPackageFileAsync("recipes.json");
            using var reader = new StreamReader(stream);

            var content = await reader.ReadToEndAsync();
            var recipData =  JsonSerializer.Deserialize<List<RecipeData>>(content);

            return recipData;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null;
        }
    }
}