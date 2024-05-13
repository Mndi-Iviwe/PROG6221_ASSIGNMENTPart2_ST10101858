using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_ASSIGNMENT2_ST10101858
{
    internal class Steps : Recipe
    {
        
        public static string[] StepDescription = new string[15];

        public void CaptureSteps(int num)
        {
            int count = 0;
            
                for (int x = 0; x < num; x++)
                {
                    Console.WriteLine("\nEnter Step Desciption #{0}", count + 1);
                    StepDescription[x] = Console.ReadLine();
                    count++;
                }
            

        }

        //public void PrintSteps()
        //{

        //    int count = 0;

        //    Console.WriteLine("\n Instructions:");
        //    for (int x = 0; x < NumSteps; x++)
        //    {
        //        Console.Write("\nStep #{0}: ", count + 1);
        //        Console.WriteLine(StepDescription[x]);
        //        count++;
        //    }
        //}
    }
}
