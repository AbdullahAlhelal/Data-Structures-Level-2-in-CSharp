using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Array_List
{
    public class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }


        public Employee(string name , string department , decimal salary)
        {
            Name = name;
            Department = department;
            Salary = salary;
        }
    }

    internal class Program
    {

        static void AggregateFunctionsinArrayListwihLinq()
        {

            ArrayList arrayListe = new ArrayList()
            {
            { new Employee("Alice", "HR", 50000) },
            { new Employee("Bob", "IT", 70000) },
            { new Employee("Charlie", "HR", 52000) },
            { new Employee("Daisy", "IT", 80000) },
            { new Employee("Ethan", "Marketing", 45000) }

        };


            var emp = arrayListe.Cast<Employee>().Where(e => e.Name == "Alice").FirstOrDefault();

            ArrayList arrayList = new ArrayList { 10 , 5 , 20 , 15 , 30 };
            var minValue = arrayList.Cast<int>().Min();
            var maxValue = arrayList.Cast<int>().Max();
            var Sum = arrayList.Cast<int>().Sum();
            var Average = arrayList.Cast<int>().Average();
            var Count = arrayList.Cast<int>().Count();

            Console.WriteLine("\nArrayList Items: ");
            for ( int i = 0 ; i < arrayList.Count ; i++ )
            {
                Console.Write(arrayList[i].ToString() + " ");
            }

            Console.WriteLine("\n\nMinimum value in the ArrayList: " + minValue);
            Console.WriteLine("Maximum value in the ArrayList: " + maxValue);
            Console.WriteLine("Sum values in the ArrayList: " + Sum);
            Console.WriteLine("Average values in the ArrayList: " + Average);
            Console.WriteLine("Count Items in the ArrayList: " + Count);


            arrayList.Sort();
            Console.WriteLine("\nArrayList Items After Sorting: ");
            for ( int i = 0 ; i < arrayList.Count ; i++ )
            {
                Console.Write(arrayList[i].ToString() + " ");
            }
            Console.ReadKey();
        }
        static void FilteringelementsfromArrayList()
        {


            ArrayList arrayList = new ArrayList { 1 , 2 , 3 , 4 , 5 , 6 , 7 , 8 , 9 , 10 };


            //we use cast here to convert it to int first then we apply the filter.
            var evenNumbers = arrayList.Cast<int>().Where(num => num % 2 == 0);


            Console.WriteLine("All even numbers:");
            foreach ( var num in evenNumbers )
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();

        }
        static void Main(string[] args)
        {

            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add(20);
            list.Add(30);


            Console.WriteLine("Elements in ArrayList:");
            foreach ( var item in list )
            {
                Console.WriteLine(item);
            }


            list.Remove(20); // Removing an element
            Console.WriteLine("After removing an element:");
            foreach ( var item in list )
            {
                Console.WriteLine(item);
            }

            // For resizing ArrayList
            list.TrimToSize();
            FilteringelementsfromArrayList();
            AggregateFunctionsinArrayListwihLinq();
            Console.ReadKey();
        }
    }
}
