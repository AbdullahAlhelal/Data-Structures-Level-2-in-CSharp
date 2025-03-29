using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExamples
{
    internal class Program
    {

        static void AggregatingData()
        {
            // List initialization
            List<int> numbers = new List<int> { 1 , 2 , 3 , 4 , 5 , 6 , 7 , 8 , 9 , 10 };


            // Aggregation operations
            Console.WriteLine("Sum: " + numbers.Sum());
            Console.WriteLine("Average: " + numbers.Average());
            Console.WriteLine("Minimum: " + numbers.Min());
            Console.WriteLine("Maximum: " + numbers.Max());
            Console.WriteLine("Count: " + numbers.Count());


            // Waiting for a key press
            Console.ReadKey();
        }
        static void Looping()
        {


            // Creating and initializing a List of integers
            List<int> numbers = new List<int> { 1 , 2 , 3 , 4 , 5 };


            // Displaying the total number of elements in the list
            Console.WriteLine("Number of items in the list: " + numbers.Count);


            // Looping through the list using a for loop
            Console.WriteLine("\nDisplaying list elements using a for loop:");
            for ( int i = 0 ; i < numbers.Count ; i++ )
            {
                Console.WriteLine(numbers[i]); // Accessing each element by its index
            }


            // Looping through the list using a foreach loop
            Console.WriteLine("\nDisplaying list elements using a foreach loop:");
            foreach ( int number in numbers )
            {
                Console.WriteLine(number); // Accessing each element directly
            }


            // Looping through the list using the List.ForEach method
            Console.WriteLine("\nDisplaying list elements using List.ForEach:");
            numbers.ForEach(number => Console.WriteLine(number)); // Using a lambda expression


            // Waiting for a key press before closing the console window
            Console.ReadKey();
        }

        static void RemoveItems()
        {// List initialization
            List<int> numbers = new List<int> { 1 , 2 , 3 , 4 , 5 , 6 , 7 , 8 , 9 , 10 };

            Predicate<int> predicate = n => n % 2 == 0;

            // Removing an item by value
            numbers.Remove(5);
            Console.WriteLine("After removing 5: " + string.Join(", " , numbers));


            // Removing an item by index
            numbers.RemoveAt(0);
            Console.WriteLine("After removing first element: " + string.Join(", " , numbers));


            // Removing multiple items
            numbers.RemoveAll(predicate);
            Console.WriteLine("After removing all even numbers: " + string.Join(", " , numbers));


            // Clearing the list
            numbers.Clear();
            Console.WriteLine("After clearing the list, count: " + numbers.Count);


            // Waiting for a key press
            Console.ReadKey();
        

    }
        static void ExampleAdd()
        {
            // List initialization
            List<int> numbers = new List<int> { 1 , 2 , 3 , 4 , 5 , 6 , 7 , 8 , 9 , 10 };


            // Adding an element at the end
            numbers.Add(11);
            Console.WriteLine("After adding 11: " + string.Join(", " , numbers));


            // Inserting an element at a specific position
            numbers.Insert(0 , 0);
            Console.WriteLine("After inserting 0 at the beginning: " + string.Join(", " , numbers));


            // Inserting multiple elements
            numbers.InsertRange(5 , new List<int> { 55 , 56 });
            Console.WriteLine("After inserting 55 and 56 at index 5: " + string.Join(", " , numbers));


            // Waiting for a key press
            Console.ReadKey();

        }
        static void FilteringData()
        {
            // List initialization
            List<int> numbers = new List<int> { 1 , 2 , 3 , 4 , 5 , 6 , 7 , 8 , 9 , 10 };


            // LINQ Filtering
            Console.WriteLine("Even Numbers: " + string.Join(", " , numbers.Where(n => n % 2 == 0)));
            Console.WriteLine("Odd Numbers: " + string.Join(", " , numbers.Where(n => n % 2 != 0)));
            Console.WriteLine("Numbers Greater Than 5: " + string.Join(", " , numbers.Where(n => n > 5)));
            Console.WriteLine("Every Second Number: " + string.Join(", " , numbers.Where((n , index) => index % 2 == 1)));
            Console.WriteLine("Numbers Between 3 and 8: " + string.Join(", " , numbers.Where(n => n > 3 && n < 8)));


            // Waiting for a key press
            Console.ReadKey();

        }
      
        
        static void Sorting()
        {
            // List initialization
            List<int> numbers = new List<int> { 44 , 22 , 55 , 666 , 9 , -6 , 345 , 11 , 3 , 3 };

      
            // Default Sorting (Ascending)
            numbers.Sort(,);
            Console.WriteLine("Sorted in Ascending Order: " + string.Join(", " , numbers));


            // Sorting in Descending Order
            numbers.Reverse();
            Console.WriteLine("Sorted in Descending Order: " + string.Join(", " , numbers));


            // Sorting with LINQ
            Console.WriteLine("Sorted Ascending with LINQ: " + string.Join(", " , numbers.OrderBy(n => n)));
            Console.WriteLine("Sorted Descending with LINQ: " + string.Join(", " , numbers.OrderByDescending(n => n)));


            // Waiting for a key press
            Console.ReadKey();
        }
        static void Example1()
        {
            // Creating a new List of integers
            List<int> numbers = new List<int>();


            // Adding elements to the list
            numbers.Add(1); // Add 1 to the list
            numbers.Add(2); // Add 2 to the list
            numbers.Add(3); // Add 3 to the list
            numbers.Add(4); // Add 4 to the list
            numbers.Add(5); // Add 5 to the list


            // Displaying the total number of elements in the list
            Console.WriteLine("Number of items in the list: " + numbers.Count);


            // Accessing and displaying each element in the list
            Console.WriteLine(numbers[0]); // Displays the first element (1)
            Console.WriteLine(numbers[1]); // Displays the second element (2)
            Console.WriteLine(numbers[2]); // Displays the third element (3)
            Console.WriteLine(numbers[3]); // Displays the fourth element (4)
            Console.WriteLine(numbers[4]); // Displays the fifth element (5)


            // Modifying an element in the list
            Console.WriteLine("Changing the value of item 2 of the list to 500:");
            numbers[1] = 500; // Change the value of the second element to 500
            Console.WriteLine(numbers[1]); // Displays the new value of the second element (500)


            // Waiting for a key press before closing the console window
            Console.ReadKey();
        }
        static void Main(string[] args)
        {

            Example1();
            Looping();
        }
    }
}
