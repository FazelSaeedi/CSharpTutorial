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


            /*|--------------------------------------------------
              |                                                 |
              |                    Part 11                      |         
              |                Switch Statement                 |             
              |                                                 |             
              |-------------------------------------------------|
              |                                                 |            
              |       Multiple if else statements can be        |
              |         replaced woth a swutch statement        |            
              |                                                 |        
              |-------------------------------------------------|*/

            // ex1 
            // int nitem = 5;
            // switch (nitem)
            // {
            // 
            //     case 1:
            //         Console.WriteLine("case 1");
            //         break;
            // 
            //     case 5:
            //         Console.WriteLine("case 5");
            //         break;
            // 
            //     case 9:
            //         Console.WriteLine("case 9");
            //         break;
            // 
            //     default:
            //         Console.WriteLine("No match found");
            //         break;
            // }




            // ex 2  (multiple case statement)
            // int i = 5;
            // 
            // switch (i)
            // {
            //     case int n when (n >= 7):
            //         Console.WriteLine($"I am 7 or above: {n}");
            //         break;
            // 
            //     case int n when (n >= 4 && n <= 6):
            //         Console.WriteLine($"I am between 4 and 6: {n}");
            //         break;
            // 
            //     case int n when (n <= 3):
            //         Console.WriteLine($"I am 3 or less: {n}");
            //         break;
            // }



            // End Part 11 -----------------------------------------------------------------------




            /*|--------------------------------------------------
              |                                                 |
              |                    Part 12                      |         
              |           Switch Statement continued            |             
              |                                                 |             
              |-------------------------------------------------|
              |                                                 |            
              |      break statement & gotostatement            |            
              |                                                 |            
              |-------------------------------------------------|*/

            // int TotalCoffeeCost = 0 ;
            // 
            // Start:
            // Console.WriteLine("Please Select tour offe size +: 1 - Small , 2 - Medium , 3 - Large ");
            // int UserChoise = int.Parse(Console.ReadLine());
            // 
            // switch (UserChoise)
            // {
            //     case 1:
            //         TotalCoffeeCost += 1;
            //         break;
            // 
            //     case 2:
            //         TotalCoffeeCost += 2;
            //         break;
            // 
            //     case 3:
            //         TotalCoffeeCost += 3;
            //         break;
            //     default:
            //         Console.WriteLine("Your choise {0} is invalid ", UserChoise);
            //         goto Start;
            // }
            // 
            // Decide:
            // Console.WriteLine("Do you want to buy another coffe - Yes or No ? ");
            // string UserDecision = Console.ReadLine();
            // 
            // switch (UserDecision.ToUpper())
            // {
            //     case "YES":
            //         goto Start;
            //     case "NO":
            //         break;
            //     default:
            //         Console.WriteLine("Your choise {0} is invalid . Please try again ... ", UserDecision);
            //         goto Decide;
            // }
            // 
            // Console.WriteLine("Thank you for shooping with us ");
            // Console.WriteLine("Bill Amount = {0} ,", TotalCoffeeCost);


            // End Part 12 -----------------------------------------------------------------------




            /*|--------------------------------------------------
              |                                                 |
              |                 Part 13 & 14                    |    
              |                  while loop                     |            
              |-------------------------------------------------|    
              |                                                 |            
              |-------------------------------------------------|*/


            // int i = 0;
            // while (i < 5)
            // {
            //     Console.WriteLine(i);
            //     i++;
            // }



            /* Tip
            while Do 
            1 While loop checks the condition first 
            2. if the condition is true , statements with in the loop are executed 
            3. this process repeated as long as the condition evaluated totrue 
             
             */

            /* Tip
            DO while
            1. A do loop checks its condition at the end of the loop .
            2. this means that the do loop is guaranteed to execute at least one time . 
            3. Do loops are used to present a menu to the user .

             */

            /*Diffrent between while && do while 
            
            1. While loop checks the condition at the beginning , where as do while loop checks the condition at the end of the loop 
            2. Do loop is guaranteed to eecute at least once , where as while loop is not .

             */


            // while do 
            // int i = 0;
            // do
            // {
            //     Console.WriteLine(i);
            //     i++;
            // }
            // while (i < 5);

            // End Part 13 & 14 -----------------------------------------------------------------------





            /*|--------------------------------------------------
              |                                                 |
              |                  Part 15                        |    
              |              for & foreach loop                 |            
              |-------------------------------------------------|    
              |                                                 |            
              |-------------------------------------------------|*/

            int length = 100;
            for (int index = 1; index < length; index++)
            {
                //Your code will be here  
                //This is how a programmer makes century.....#ilovecricket  
            }


            int[] Numbers = { 1, 2, 3, 4, 5, 6 };

            foreach (int item in Numbers)
            {
                // do something
            }



            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }


            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            // End Part 15 -----------------------------------------------------------------------

        }
    }
}


