using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionistCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome to the calculator
            Console.WriteLine("Hello welcome to the Nutritionist calculator!");

            //get grams of fat from user
            Console.WriteLine("Please enter the number of grams of fat: ");
            double FatGrams = double.Parse(Console.ReadLine());
            //output to calories
            Console.WriteLine(FatGrams + " grams of fat is " + FatCalories(FatGrams) + " calories.");

            //get number of carbs
            Console.WriteLine("Please enter the number of carbohydrates: ");
            double CarbGrams = double.Parse(Console.ReadLine());
            //output
            Console.WriteLine(CarbGrams + " carbohydrates is " + CarbCalories(CarbGrams) + " calories.");

        }

        //This method should accept a number of fat grams as an argument 
        //and return the number of calories from that amount of fat.
        //Calories from fat = Fat grams × 9
        public static double FatCalories(double FatGrams)
        {
            double FatCal = FatGrams * 9;
            return FatCal;
        }

        //This method should accept a number of carbohydrate grams as an argument and return the number of 
        //calories from that amount of carbohydrates.
        //Calories from carbs = Carbs grams × 4
        public static double CarbCalories(double Carbs)
        {
            double CarbCal = Carbs * 4;
            return CarbCal;
        }

    }
}
