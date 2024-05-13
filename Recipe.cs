using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static PROG6221_ASSIGNMENT2_ST10101858.Ingredients;

namespace PROG6221_ASSIGNMENT2_ST10101858
{
    public class Recipe
    {
        public int numIngredients;
        public int NumSteps;
        public string RecipeName;
        public delegate void PrintDelegateMessage(double totalCalories);

        //public Recipe(string recipeName)
        //{
        //    RecipeName = recipeName;
        //}

        PrintDelegateMessage PrintToConsole = (double calories) =>
        {
            if (calories > 300)
            {
                Console.WriteLine("!!!WARNING: This ingredinet exceeds 300cal!!!");
                Console.WriteLine("This Ingredient is " + calories + "cals in total.");
            }
            else
            {
                Console.WriteLine("This Ingredient is " + calories + "cals in total.");
            }
        };

        public void PrintIngredientList()
        {
            int count = 0;

            Console.WriteLine("\n Ingredients: ");
            for (int x = 0; x < numIngredients; x++)
            {
                Console.WriteLine(Ingredients.ingredientQuantity[count] + " " + Ingredients.measureUnit[count] + " of " + Ingredients.ingredientName[count]);
                PrintToConsole(Ingredients.TotalCalories[x]);
                count++;
            }

        }

        public void PrintSteps()
        {

            int count = 0;

            Console.WriteLine("\n Instructions:");
            for (int x = 0; x < NumSteps; x++)
            {
                Console.Write("\nStep #{0}: ", count + 1);
                Console.WriteLine(Steps.StepDescription[x]);
                count++;
            }
        }

        public void PrintFullRecipe()
        {

            //Saving Recipe Name A soon as it is printed by the system ?
            //Console.WriteLine("What is this Recipe Called?");
            PrintIngredientList();
            
            PrintSteps();

        }

        public void AddRecipe(List<Recipe> recipes)
        {

            PrintFullRecipe();

            recipes.Add(new Recipe());
            Console.WriteLine("Recipe added successfully!");
        }

        public void ViewRecipes(List<Recipe> recipes)
        {
            Console.WriteLine("Recipes:");
            for (int i = 0; i < recipes.Count; i++)
            {
                if (recipes[i] != null) {
                    Console.WriteLine($"{i + 1}. {recipes[i].RecipeName}");
                }
                else
                {
                    Console.WriteLine("Sorry. No Recipes have been saved.");
                }

            }

            Console.WriteLine("Enter the number of the recipe to view details:");
            int recipeIndex = Convert.ToInt32(Console.ReadLine());
                if (recipeIndex > 0 && recipeIndex <= recipes.Count)
                {
                    Recipe selectedRecipe = recipes[recipeIndex - 1];
                    Console.WriteLine($"Name: {selectedRecipe.RecipeName}");
                    selectedRecipe.PrintFullRecipe();
                }else{
                    Console.WriteLine("Invalid input.");
                }


        }


        }
    }
