﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorted_List
{
    public class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }


        public Employee(string name, string department, decimal salary)
        {
            Name = name;
            Department = department;
            Salary = salary;
        }
    }

    internal class Program
    {

        static void AdvanceComplexObjectOperationsusingLinqandSotredList() 
        {

            SortedList<int, Employee> employees = new SortedList<int, Employee>()
        {
            { 1, new Employee("Alice", "HR", 50000) },
            { 2, new Employee("Bob", "IT", 70000) },
            { 3, new Employee("Charlie", "HR", 52000) },
            { 4, new Employee("Daisy", "IT", 80000) },
            { 5, new Employee("Ethan", "Marketing", 45000) }
        };


            var query = employees
                .Where(e => e.Value.Department == "IT")
                .OrderByDescending(e => e.Value.Salary)
                .Select(e => e.Value.Name);


            Console.WriteLine("IT Department Employees sorted by Salary (Descending):");
            foreach (var name in query)
            {
                Console.WriteLine(name);
            }
        } 
        static void AdvancedLINQUsagewithSortedListGroupingElements() 
        {

            // Initialize a SortedList of int keys and string values with fruit names
            SortedList<int, string> sortedList = new SortedList<int, string>()
        {
            { 1, "Apple" },
            { 2, "Banana" },
            { 3, "Cherry" },
            { 4, "Date" },
            { 5, "Grape" },
            { 6, "Fig" },
            { 7, "Elderberry" }
        };


            // Grouping fruits by the length of their names
            Console.WriteLine("Grouping fruits by the length of their names:");
            var groups = sortedList.GroupBy(kvp => kvp.Value.Length);
            foreach (var group in groups)
            {
                Console.WriteLine($"Name Length {group.Key}: {string.Join(", ", group.Select(kvp => kvp.Value))}");
            }
        }
        static void LINQwithSortedList()
        {

            // Initialize a SortedList with integer keys and string values
            SortedList<int, string> sortedList = new SortedList<int, string>()
        {
            { 1, "One" },
            { 3, "Three" },
            { 2, "Two" },
            { 4, "Four" } // Enhanced dataset for comprehensive output
        };


            // Query using Query Expression Syntax
            var queryExpressionSyntax = from kvp in sortedList
                                        where kvp.Key > 1 // Filter keys greater than 1
                                        select kvp;
            Console.WriteLine("Query Expression Syntax Results:");
            foreach (var item in queryExpressionSyntax)
            {
                Console.WriteLine($"{item.Key}: {item.Value}"); // Expected: 2, 3, 4
            }


            // Query using Method Syntax
            var methodSyntax = sortedList.Where(kvp => kvp.Key > 1); // Filter keys greater than 1
            Console.WriteLine("\nMethod Syntax Results:");
            foreach (var item in methodSyntax)
            {
                Console.WriteLine($"{item.Key}: {item.Value}"); // Expected: 2, 3, 4
            }


            // Filter key-value pairs with keys greater than a specific value
            int specificValue = 2;
            var filteredByKey = sortedList.Where(kvp => kvp.Key > specificValue); // Filter keys greater than 2
            Console.WriteLine($"\nEntries with keys greater than {specificValue}:");
            foreach (var item in filteredByKey)
            {
                Console.WriteLine($"{item.Key}: {item.Value}"); // Expected: 3, 4
            }
        }
    
        static void Main(string[] args)
        {
            var sortedList = new SortedList();
            var sortedListGeneric = new SortedList<string , int>();


           // non - Generic
            sortedList.Add("apple" , 3);
            sortedList.Add("Orange" , 3);
            sortedList.Add("banana" , 2);
            //
            // Generic

            sortedListGeneric.Add("apple" , 3);
            sortedListGeneric.Add("Orange" , 3);
            sortedListGeneric.Add("banana" , 2);

            int appleQuantity = (int) sortedList["apple"]; // For non-generic
            int bananaQuantity = sortedListGeneric["banana"]; // For generic


            foreach ( DictionaryEntry item in sortedList ) // Non-generic
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }


            foreach ( KeyValuePair<string,int> item in sortedListGeneric ) // Generic
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }


            sortedList.Remove("apple"); // Non-generic
            sortedListGeneric.Remove("banana"); // Generic
        }
    }
}
