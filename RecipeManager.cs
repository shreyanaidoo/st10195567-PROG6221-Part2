using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Shreya_Naidoo_ST10195567_PROG6221_Part_2
{
    public class RecipeManager
    {
        //{
    private List<recipes> recipes;

        // Constructor
        public RecipeManager()
        {
            recipes = new List<recipes>();
        }

        // Method to add a new recipe
        public void AddRecipe(recipes recipes)
        {
            recipes.AddIngredient(recipes);
        }

        // Method to get recipes in alphabetical order
        public List<recipes> GetRecipes()
        {
            return recipes.OrderBy(r => r.Name).ToList();
        }

        // Method to display all recipes
        public void DisplayRecipes()
        {
            var sortedRecipes = GetRecipes();
            Console.WriteLine("Recipes:");
            foreach (var recipe in sortedRecipes)
            {
                Console.WriteLine(recipe.Name);
            }
        }

        // Method to display a specific recipe
        public void DisplayRecipe(string name, Console console)
        {
            var recipe = recipes.FirstOrDefault(r => r.Name == name);
            if (recipe != null)
            {
                Console.WriteLine($"Recipe: {recipe.Name}");
                foreach (var ingredient in recipe.Ingredients)
                {
                    console.WriteLine(value: $"{ingredient.Name} - {ingredient.Calories} calories - {ingredient.FoodGroup}");
                }
                Console.WriteLine($"Total Calories: {recipes.TotalCalories()}");
            }
            else
            {
                Console.WriteLine("Oh No ! The recipe not found. Please trya again and enter in valid input ");
            }
        }
    }
}
// Code Attribution
// This code is taken from Pro C# 10 with .net 6 Foundational principles and practices in programming
// Eleventh edition 
// By Andrew Troelsen and Phil Japiske