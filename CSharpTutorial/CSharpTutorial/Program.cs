using System;

namespace CSharpTutorial
{
    class Program
    {
        static void Main(string[] args)
        {


            /*|-------------------------------------------------|
              |                                                 |
              |                    Part 1                       |
              |            Using System declaration             |
              |                                                 |
              |-------------------------------------------------|
              |                                                 |
              |                                                 |
              |     The namespace declaration . usingSystem     |  
              |     indicates that you are using the system     |
              |     namespace                                   |
              |                                                 |
              |     A namespace is used to organize your code   |
              |     and is collection of classes , interfaces   |
              |     ,structs , enums and delegates.             |   
              |                                                 |
              |-------------------------------------------------|
              |                                                 |
              |     Main method is the entry point into your    |
              |      application                                |
              |                                                 |
              ---------------------------------------------------*/


            // Write to console
            //System.Console.WriteLine("Hello world");


            // End Part 1-----------------------------------------------------------------------


            /*|--------------------------------------------------
              |                                                 |
              |                    Part 2                       |
              |                                                 |
              |-------------------------------------------------|
              |                                                 |
              |                                                 |
              |           Reading from the console              | 
              |                                                 |            
              |                                                 |            
              |           Writing to the console                |
              |              a. concatenation                   |
              |              a. Place holder syntax             |
              |                                                 |              |                                                 |
              |                                                 |              |                                                 |
              |-------------------------------------------------|*/

            Console.WriteLine("Please enter your name");


            // reading from the console (concatenation)
            string FirstName = Console.ReadLine();
            string LastName  = Console.ReadLine();


            // reading from the console (Place holder syntax)
            Console.WriteLine("Hello {0},{1}" , FirstName , LastName );




            // End Part 2-----------------------------------------------------------------------
        }
    }
}


