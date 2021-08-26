using System;
using System.Data;

namespace Calculator
{
    public class Calculator : baseCalculator.baseCalculator
    {
        

        protected override string HistoryAddress { get; set; }
        protected new enum Method { separate , expression }
        protected new enum Action { history , finish , wrong}


        public Calculator(string HistoryAddress)
        {
            this.HistoryAddress = HistoryAddress;
            CreateFile();
            Console.WriteLine("Wellcome to my sudo calculator program");
        }

        public override void Run()
        {
            bool isAnyAction = true;
            while (this.ExitStatus.Equals(false))
            {

                while ( isAnyAction == true )
                {
                    
                    this.initializer();


                    string keyPress = Console.ReadKey(true).Key.ToString();
                    switch(keyPress)
                    {

                        case "F1":
                            this.Decition = Method.expression.ToString();
                            break;

                        case "F2":
                            this.Decition = Method.separate.ToString();
                            break;

                        case "F3":
                            this.Decition = Action.history.ToString();
                            break;

                        case "F4":
                            this.Decition = Action.finish.ToString();
                            break;
                        default:
                            this.Decition = Action.wrong.ToString(); 
                            break;

                    }



                    if (Decition.Equals(Method.expression.ToString()))
                    {
                        Console.WriteLine("please enter your expression");
                        this.Input = Console.ReadLine().ToLower().Trim();


                        while(isExpressionSingleChar(this.Input))
                        {
                            Console.WriteLine("your expression is wrong");
                            Console.WriteLine("please enter your expression again");
                            this.Input = Console.ReadLine().ToLower().Trim();
                        }

                       
                        try
                        {
                            this.Result = Convert.ToDouble(new DataTable().Compute(this.Input, null));
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        isAnyAction = true;
                        this.Appendresult(this.Result.ToString());
                    }
                    else if (Decition.Equals(Method.separate.ToString()))
                    {

                        double Sresult = 0;
                        bool moreThanTwoNumber = false;
                        Console.WriteLine("Enter your number");

                        double Num1;
                        bool   isNumberdouble = double.TryParse(Console.ReadLine().ToLower().Trim(), out Num1) ? true : false ;
                        
                        while(!isNumberdouble)
                        {
                            Console.WriteLine("Your Number is wrong ");
                            Console.WriteLine("Enter your Number again");
                            isNumberdouble = double.TryParse(Console.ReadLine().ToLower().Trim(), out Num1) ? true : false ;
                        }



                        Console.WriteLine("Enter your operator");
                        string Soperator = Console.ReadLine().ToLower().Trim();
                        
                        while (isOperatorWrong(Soperator))
                        {
                            Console.WriteLine("Your operator is wrong ");
                            Console.WriteLine("Enter your operator again");
                            Soperator = Console.ReadLine().ToLower().Trim();
                        }



                        Console.WriteLine("Enter your number");
                        double Num2;
                        isNumberdouble = double.TryParse(Console.ReadLine().ToLower().Trim(), out Num2) ? true : false;

                        while (!isNumberdouble)
                        {
                            Console.WriteLine("Your Number is wrong ");
                            Console.WriteLine("Enter your Number again");
                            isNumberdouble = double.TryParse(Console.ReadLine().ToLower().Trim(), out Num2) ? true : false;
                        }

                        while (isDivideByZero(Soperator, Num2))
                        {
                            Console.WriteLine("Your number is Zero and it is wrong ");
                            Console.WriteLine("Enter your number again");
                            Num2 = Convert.ToDouble(Console.ReadLine().ToLower().Trim());
                        }
                        
                        this.Result = Sresult = calculate(Soperator , Num1 , Num2);


                        
                        this.Result = calculate(Soperator, Num1, Num2);
                        Console.WriteLine("----------------------------------------------------------" +
                            "\n F1 = HISTORY | F2 = Exit Seperate | F3 = Enter More than two number ");
                        string SkeyPress = Console.ReadKey(true).Key.ToString();

                        switch (SkeyPress)
                        {

                            case "F1":
                                Console.Clear();
                                Appendresult(Sresult.ToString());
                                Console.WriteLine(DisplayResult() + "\n" + "----------------------------------------------------------");
                                break;

                            case "F2":
                                moreThanTwoNumber = false;
                                this.ExitStatus = true;
                                break;

                            case "F3":
                                moreThanTwoNumber = true;
                                break;
                        }

                        while (moreThanTwoNumber)
                        {


                            Console.WriteLine("Enter your operator");
                            Soperator = Console.ReadLine().ToLower().Trim();

                            while (isOperatorWrong(Soperator))
                            {
                                Console.WriteLine("Your operator is wrong ");
                                Console.WriteLine("Enter your operator again");
                                Soperator = Console.ReadLine().ToLower().Trim();
                            }

                            Console.WriteLine("Enter your number");
                            isNumberdouble = double.TryParse(Console.ReadLine().ToLower().Trim(), out Num1) ? true : false;

                            while (!isNumberdouble)
                            {
                                Console.WriteLine("Your Number is wrong ");
                                Console.WriteLine("Enter your Number again");
                                isNumberdouble = double.TryParse(Console.ReadLine().ToLower().Trim(), out Num1) ? true : false;
                            }


                            while (isDivideByZero(Soperator, Num1))
                            {
                                Console.WriteLine("Your number is Zero and it is wrong ");
                                Console.WriteLine("Enter your number again");
                                Num1 = Convert.ToDouble(Console.ReadLine().ToLower().Trim());
                            }
                            Sresult = calculate(Soperator , Sresult , Num1);


                            Console.WriteLine("----------------------------------------------------------" +
                           "\n F1 = HISTORY | F2 = Exit Seperate | F3 = Enter More than two number ");
                            SkeyPress = Console.ReadKey(true).Key.ToString();

                            switch (SkeyPress)
                            {

                                case "F1":
                                    Appendresult(Sresult.ToString());
                                    Console.WriteLine(DisplayResult() + "\n" + "----------------------------------------------------------");
                                    moreThanTwoNumber = false;
                                    break;

                                case "F2":
                                    moreThanTwoNumber = false;
                                    this.ExitStatus = true;
                                    break;

                                case "F3":
                                    continue;

                                default:
                                    break;
                            }

                        }

                    }
                    else if (Decition.Equals(Action.finish.ToString()))
                    {
                        isAnyAction = false;
                        this.ExitStatus = true;
                        break;
                    }
                    else if (Decition.Equals(Action.history.ToString()))
                    {
                        Console.Clear();
                        Console.WriteLine(DisplayResult() + "\n" + "----------------------------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine("Your choise is not correct please re-try");
                        isAnyAction = true;
                    }

                }

            }

        }

        protected void initializer()
        {
            Console.WriteLine("Please choose enterance method separate or expression" +
                "\nF1 = EXPRESSION | F2 = SEPARATE |  F3 = HISTORY | F4 = FINISH \n" +
                "--------------------------------------------------------------------");
        }

        protected double calculate(string Operator , double Num1 , double Num2)
        {

            double result = 0;
            switch(Operator)
            {

                case "+":
                    result =  Num1 + Num2;
                    break;

                case "-":
                    result = Num1 - Num2;
                    break;

                case "*":
                    result = Num1 * Num2;
                    break;

                case "/":
                    result = Num1 / Num2;
                  break;

            }
            return result; 

        }

        protected bool isDivideByZero( string Operator, double num )
        {

            if (Operator == "/" && num == 0)
                return true;


            return false ;

        }

        protected bool isOperatorWrong(string Operator)
        {
            string Operators = "+*-/";
            if (!Operators.Contains(Operator))
                return true;

            return false;
        }

        protected bool isExpressionSingleChar(string expression)
        {

            if (expression.Length <= 1)
                return true;


            return false;
        }



    }

}






