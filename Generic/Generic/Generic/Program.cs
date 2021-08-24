using System;
using System.Collections.Generic;
using System.Linq;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            KeyValuePair<int, string> kvp1 = new KeyValuePair<int, string>();
            kvp1.Key = 100;
            kvp1.Value = "Hundred";

            KeyValuePair<string, string> kvp2 = new KeyValuePair<string, string>();
            kvp2.Key = "IT";
            kvp2.Value = "Information Technology";


            DataStore<string> cities = new DataStore<string>();
            cities.AddOrUpdate(0, "Mumbai");
            cities.AddOrUpdate(1, "Chicago");
            cities.AddOrUpdate(2, "London");

            DataStore<int> empIds = new DataStore<int>();
            empIds.AddOrUpdate(0, 50);
            empIds.AddOrUpdate(1, 65);
            empIds.AddOrUpdate(2, 89);


            Printer printer = new Printer();
            printer.Print<int>(100);
            printer.Print(200); // type infer from the specified value
            printer.Print<string>("Hello");
            printer.Print("World!"); // type infer from the specified value




            // array list 

            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(1); // adding elements using add() method
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);


            var cities2 = new List<string>();
            cities2.Add("New York");
            cities2.Add("London");
            cities2.Add("Mumbai");
            cities2.Add("Chicago");
            cities2.Add(null);// nulls are allowed for reference type list



            //adding elements using collection-initializer syntax
            var bigCities = new List<string>()
            {
                "New York",
                "London",
                "Mumbai",
                "Chicago"
            };


            var students = new List<Student>() 
            {
                new Student(){ Id = 1, Name="Bill"},
                new Student(){ Id = 2, Name="Steve"},
                new Student(){ Id = 3, Name="Ram"},
                new Student(){ Id = 4, Name="Abdul"}
            };

            students.Add(new Student() { Id = 4, Name = "FFF" });

            Console.WriteLine("No of elelemts: " + students.Count);




            //--------------------------------------------------------

            string[] cities3 = new string[3] { "Mumbai", "London", "New York" };

            var popularCities = new List<string>();

            // adding an array in a List
            popularCities.AddRange(cities3);

            var favouriteCities = new List<string>();

            // adding a List 
            favouriteCities.AddRange(popularCities);



            // ---------------------------------------------------

            List<int> numbers = new List<int>() { 1, 2, 5, 7, 8, 10 };
            Console.WriteLine(numbers[0]); // prints 1
            Console.WriteLine(numbers[1]); // prints 2
            Console.WriteLine(numbers[2]); // prints 5
            Console.WriteLine(numbers[3]); // prints 7

            // using foreach LINQ method
            numbers.ForEach(num => Console.WriteLine(num + ", "));//prints 1, 2, 5, 7, 8, 10,

            // using for loop
            for (int i = 0; i < numbers.Count; i++)
                Console.WriteLine(numbers[i]);



            // LINQ Query on List --------------------------------

            var students1 = new List<Student>() {
                new Student(){ Id = 1, Name="Bill"},
                new Student(){ Id = 2, Name="Steve"},
                new Student(){ Id = 3, Name="Ram"},
                new Student(){ Id = 4, Name="Abdul"}
            };

            //get all students whose name is Bill
            var result = from s in students1
                         where s.Name == "Bill"
                         select s;

            foreach (var student in result)
                Console.WriteLine(student.Id + ", " + student.Name);


            // ------------------------------------------------


            var numbers1 = new List<int>() { 10, 20, 30, 40 };

            numbers1.Insert(1, 11);// inserts 11 at 1st index: after 10.

            foreach (var num in numbers)
                Console.Write(num);

            // ------------------------------------------------


            var numbers11 = new List<int>() { 10, 20, 30, 40, 10 };

            numbers.Remove(10); // removes the first 10 from a list

            numbers.RemoveAt(2); //removes the 3rd element (index starts from 0)

            //numbers.RemoveAt(10); //throws ArgumentOutOfRangeException

            foreach (var el in numbers11)
                Console.Write(el); //prints 20 30


            // ------------------------------------------------


            var numbers12 = new List<int>() { 10, 20, 30, 40 };
            numbers.Contains(10); // returns true
            numbers.Contains(11); // returns false
            numbers.Contains(20); // returns true


            // ------------------------------------------------


            /*           
            Add            Adds an element at the end of a List<T>.
            AddRange        Adds elements of the specified collection at the end of a List<T>.
            BinarySearch    Search the element and returns an index of the element.
            Clear           Removes all the elements from a List< T >.
            Contains        Checks whether the specified element exists or not in a List<T>.
            Find            Finds the first element based on the specified predicate function.
            Foreach         Iterates through a List<T>.
            Insert          Inserts an element at the specified index in a List< T >.
            InsertRange     Inserts elements of another collection at the specified index.
            Remove          Removes the first occurrence of the specified element.
            RemoveAt        Removes the element at the specified index.
            RemoveRange     Removes all the elements that match the supplied predicate function.
            Sort Sorts      all the elements.
            TrimExcess      Sets the capacity to the actual number of elements.
            TrueForAll      Determines whether every element in the List<T> matches the conditions defined by the specified predicate.
            */

        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class DataStore<T>
    {
        private T[] _data = new T[10];

        public void AddOrUpdate(int index, T item)
        {
            if (index >= 0 && index < 10)
                _data[index] = item;
        }

        public T GetData(int index)
        {
            if (index >= 0 && index < 10)
                return _data[index];
            else
                return default(T);
        }
    }


    public class KeyValuePair<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
    }


    public class Printer
    {
        public void Print<T>(T data)
        {
            Console.WriteLine(data);
        }
    }


}
