using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PROG6221_ASSIGNMENT2_ST10101858
{
    internal class Ingredients : Recipe
    {
        public static new string RecipeName { get; set; }
        public static List<string> ingredientName = new List<string>();
        public static List<double> ingredientQuantity = new List<double>();
        public static List<string> measureUnit = new List<string>();
        public static List<double> ingredientCalories = new List<double>();
        public static List<double> TotalCalories = new List<double>();
        public static string[] Foodgroup = { "Starchy", "Vegetables&Fruits", "DryBeans,Lentils&soya", "Meat", "Milk&Dairy", "Fats&Oils", "Water" };
        
      

        public void CaptureIngredients(int num)
        {
            string name, unit;
            double quantity, calories;
            int count = 0;

            Console.WriteLine("First things first......");
            Console.WriteLine("What is the Name of this Recipe!!!");
            RecipeName = Console.ReadLine();

            for (int x = 0; x < num; x++)
                {

                    try
                    {
                        Console.WriteLine("\nEnter the Ingredient #{0} name: ", count + 1);
                        name = Console.ReadLine();
                        ingredientName.Add(name);

                        Console.WriteLine("\nEnter the unit of measurement #{0}: ", count + 1);
                        unit = Console.ReadLine();
                        measureUnit.Add(unit);

                        Console.WriteLine("\nEnter the quantity #{0} of the unit of measurement : ", count + 1);
                        quantity = Convert.ToDouble(Console.ReadLine());
                        ingredientQuantity.Add(quantity);

                        Console.WriteLine("\nEnter the Calories(cal) #{0} of the ingredient " +
                            "\n(Take into account that Total calories will be calculated for you) : ", count + 1);
                        calories = Convert.ToDouble(Console.ReadLine());
                        ingredientCalories.Add(calories);

                        count++;


                }
                    catch (Exception e)
                    {

                    Console.WriteLine("Wrong Input: " + e); ;
                    }
                    
                }
      
        }

        public void HalfScaled()
        {
            int count = 0;
            double scale = 0.5;


            Console.WriteLine("\n Ingredients (half scaled): ");
            for (int x = 0; x < numIngredients; x++)
            {
                Console.WriteLine((ingredientQuantity[count] * scale) + " " + measureUnit[count] + " of " + ingredientName[count]);
                count++;
            }

        }
        public void DoubleScaled()
        {

            int count = 0;
            int scale = 2;

            Console.WriteLine("\n Ingredients (double scaled): ");
            while (count < numIngredients)
            {
                System.Console.WriteLine(ingredientQuantity[count] * scale + " " + measureUnit[count] + " of " + ingredientName[count]);
                count++;
            }

        }
        public void TripleScaled()
        {
            int count = 0;
            int scale = 3;

            Console.WriteLine("\n Ingredients (triple scaled): ");
            while (count < numIngredients)
            {
                Console.WriteLine(ingredientQuantity[count] * scale + " " + measureUnit[count] + " of " + ingredientName[count]);
                count++;
            }

        }

        public void TotalIngredientCalories(int num) {

            double totCalories;

            for (int x = 0; x < num; x++)
            {
                totCalories = ingredientCalories[num] * ingredientQuantity[num];
                TotalCalories.Add(totCalories);
            }
        }

        public void ScaleOption()
        {
            Steps steps = new Steps();
            int choice;

            try
            {
                Console.WriteLine("What Scaling do you wish to apply (enter choice)?\n" +
                    "1) Half Scaling\n" +
                    "2) Double Scaling\n" +
                    "3) Triple Scaling\n");
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                throw e;
            }

            switch (choice)
            {
                case 1:
                    HalfScaled();
                    steps.PrintSteps();
                    break;
                case 2:
                    DoubleScaled();
                    steps.PrintSteps();
                    break;
                case 3:
                    TripleScaled();
                    steps.PrintSteps();
                    break;
                default:
                    break;
            }

        }

    
    }
}
