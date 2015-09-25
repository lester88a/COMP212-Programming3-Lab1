using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP212__F15_Lab1_Li
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int currentlyCarsInStock = 0;
            int soldCars = 0;
            int totalSold = 0;
            
            //welcome messages
            Console.WriteLine("Welcome to Centennial College Car Reorder Program");
            Console.WriteLine("How many cars are in stock currently?");
            //get the total stocked cars by user input
            currentlyCarsInStock = Convert.ToInt32(Console.ReadLine());
            
            //New Counter Object, set the threshold reached at 80% of total
            Counter c = new Counter(Convert.ToInt32(currentlyCarsInStock * 0.8));
            c.ThresholdReached += c_ThresholdReached;

            
            while (true)
            {
                Console.WriteLine("How many cars did Centennial College Car Delearship sell today?");
                soldCars = Convert.ToInt32(Console.ReadLine());
                
                c.Add(soldCars);

                totalSold += soldCars;
                Console.WriteLine("total sold: {0}", totalSold);

                if (totalSold >= currentlyCarsInStock * 0.8)
                {
                    break;
                }
            }

        }
        static void c_ThresholdReached(object sender, ThresholdReachedEventArgs e)
        {
            Console.WriteLine("The inventory reached the REORDER LEVEL: {0} at {1}. \nPlease order more cars now!"
                , e.Threshold, e.TimeReached);
        }
    }
}
