using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace tryCs
{
    class Program
    {
        public static void tryStringInterpolation()
        {
            string name;
            decimal balance = 0.0m;

            Console.WriteLine("Who are we talking about?");
            name = Console.ReadLine();
            Console.WriteLine($"You were saying... how much money does {name} have left?");

            string balanceInput = Console.ReadLine();
            try
            {
                balance = decimal.Parse(balanceInput);
            }
            catch (Exception e)
            {
                e.ToString();
                Console.WriteLine("I don't think that is a valid amount...");
            }

            Console.WriteLine($"{name} has {balance:c} left.");
        }

        internal static int Add(int v1, int v2)
        {
            return v1 + v2;
        }

        public static void tryLinqOnIntArray()
        {
            var countForRating = new int[] { 0, 0, 0, 0, 0 };

            //Original Rating Inputs
            var ratingsOf5 = new int[] { 1, 2, 4, 4, 5, 3, 2, 3, 4, 3, 1, 2, 2, 4 };
            Console.Write("Original Array: ");
            foreach (var rating in ratingsOf5)
            {
                Console.Write(rating + " ");
                countForRating[rating - 1]++;
            }
            Console.WriteLine();
            Console.WriteLine("Counts for each rating:");
            for(var i=0; i<countForRating.Length; i++)
            {
                Console.WriteLine($"{(i + 1)}: {countForRating[i]}");
            }
            Console.WriteLine("\n");

            //Order ratings
            var ordered = from rating in ratingsOf5
                          orderby rating
                          select rating;
            Console.Write("Oedered Array: ");
            foreach (var rating in ordered)
            {
                Console.Write(rating + " ");
            }
            Console.WriteLine("\n");

            //Rated 3 or more
            var rated3OrMore = from rating in ordered
                               where rating >= 3
                               select rating;
            Console.Write("Ratings (3 and above): ");
            foreach (var rating in rated3OrMore)
            {
                Console.Write(rating + " ");
            }
            Console.WriteLine($"\n{(countForRating[2] + countForRating[3] + countForRating[4])} ratings are rated 3 or more.");

        }

        public static void tryDivideByZero(bool useDouble)
        {
            Console.Write("Enter Numerator: ");
            string numerator = Console.ReadLine();
            Console.Write("Enter Denominator: ");
            string denominator = Console.ReadLine();

            try
            {
                if (useDouble)
                {
                    double d_numeratorVal;
                    double d_denominatorVal;
                    double.TryParse(numerator, out d_numeratorVal);
                    double.TryParse(denominator, out d_denominatorVal);
                    Console.WriteLine($"{d_numeratorVal}/{d_denominatorVal} is {(d_numeratorVal / d_denominatorVal)}");
                    return;
                }
                int i_numeratorVal;
                int i_denominatorVal;
                int.TryParse(numerator, out i_numeratorVal);
                int.TryParse(denominator, out i_denominatorVal);
                Console.WriteLine($"{i_numeratorVal}/{i_denominatorVal} is {(i_numeratorVal / i_denominatorVal)}");
            }catch(DivideByZeroException)
            {
                    Console.WriteLine("Unable to divide by 0 while using int divide.");
            }
            finally
            {
                Console.WriteLine("All resources have been released! YAY!");
            }
        }

        static void Main(string[] args)
        {
            //tryStringInterpolation();
            //tryLinqOnIntArray();
            //tryDivideByZero(true);
            Console.WriteLine(Add(1, 5));
        }
    }
}
