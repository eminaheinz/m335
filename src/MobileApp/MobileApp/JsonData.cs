using MobileApp.Facts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MobileApp
{
    class JsonData<T>
    {
        public async Task<List<T>> LoadMauiAsset(string filname)
        {
            try
            {
                using var stream = await FileSystem.OpenAppPackageFileAsync(filname);
                using var reader = new StreamReader(stream);

                var content = await reader.ReadToEndAsync();
                var factsItems = JsonSerializer.Deserialize<List<T>>(content);


                return factsItems;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
