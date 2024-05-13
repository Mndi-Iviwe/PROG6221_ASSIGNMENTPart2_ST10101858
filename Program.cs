using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PROG6221_ASSIGNMENT2_ST10101858
{
    public class Program
    {
        static List<Recipe> RecipeList = new List<Recipe>();


        static void Main(string[] args)
        {
            Ingredients ingredients = new Ingredients();
            Steps steps = new Steps();
            Recipe recipe = new Recipe();
            

            //Start-up Greeting
            Console.WriteLine("\t\t\t\t Welcome To Sanele's Recipe app!!!\n\n");
            Console.WriteLine("Feel free to write in your most delicious traditional or favorite meal");
            Console.WriteLine("******************* A Recipe Must Be Recorded before Scaling ******************\n\n");


            //Capture Ingredients
            try 
            {
                Console.WriteLine("\nHow Many Ingredients in the Recipe? >>");
                recipe.numIngredients = Convert.ToInt32(Console.ReadLine());
                ingredients.CaptureIngredients(recipe.numIngredients);

 
                Console.WriteLine("\nHow Many Steps to Complete the Recipe? >>");
                recipe.NumSteps = Convert.ToInt32(Console.ReadLine());
                steps.CaptureSteps(recipe.NumSteps);

            } catch(Exception e) {
                Console.WriteLine("Invalid Input. " + e.Message);
            }
            

            //Print result
            //ingredients.PrintIngredientList();
            //steps.PrintSteps();
            recipe.PrintFullRecipe();
            RecipeOptions();

            //present options
            void RecipeOptions()
            {
                int option;

                do
                {
                    try
                    {
                        Console.WriteLine("\nWhat Would you like to do?(enter choice)\n" +
                                       "1) Reset Recipe\n" +
                                       "2) Scale Recipe\n" +
                                       "3) Enter New Recipe\n" +
                                       "4) Save Recipe\n"+
                                       "5) View Recipe List\n"+
                                       "6) End Program\n");
                        option = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }

                    switch (option)
                    {
                        case 1:
                            recipe.AddRecipe(RecipeList);
                            recipe.PrintFullRecipe();
                            RecipeOptions();
                            break;
                        case 2:
                            ingredients.ScaleOption();
                            RecipeOptions();
                            break;
                        case 3:
                            Console.WriteLine("\nHow Many Ingredients in the Recipe? >>");
                            recipe.numIngredients = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("\nHow Many Ingredients in the Recipe? >>");
                            ingredients.CaptureIngredients(recipe.numIngredients);
                            Console.WriteLine("\nHow Many Steps to Complete the Recipe? >>");
                            steps.CaptureSteps(recipe.NumSteps);

                            recipe.PrintFullRecipe();
                            RecipeOptions();
                            break;
                        case 4:
                            recipe.AddRecipe(RecipeList);
                            RecipeOptions();
                            break;
                        case 5:
                            recipe.ViewRecipes(RecipeList);
                            RecipeOptions();
                            break;
                    }

                } while (option != 6);
            }
        }
    }
}
