using System;

namespace CSharpTutorialP16_to18
{
    class Program
    {

        /*|--------------------------------------------------
          |                                                 |
          |                 Part 16 & 17                    |
          |                     method                      |
          |                                                 |
          |-------------------------------------------------| 
          |                                                 |
          |           Static & instance method              |
          |                                                 |
          |               method parameter                  |
          |                                                 |
          |                   namespace                     |
          |                                                 |
          |-------------------------------------------------|*/



        static void Main(string[] args)
        {
            Program.EvenNumbers(50);
            Program.MyMethod(10);

            // value parameters -> creates a copy of the parameter passed , so modifications does not affect each other .
            
            // refrence parameter : the ref method parameter keyword on a method parameter causes a method to refer to the same variable that was passed into the method .
            // Any changes made to the parameter inthe method will be reflected in that variable when control passes back to the calling method  

            int i = 0;
            SimpleMethod(ref i);
            Console.WriteLine(i);


            // out  use when you wnat a method to return more than one value 
            int Total = 0;
            int Product = 0;
            Calculate(10, 20, out Total, out Product);
            Console.WriteLine("Sum =  {0} && Product = {1}" , Total , Product);



            // param
            int[] Numbers = new int[3];
            Numbers[0] = 10;
            Numbers[1] = 11;
            Numbers[2] = 13;


            ParamsMethod(Numbers);
            ParamsMethod(1,2,3,4,5,6,7);
        }

        public static void ParamsMethod (params int[] Numbers)
        {
            Console.WriteLine("there are {0} specific elements ", Numbers.Length);
            foreach (int i in Numbers)
            {
                Console.WriteLine(i);
            }
        }
        public static void Calculate(int FN , int SN , out int Sum , out int Product)
        {
            Sum = FN + SN;
            Product = FN * SN;
        }

        public static void SimpleMethod(ref int j)
        {
            j = 110; 
        }

        public static void EvenNumbers(int target )
        {
            int start = 0;

            while(start <= target)
            {
                Console.WriteLine(start);
                start += 2;
            }
        }

        static int MyMethod(int x)
        {
            return 5 + x;
        }

        // End Part 16 & 17 -----------------------------------------------------------------------

    }
}
