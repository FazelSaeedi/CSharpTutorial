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
            // System.Console.WriteLine("Hello world");


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
              |                                                 |             
              |                                                 |             
              |-------------------------------------------------|*/

            // Console.WriteLine("Please enter your name");


            // reading from the console (concatenation)
            // string FirstName = Console.ReadLine();
            // string LastName  = Console.ReadLine();


            // reading from the console (Place holder syntax)
            // Console.WriteLine("Hello {0} {1}" , FirstName , LastName );



            // End Part 2-----------------------------------------------------------------------



            /*|--------------------------------------------------
              |                                                 |
              |                     Part 3                      |
              |                Built - in types                 |
              |                                                 |
              |-------------------------------------------------|
              |                                                 |
              |                    boolean                      |
              |                    integer                      |
              |                    float                        |
              |                    decimal                      |
              |                                                 |             
              |-------------------------------------------------|*/

            // bool boolean =  true   ;
            // int     integer =  1      ;
            // float   Float   =  -5     ;
            // decimal Decimal =  10     ;


            // int i = 0;
            // Console.WriteLine("Min = {0}", int.MinValue);
            // Console.WriteLine("Min = {0}", int.MaxValue);


            // End Part 3-----------------------------------------------------------------------



            /*|--------------------------------------------------
              |                                                 |
              |                     Part 4                      |
              |             Built - in string types             |
              |                                                 |
              |-------------------------------------------------|
              |                                                 |
              |                                                 |
              |             Escape Sequences in C#              |
              |              Verbatim Literal                   |
              |                                                 |
              |                                                 |             
              |-------------------------------------------------|*/


            // string Name = "Fazel";
            // Console.WriteLine(Name);


            // Name = "\"Fazel\"";
            // Console.WriteLine(Name);


            // Name = "One\nTwo\nThree";
            // Console.WriteLine(Name);


            // without Verbatim
            // Name = "C:\\System\\Csharp\\Opp";
            // Console.WriteLine(Name);


            // with Verbatim
            // Name = @"C:\System\Csharp\Opp";
            // Console.WriteLine(Name);


            // End Part 4-----------------------------------------------------------------------


            /*|--------------------------------------------------
              |                                                 |
              |                     Part 5                      |
              |                Common operator                  |
              |                                                 |
              |-------------------------------------------------|
              |                                                 |
              |                                                 |
              |       Assignment - Arthimetic - Comparison      |
              |                   Conditional                   |
              |                                                 |
              |                                                 |             
              |-------------------------------------------------|*/

            // int i = 10 ;
            // int s = 2;
            // 
            // int Result = i * s; 
            // Result = i / s; 
            // Result = i % s; 
            // Result = i - s;
            // Result = i + s;
            // 
            // int Number = 10;


            // !=
            // &&
            // ||
            // <
            // >
            // >=
            // <=
            // if(Number != 10 )
            // {
            // 
            // }

            // ? -> if 
            // : -> else

            // bool IsNumber10 = Number == 10 ? true : false ;


            // End Part 5-----------------------------------------------------------------------


            /*|--------------------------------------------------
              |                                                 |
              |                     Part 6                      |
              |                 NUllable Types                  |
              |                                                 |             
              |-------------------------------------------------|
              |                                                 |
              | Value Types -> int , float , double , enums etc |                                       |
              |                                                 |
              |      Reference Types -> interface , Class       |
              |              , delegates , arrays               |     
              |                                                 |             
              |            Null Coalescing Operator             |             
              |                                                 |             
              |-------------------------------------------------|*/

            // by default value types are non nullable

            // int i = null ; it is false syntax

            // bool? AreYouMajor = null;
            // if (AreYouMajor == true) // true
            // {
            //     Console.WriteLine("user is  major ");
            // }
            // else if(!AreYouMajor.Value) // null
            // {
            //     Console.WriteLine("user is not major ");
            // }
            // else
            // {
            //     Console.WriteLine("user is did not answer the question ");
            // }
            // 
            // 
            // int? TicketsOnSale = 100;
            // // int? TicketsOnSale = null;
            // 
            // int AvaialableTicket;
            // 
            // if (TicketsOnSale == null)
            // {
            //     AvaialableTicket = 0;
            // }
            // else
            // {
            //     AvaialableTicket = (int)TicketsOnSale;
            // }
            // 
            // Console.WriteLine("AvaialableTicket = {0} " , AvaialableTicket);
            // 
            // int AvaialableTickets = TicketsOnSale ?? 0 ;
            // 
            // Console.WriteLine("AvaialableTicket = {0} ", AvaialableTicket);

            // End Part 6-----------------------------------------------------------------------


            /*|--------------------------------------------------
              |                                                 |
              |                     Part 7                      |
              |          Implicit & Explicit conversion         |
              |                                                 |             
              |-------------------------------------------------|
              |                                                 |        
              |     Implicit conversion is done by compiler     |                                               
              |                                                 |        
              |                Pars & Try Parse                 |        
              |                                                 |        
              |-------------------------------------------------|*/


            // float is a bigger datatype than int . so , no loss of data
            // and Exceptions . Hence implicit conversion
            // int i = 100;
            // float f = i; 



            // use explicit conversion using Convert class
            // float f = 123.45F;

            // use explicit conversion using cast () operator
            // int i = (int)f; // Cast operator 
            // int w = Convert.ToInt32(f);
            // Console.WriteLine(f);



            // string strNumber = "100G";
            // int i = int.Parse(strNumber);

            // int result = 0;

            // bool IsConversionSuccessful = int.TryParse(strNumber, out result);

            // if(IsConversionSuccessful)
            // {
            //     Console.WriteLine(result);
            // }
            // else
            // {
            //     Console.WriteLine("Please enter a valid number");
            // }

            // Difference between Parse and TryParse

            // if the number is int a string format you have 2 options - Pars() & TryPars()

            // parse () method throws an exception if it cannot parse the value  , whereas TryParse()
            // returns a bool indicationg whether it succeeded or failed 


            // Use Parse() if you are sure the value will be valid , itherwise use TryParse()




            // End Part 7-----------------------------------------------------------------------

            /*|--------------------------------------------------
              |                                                 |
              |                     Part 7                      |
              |                     Array                       |
              |                                                 |             
              |-------------------------------------------------|
              |                                                 |            
              |                                                 |            
              | An Array is a collection of similar data types  |            
              |                                                 |        
              |                                                 |        
              |      disadvantages  : Array cannot grow in      |
              |              size once initialized              |        
              |                                                 |        
              |                                                 |        
              |-------------------------------------------------|*/



            // int[] EvenNumbers = new int[3];
            // 
            // EvenNumbers[0] = 0;
            // EvenNumbers[1] = 1;
            // EvenNumbers[2] = 2;
            // 
            // 
            // Console.WriteLine(EvenNumbers[1]);


            // End Part 8 -----------------------------------------------------------------------


            /*|--------------------------------------------------
              |                                                 |
              |                     Part 9                      |
              |                    Comments                     |
              |                                                 |             
              |-------------------------------------------------|
              |                                                 |            
              |               Single line comments              |            
              |               Multi line comments               |            
              |                                                 |        
              |                                                 |        
              |-------------------------------------------------|*/


            // use // for line comment 

            // use /**/ for multiple comment 

            // use /// for summary and class documentation 



            // End Part 9 -----------------------------------------------------------------------


            /*|--------------------------------------------------
              |                                                 |
              |                    Part 10                      |
              |                   if statement                  |
              |                                                 |             
              |                                                 |             
              |-------------------------------------------------|
              |                                                 |            
              |              diffrent betwen | and ||           |            
              |              diffrent betwen & and &&           |            
              |                                                 |        
              |-------------------------------------------------|*/

            // ex 1 


            // Console.WriteLine("please enter a number ");
            // 
            // int UserNumber = int.Parse(Console.ReadLine());
            // 
            // if (UserNumber == 1)
            //     Console.WriteLine("Your Number is one");
            // else if(UserNumber == 2)
            //     Console.WriteLine("Your Number is Two");
            // else if (UserNumber != 1 && UserNumber != 2 && UserNumber != 3)
            //     Console.WriteLine("Your number is not between 1 and 3 ");


            //  | Boolean logical OR


            //  & Boolean logical AND


            // && check both condition  (AND)


            // || Or condition


            // End Part 10 -----------------------------------------------------------------------


        }
    }
}


