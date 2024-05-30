using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shreya_Naidoo_ST10195567_PROG6221_Part_2
{
    public class recipes
    {
        public List<ingredient> Ingredients { get; } = new List<ingredient>();
        public List<string> Steps { get; } = new List<string>();
        public object Name { get; internal set; }

        // Adds an ingredient to the recipe.
        public void AddIngredient(ingredient ingredient)
        {
            Ingredients.Add(ingredient);
        }

        // Adds a cooking step to the recipe.
        public void AddStep(string step)
        {
            Steps.Add(step);
        }

        // Scales the recipe by a given factor, adjusting ingredient quantities.
        public void ScaleRecipe(double factor)
        {
            foreach (var ingredient in Ingredients)
            {
                ingredient.Scale(factor);
            }
        }

        // Resets all ingredient quantities to their original values.
        public void ResetQuantities()
        {
            foreach (var ingredient in Ingredients)
            {
                ingredient.Reset();
            }
        }

        // Displays the complete recipe.
        public void DisplayRecipe()
        {
            Console.WriteLine("\nRecipe:");
            Console.WriteLine("Ingredients:");
            foreach (var ingredient in Ingredients)
            {
                Console.WriteLine(ingredient);
            }
            Console.WriteLine("Steps:");
            int stepNumber = 1;
            foreach (var step in Steps)
            {
                Console.WriteLine($"{stepNumber}. {step}");
                stepNumber++;
            }
        }

        // Clears all ingredients and steps from the recipe.
        public void ClearRecipe()
        {
            ingredients.Clear();
            Steps.Clear();
        }

        // Method to check if the recipe is empty
        public bool IsEmpty()
        {
            return ingredients.Count == 0 && Steps.Count == 0;
        }

        internal void AddIngredient(recipes recipes)
        {
            throw new NotImplementedException();
        }

        internal static object FirstOrDefault(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }
    // part 2 for recipes class
    {
    private List<recipes> recipes;

    // Constructor
    public class RecipeManager()
    {
        recipes = new List<recipes>();
    }

    // Method to add a new recipe
    public void Addrecipes(recipes recipe)
    {
        recipes.Add(recipe);
    }

    // Method to get recipes in alphabetical order
    public List<recipes> Getrecipes()
    {
        return recipes.OrderBy(r => r.Name).ToList();
    }

    // Method to display all recipes
    public void Displayrecipes()
    {
        var sortedRecipes = Getrecipes();
        Console.WriteLine("Recipes:");
        foreach (var recipe in sortedRecipes)
        {
            Console.WriteLine(recipe.Name);
        }
    }

    // Method to display a specific recipe
    public void Displayrecipes(string name)
    {
        var recipe = recipes.FirstOrDefault(r => r.Name == name);
        if (recipe != null)
        {
            Console.WriteLine($"Recipe: {recipe.Name}");
            foreach (var ingredient in recipe.ingredients)
            {
                Console.WriteLine($"{ingredient.Name} - {ingredient.Calories} calories - {ingredient.FoodGroup}");
            }
            Console.WriteLine($"Total Calories: {recipe.TotalCalories()}");
            {
    private List<recipes> recipes;

    // Constructor
    public class RecipeManager()
    {
        recipes = new List<recipes>();
    }

    // Method to add a new recipe
    public void AddRecipe(recipes recipe)
    {
        recipes.Add(recipe);
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
    public void DisplayRecipe(string name)
    {
        var recipe = recipes.FirstOrDefault(r => r.Name == name);
        if (recipes != null)
        {
            Console.WriteLine($"Recipe: {recipes.Name}");
            foreach (var ingredient in recipes.ingredients)
            {
                Console.WriteLine($"{ingredient.Name} - {ingredient.Calories} calories - {ingredient.FoodGroup}");
            }
            Console.WriteLine(value:$"Total Calories: {recipe.TotalCalories()}");
        }
        else
        {
            Console.WriteLine("Error! Recipe not found.");
        }
    }
}
        else
        {
            Console.WriteLine("Error! Recipe not found.");
        }
    }
}
}

        // Code Attribution
// This code is taken from Pro C# 10 with .net 6 Foundational principles and practices in programming
// Eleventh edition 
// By Andrew Troelsen and Phil Japiske