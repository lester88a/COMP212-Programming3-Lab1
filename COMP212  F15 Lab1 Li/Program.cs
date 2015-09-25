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
            //int leftCars = 0;
            //int reorderLevel = 0;
            
            //welcome messages
            Console.WriteLine("Welcome to Centennial College Car Reorder Program");
            Console.WriteLine("How many cars are in stock currently?");
            //get the total stocked cars by user input
            currentlyCarsInStock = Convert.ToInt32(Console.ReadLine());
            
            //New Counter Object, set the threshold reached at 80% of total
            Counter c = new Counter(Convert.ToInt32(currentlyCarsInStock * 0.8));
            c.ThresholdReached += c_ThresholdReached;
            //c.ThresholdReached = c.ThresholdReached + c_ThresholdReached;

            
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


            //Console.WriteLine("How many cars did Centennial College Car Delearship sell today?");
            ////get the total stocked cars by user input
            //do
            //{
            //    soldCars = Convert.ToInt32(Console.ReadLine());
            //    soldCars++;
            //if (soldCars >= currentlyCarsInStock)
            //{
            //    Console.WriteLine("Can't sell car more than the total car that in stock currently!");
            //    Console.WriteLine("Try it again!");
            //}
            //    //leftCars = currentlyCarsInStock - soldCars;
            //    //Console.WriteLine("left: {0}", leftCars);
                
            //} while (soldCars >= currentlyCarsInStock);

            //leftCars = currentlyCarsInStock - soldCars;
            ////set the reorder level 30% of total cars
            //reorderLevel = Convert.ToInt32(leftCars * 0.3);
            //Console.WriteLine("reorderLevel: {0}", reorderLevel);

            //New Counter Object
            //Counter c = new Counter(reorderLevel);
            //c.ThresholdReached += c_ThresholdReached;

            //while (leftCars > reorderLevel)
            //{
            //    c.Add(soldCars);
            //}
        }
        static void c_ThresholdReached(object sender, ThresholdReachedEventArgs e)
        {
            //Console.WriteLine("The threshold of {0} was reached at {1}.",
            //    e.Threshold, e.TimeReached);
            Console.WriteLine("The inventory reached the REORDER LEVEL: {0} at {1}. \nPlease order more cars now!"
                , e.Threshold, e.TimeReached);
            //Environment.Exit(0);

        }
    }
}
