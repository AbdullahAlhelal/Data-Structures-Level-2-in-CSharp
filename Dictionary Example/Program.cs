using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Example
{
    internal class Program
    {


        static void AdvancedLINQQuerieswithDictionaries()
        {
            // Dictionary for grouping
            Dictionary<string , string> fruitsCategory = new Dictionary<string , string>
        {
            { "Apple", "Tree" },
            { "Banana", "Herb" },
            { "Cherry", "Tree" },
            { "Strawberry", "Bush" },
            { "Raspberry", "Bush" }
        };


            // Grouping fruits by category
            var groupedFruits = fruitsCategory.GroupBy(kpv => kpv.Value);
            foreach ( var group in groupedFruits )
            {
                Console.WriteLine($"Category: {group.Key}");
                foreach ( var fruit in group )
                {
                    Console.WriteLine($" - {fruit.Key}");
                }
            }


            // Another Dictionary for combined queries
            Dictionary<string , int> fruitBasket = new Dictionary<string , int>
        {
            { "Apple", 5 },
            { "Banana", 2 },
            { "Orange", 7 }
        };


            // Combined LINQ queries
            var sortedFilteredFruits = fruitBasket
                .Where(kpv => kpv.Value > 3)
                .OrderBy(kpv => kpv.Key)
                .Select(kpv => new { kpv.Key , kpv.Value });

            Console.WriteLine("\nSorted and Filtered Fruits:");
            foreach ( var fruit in sortedFilteredFruits )
            {
                Console.WriteLine($"Fruit: {fruit.Key}, Quantity: {fruit.Value}");
            }

            Console.ReadKey();

        }
        static void UtilizingLINQwithDictionaries()
        {
            // Creating and initializing the dictionary
            Dictionary<string , int> fruitBasket = new Dictionary<string , int>
        {
            { "Apple", 5 },
            { "Banana", 2 },
            { "Orange", 7 }
        };


            // Using LINQ to transform items
            var fruitInfo = fruitBasket.Select(kpv => new { kpv.Key , kpv.Value });


            // Displaying the results
            Console.WriteLine("Transformed Items:");
            foreach ( var item in fruitInfo )
            {
                Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
            }




            // Using LINQ to filter items
            var filteredFruit = fruitBasket.Where(kpv => kpv.Value > 3);


            Console.WriteLine("\nFiltered Items >3:");
            foreach ( var item in filteredFruit )
            {
                Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
            }




            // Using LINQ to sort by value
            var sortedByQuantity = fruitBasket.OrderBy(kpv => kpv.Value);


            Console.WriteLine("\nSorted Items:");
            foreach ( var item in sortedByQuantity )
            {
                Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
            }


            // Using LINQ to sort by value
            var sortedByQuantityDesc = fruitBasket.OrderByDescending(kpv => kpv.Value);


            Console.WriteLine("\nSorted Items Desc:");
            foreach ( var item in sortedByQuantityDesc )
            {
                Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
            }

            // Using LINQ to aggregate data
            int totalQuantity = fruitBasket.Sum(kpv => kpv.Value);

            Console.WriteLine($"\nTotal Quantity: {totalQuantity}");


            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            Dictionary<string , int> fruitBasket = new Dictionary<string , int>();

            fruitBasket.Add("Apple" , 5);
            fruitBasket.Add("Banana" , 2);
            fruitBasket.Add("Orange" , 12);

            int appleQuantity = fruitBasket["Apple"];

            if ( fruitBasket.ContainsKey("Apple") )
            {
                Console.WriteLine("Apple is in the basket.");
            }

            fruitBasket["Apple"] = 10; // Updates the value for the key "Apple"

            fruitBasket.Remove("Banana"); // Removes the key-value pair where the key is "Banana"


            foreach ( KeyValuePair<string , int> item in fruitBasket )
            {

                Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
            }

            if ( fruitBasket.TryGetValue("Apple" , out int appleQuantity1) )
            {
                Console.WriteLine($"Apple quantity: {appleQuantity1}");
            }
            else
            {
                Console.WriteLine("Apple not found in the basket.");
            }

            AdvancedLINQQuerieswithDictionaries();

        }
    }
}

