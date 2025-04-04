using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorted_List
{
    internal class Program
    {
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
