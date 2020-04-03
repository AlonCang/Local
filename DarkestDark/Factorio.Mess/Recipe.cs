using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;

namespace Factorio.Mess
{
    class Recipe
    {
        public string Name;
        public Dictionary<string, int> Input;
        public Dictionary<string, int> Output;

        public static List<Recipe> LoadRecipes(string recipeDirPath)
        {
            var recipes = new List<Recipe>();
            var recipePaths = Directory.EnumerateFiles(recipeDirPath, "*.json", SearchOption.AllDirectories);
            foreach (var recipePath in recipePaths)
            {
                var recipeJson = File.ReadAllText(recipePath);
                recipes.AddRange(JsonConvert.DeserializeObject<List<Recipe>>(recipeJson));
            }
            return recipes;
        }
    }
}
