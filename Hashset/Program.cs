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
        #region OperationwithHashSet
        static void IntersectionOperationwithHashSet()
        {
        }
        static void UnionOperationwithHashSetin()
        {
            HashSet<int> set1 = new HashSet<int> { 1 , 2 , 3 };
            HashSet<int> set2 = new HashSet<int> { 3 , 4 , 5 };


            // Union of set1 and set2
            set1.UnionWith(set2);


            Console.WriteLine("Union of sets:");
            foreach ( int item in set1 )
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        #endregion

        static void UsingHashSetwithLINQ()
        {
            // Creating and populating a HashSet of integers
            HashSet<int> numbers = new HashSet<int> { 1 , 2 , 3 , 4 , 5 , 6 , 7 , 8 , 9 , 10 };


            // Using LINQ to filter out even numbers
            var evenNumbers = numbers.Where(n => n % 2 == 0);

            
            // Displaying the even numbers
            Console.WriteLine("Even Numbers:");
            foreach ( var number in evenNumbers )
            {
                Console.WriteLine(number);
            }


            // Using LINQ to find numbers greater than 5
            var numbersGreaterThanFive = numbers.Where(n => n > 5);


            // Displaying the numbers greater than 5
            Console.WriteLine("\nNumbers Greater Than 5:");
            foreach ( var number in numbersGreaterThanFive )
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();

        }

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
            UnionOperationwithHashSetin();
        }
    }
}
