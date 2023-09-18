using System.Text.Json;

namespace MobileApp.Recipes;

public partial class Burger : ContentPage
{
	public Burger()
	{
        InitializeComponent();
        var jsonData = new JsonData<RecipeData>();
        jsonData.LoadMauiAsset("recipes.json").ContinueWith((task) =>
        {
            var recipeItem = task.Result;

            if (recipeItem != null && recipeItem.Count > 0)
            {
                //Chat-Gpt Generated Code
                var recipeItems = recipeItem[0];
                ingredientsLabel.Text = string.Join("\n", recipeItems.Ingredients);
                instructionsLabel.Text = string.Join("\n", recipeItems.Instruction);
                headline.Text = recipeItems.Headline;
                duration.Text = recipeItems.Duration;
                numPeople.Text = recipeItems.NumPeople;
            }
        }, TaskScheduler.FromCurrentSynchronizationContext());
    }
}