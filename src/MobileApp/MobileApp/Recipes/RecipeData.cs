using Newtonsoft.Json;

namespace MobileApp.Recipes
{
    public class RecipeData
    {
        [JsonProperty("Instruction")]
        public List<string> Instruction { get; set; }

        [JsonProperty("Ingredients")]
        public List<string> Ingredients { get; set; }

        [JsonProperty("Headline")]
        public string Headline { get; set; }

        [JsonProperty("NumPeople")]
        public string NumPeople { get; set; }

        [JsonProperty("Duration")]
        public string Duration { get; set; }
    }
}
