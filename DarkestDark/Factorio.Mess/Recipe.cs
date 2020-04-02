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
       
       private void AddRecipes(string recipePath)
        {
            var recipeJson = File.ReadAllText(recipePath);
            var recipes = JsonConvert.DeserializeObject<List<Recipe>>(recipeJson);
            foreach (var recipe in recipes)
            {
                recipes[recipe.Name] = recipe;
            }
             // ERROR: Argument 1 cannot convert from 'string' to 'int'.
             // I dont understand.. When does the Recipe Name turn into an int? i cant find it.
             // Why is it turning into an int in the first place? I dont think i need it to.
        }

             // ERROR: not all code paths return a value.
             // What? but.... There is only one path... And it returns a value? or am i missing something?
             // I think i made a mistake by using the "StateGraph.cs" file. I should have used the State.cs file
             // And made the RecipeGraph seperately. I think. Or am i making a mess? It should be really simple right?
             // I think im not focused on the right things.... 
             // So my main question is: Should i recostruct the whole state machine just to allow for the stategraph?
             // Or should i pull out only the minimum amount of functionality from the statemachine to fulfill the task?
             // I think the second option is the right one... then which parts are these? I definitely need the JsonConverter thingy.
             // And the ReadAllText... And the path reader function and a place to save it all.
             // HALP PLOX?
        public static Recipe LoadRecipes(string recipeDirPath)
        {
            Recipe result = new Recipe();
            var recipePaths = Directory.EnumerateFiles(recipeDirPath, "*.json", SearchOption.AllDirectories);
            foreach (var recipePath in recipePaths)
            {
                result.AddRecipes(recipePath);
            }
        }
    }
}
