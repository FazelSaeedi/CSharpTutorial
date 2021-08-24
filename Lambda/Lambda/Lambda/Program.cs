using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 0;
            Action action = () => { } ;


            i.ToString();

            actionInt(99);
            string s = func("Hi");


            // ------------------------------
            // List to store numbers
            List<int> numbers = new List<int>() {36, 71, 12,
                             15, 29, 18, 27, 17, 9, 34};



            // foreach loop to display the list
            Console.Write("The list : ");
            foreach (var value in numbers)
            {
                Console.Write("{0} ", value);
            }
            Console.WriteLine();



            // Using lambda expression
            // to calculate square of
            // each value in the list
            var square = numbers.Select(x => x * x);



            // foreach loop to display squares
            Console.Write("Squares : ");
            foreach (var value in square)
            {
                Console.Write("{0} ", value);
            }
            Console.WriteLine();



            // Using Lambda expression to
            // find all numbers in the list
            // divisible by 3
            List<int> divBy3 = numbers.FindAll(x => (x % 3) == 0);



            IsTeenAger isTeenAger = s => s.Age > 12 && s.Age < 20;
            Student stud = new Student() { Age = 25 };
            Console.WriteLine(isTeenAger(stud));


            // -----------------------------------------------------

            IList<Student> studentList = new List<Student>() 
            {
                new Student() { Id = 1, Name = "John", Age = 13} ,
                new Student() { Id = 2, Name = "Moin",  Age = 21 } ,
                new Student() { Id = 3, Name = "Bill",  Age = 18 } ,
                new Student() { Id = 4, Name = "Ram" , Age = 20} ,
                new Student() { Id = 5, Name = "Ron" , Age = 15 }
            };

            // LINQ Method Syntax to find out teenager students
            var teenAgerStudents = studentList.Where(s => s.Age > 12 && s.Age < 20)
                                              .ToList<Student>();
        }
        delegate bool IsTeenAger(Student stud);


        static Action<int> actionInt = myInt =>
        {
            var i = 0;
            Console.WriteLine(myInt.ToString());
        };
        static Func<string, string> func = (x) =>
        {
            Console.WriteLine(x.ToString());
            return x;
        };

        public class Student
        {

            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }
    }
}
