using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Hashset
{
    internal class Program
    {

        static void UsingHashSettoRemoveDuplicates()
        {
            // Array with duplicate values
            int[] array = new int[] { 1 , 2 , 2 , 3 , 4 , 4 , 5 };


            // Initializing a HashSet with the array
            HashSet<int> uniqueNumbers = new HashSet<int>(array);


            // Displaying the unique elements
            foreach ( int number in uniqueNumbers )
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();
        }
        static void RemovingElementsfromHashSet()
        {

            // Creating and populating a HashSet
            HashSet<string> fruits = new HashSet<string> { "Apple" , "Banana" , "Cherry" };

            Console.WriteLine("Hashset Item Count = " + fruits.Count.ToString());

            // Removing "Banana" from the HashSet
            fruits.Remove("Banana");

            Console.WriteLine("\nHashset Item Count after removing Banana = " + fruits.Count.ToString());
            // Displaying the remaining elements
            foreach ( string fruit in fruits )
            {
                Console.WriteLine(fruit);
            }

            //this will remove all elements
            fruits.Clear();
            Console.WriteLine("\nHashset Item Count after clear = " + fruits.Count.ToString());

            Console.ReadKey();
        }
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

            CheckingforExistenceinHashSet();
            RemovingElementsfromHashSet();
        }
    }
}
