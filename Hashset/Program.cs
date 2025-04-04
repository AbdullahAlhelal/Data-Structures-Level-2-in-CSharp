using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashset
{
    internal class Program
    {

        static void CheckingforExistenceinHashSet()
        {

            // Creating and populating a HashSet
            HashSet<string> fruits = new HashSet<string> { "Apple" , "Banana" , "Cherry" };


            // Checking if "Apple" is in the HashSet
            if ( fruits.Contains("Apple") )
            {
                Console.WriteLine("Apple is in the HashSet");
            }
            else
            {
                Console.WriteLine("Apple is not in the HashSet");
            }
        }

        static void Main(string[] args)
        {

            // Creating a HashSet of strings
            HashSet<string> fruits = new HashSet<string>();




            // Adding elements to the HashSet
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Cherry");


            // Trying to add a duplicate element
            fruits.Add("Apple"); // This will not be added
            fruits.Add("Apple"); // This will not be added
            fruits.Add("Apple"); // This will not be added


            // Displaying the elements in the HashSet
            foreach ( string fruit in fruits )
            {
                Console.WriteLine(fruit);
            }
            Console.ReadKey();
        }
    }
}
