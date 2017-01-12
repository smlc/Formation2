using System.Collections.Generic;
using DataContract;

namespace Service
{
    public class JsonRecipeService: AbstractRecipeService
    {
        public override List<Recipe> GetRecipes()
        {
            return DataJson.Model.GetJsonRecipes();
        }
    }
}
