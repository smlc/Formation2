using DataContract;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;

namespace DataJson
{
    public class Model
    {
        public static List<Recipe> GetJsonRecipes()
        {
            var json = File.ReadAllText("recipes.json");
            return JsonConvert.DeserializeObject<List<Recipe>>(json);
        }

        public static List<Recipe> GetJsonRecipes2()
        {
            var serializer = new DataContractJsonSerializer(typeof(List<Recipe>));
            var fs = File.OpenRead("recipes.json");
            return (List<Recipe>)serializer.ReadObject(fs);
        }
    }
}
