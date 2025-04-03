using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Example
{
    internal class Program
    {
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

        }
    }
}
