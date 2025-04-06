using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservableCollection__Examplies
{
    internal class Program
    {
        // CollectionChanged Event Handler
        static void Items_CollectionChanged(object sender , System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            Console.WriteLine("\nCollection Changed:");


            // Handling Collection Changes
            switch ( e.Action )
            {
                case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
                    Console.WriteLine("Added:");
                    foreach ( var newItem in e.NewItems )
                    {
                        Console.WriteLine("- " + newItem);
                    }
                    break;


                case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
                    Console.WriteLine("Removed:");
                    foreach ( var oldItem in e.OldItems )
                    {
                        Console.WriteLine("- " + oldItem);
                    }
                    break;


                case System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
                    Console.WriteLine("Replaced:");
                    foreach ( var oldItem in e.OldItems )
                    {
                        Console.WriteLine("- " + oldItem);
                    }
                    Console.WriteLine("With:");
                    foreach ( var newItem in e.NewItems )
                    {
                        Console.WriteLine("- " + newItem);
                    }
                    break;


                case System.Collections.Specialized.NotifyCollectionChangedAction.Move:
                    Console.WriteLine("Moved:");
                    Console.WriteLine($"- From index {e.OldStartingIndex} to index {e.NewStartingIndex}");
                    break;
            }
        }



        public static void RespondingtoChangesinObservableCollection()
        {
            ObservableCollection<string> Items = new ObservableCollection<string>();


            Items.CollectionChanged += Items_CollectionChanged;
            Items.Add("Item 1");
            Items.Add("Item 2");
            Items.Add("Item 3");

            Items.RemoveAt(1);
            Items.Insert(0 , "New Item");
            Items[1] = "Replaced Item"; // Replace action
            Items.Move(0 , 2); // Move action

        }
        public static void CreatingandAddingItemstoObservableCollection()
        {
            // Creating an ObservableCollection of strings
            ObservableCollection<string> names = new ObservableCollection<string>();

            // Adding items to the collection
            names.Add("Alice");
            names.Add("Bob");
            names.Add("James");
            names.Add("Jack");


            // Displaying items
            foreach ( string name in names )
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {

        }
    }
}
