namespace Shreya_Naidoo_ST10195567_PROG6221_Part_2
{

    public class Program
    {
        static void Main(string[] args)
        {
            recipe recipe = new recipe();
            Console.WriteLine("Welcome to the Recipe Manager\n");

            bool running = true;
            while (running)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1 - Add a new recipe");
                Console.WriteLine("2 - Display the recipe");
                Console.WriteLine("3 - Scale the recipe");
                Console.WriteLine("4 - Reset quantities");
                Console.WriteLine("5 - Clear the recipe");
                Console.WriteLine("6 - Exit");
                Console.Write("Select an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        AddNewRecipe(recipe);
                        break;
                    case "2":
                        if (recipe.IsEmpty())
                        {
                            Console.WriteLine("Error!There are no recipes yet. Please add a recipe first to continue then you will get accurate results.");
                        }
                        else
                        {
                            recipe.DisplayRecipe();
                        }
                        break;
                    case "3":
                        if (recipe.IsEmpty())
                        {
                            Console.WriteLine("There are no recipes yet. Please add a recipe first.This field cannot be left blank.");
                        }
                        else
                        {
                            ScaleRecipe(recipe);
                        }
                        break;
                    case "4":
                        if (recipe.IsEmpty())
                        {
                            Console.WriteLine("There are no recipes yet. Please add a recipe first.This field cannot be left blank.");
                        }
                        else
                        {
                            recipe.ResetQuantities();
                            Console.WriteLine("Quantities have been reset.");
                        }
                        break;
                    case "5":
                        if (recipe.IsEmpty())
                        {
                            Console.WriteLine("There are no recipes yet. Please add a recipe first.This field cannot be left blank.");
                        }
                        else
                        {
                            recipe.ClearRecipe();
                            Console.WriteLine("The Recipe has been cleared.");
                        }
                        break;
                    case "6":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Error! Invalid option has been entered. To continue please add a valid input, please try again.");
                        break;
                }
            }
        }

        // Handles adding ingredients and steps to the recipe.
        private static void AddNewRecipe(Recipe recipe)
        {
            recipe.ClearRecipe(); // Clear previous data.

            Console.Write("Enter the number of ingredients: ");
            int ingredientCount = TryParseInput();
            for (int i = 0; i < ingredientCount; i++)
            {
                Console.Write($"Enter ingredient {i + 1} name: ");
                string name = Console.ReadLine();

                Console.Write($"Enter quantity for {name}: ");
                double quantity = TryParseDouble();

                Console.Write($"Enter unit of measure for {name}: ");
                string unit = Console.ReadLine();

                recipe.AddIngredient(new ingredient(name, quantity, unit));
            }

            Console.Write("Enter the number of steps: ");
            int stepCount = TryParseInput();
            for (int i = 0; i < stepCount; i++)
            {
                Console.Write($"Enter step {i + 1} description: ");
                string step = Console.ReadLine();
                recipe.AddStep(step);
            }
        }

        // Handles scaling the recipe by a specified factor.
        private static void ScaleRecipe(recipes recipes)
        {
            Console.WriteLine("Enter the scaling factor (e.g., 0,5 for half, 2 for double, 3 for triple):");
            double factor = TryParseDouble();
            if (factor > 0)
            {
                recipes.ScaleRecipe(factor);
                Console.WriteLine($"Recipe has been scaled by a factor of {factor}.");
            }
            else
            {
                Console.WriteLine("Error! Invalid scaling factor. Must be a positive number.");
            }
        }

        // Utility to safely parse user input as an integer.
        private static int TryParseInput()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int result) && result > 0)
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a positive number.");
                }
            }
        }

        // Utility to safely parse user input as a double.
        private static double TryParseDouble()
        {
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out double result) && result > 0)
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a positive number.");
                }
            }
        }

        //implementation recipe manager class 
        RecipeManager manager = new RecipeManager();

        // Example usage
        recipes recipes = new recipes("How to a Tomato Pasta");
        recipes.CalorieExceeded += Recipe_CalorieExceeded;

        recipes.Addingredients(new ingredients("Pasta", 200, "Grains"));
        recipes.Addingredients(new ingredients("Tomato Sauce", 50, "Vegetables"));
        recipes.Addingredients(new ngredients("Cheese", 100, "Dairy"));

        manager.AddRecipe(recipes);

        recipes recipes2 = new Recipe("Salad");
        recipe2.CalorieExceeded += Recipe_CalorieExceeded;

        recipes2.Addingredients(new ingredients("Lettuce", 10, "Vegetables"));
        recipes2.Addingredients(new ingredients("Tomato", 20, "Vegetables"));
        recipe2.Addingredients(new ingredients("Cucumber", 15, "Vegetables"));

        manager.AddRecipes(recipes2);

        manager.DisplayRecipes();
        manager.DisplayRecipe("Pasta");
    }

    private static void Recipe_CalorieExceeded(string recipeName)
    {
        Console.WriteLine($"Warning: The total calories of the recipe '{recipeName}' exceed 300.");
    }

}
// Code Attribution
// This code is taken from Pro C# 10 with .net 6 Foundational principles and practices in programming
// Eleventh edition 
// By Andrew Troelsen and Phil Japiske
