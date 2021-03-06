using System;
using System.Runtime.Serialization;

namespace CSharpTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Car myObj = new Car("Mustang");
            Console.WriteLine(myObj.color);


            // Create a myCar object
            Car myCar = new Car("Mustang");

            // Call the honk() method (From the Vehicle class) on the myCar object
            myCar.honk();

            // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
            Console.WriteLine(myCar.brand + " " + myCar.modelName);



            Animal myAnimal = new Animal();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();


            Pig myPig1 = new Pig();  // Create a Pig object
            myPig.animalSound();

            DemoClass myObj1 = new DemoClass();
            myObj1.myMethod();
            myObj1.myOtherMethod();



            // a deligate is a type safe function pointer 
            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
            del("Hello from Delegate");

            // multi cast deligate
            TestDeleGate td = new TestDeleGate();
            TestDeleGate.ShowMessage message = null;
            message += new TestDeleGate.ShowMessage(td.message1);
            message += new TestDeleGate.ShowMessage(td.message2);
            message += new TestDeleGate.ShowMessage(td.message3);
            message("Hello Multicast Delegates");
            message -= new TestDeleGate.ShowMessage(td.message2);
            Console.WriteLine("----------------------");
            message("Message 2 Removed");





            // Exceptions

            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong.");
            }
            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
            }

            
            try
            {
                throw new UserAlreadyLoggedInException("User is not valid");
            }
            catch(UserAlreadyLoggedInException ex)
            {
                Console.WriteLine(ex.Message);
            }


        // Enum
        Level myVar = Level.Medium;
        Console.WriteLine(myVar);


        Level myVar11 = Level.Medium;
        switch (myVar)
        {
            case Level.Low:
                Console.WriteLine("Low level");
                break;
            case Level.Medium:
                Console.WriteLine("Medium level");
                break;
            case Level.High:
                Console.WriteLine("High level");
                break;
        }




        Console.WriteLine(WeekDays.Friday); //output: Friday 
        int day = (int)WeekDays.Friday; // enum to int conversion
        Console.WriteLine(day); //output: 4 
		
        var wd = (WeekDays)5; // int to enum conversion
        Console.WriteLine(wd);//output: Saturday 

            string[] Names = Enum.GetNames(typeof(WeekDays));

            foreach (int i in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(i);
            }



            Season s1 = Season.Spring;
            Season s2 = Season.Autumn;

            Console.WriteLine(s1);
            Console.WriteLine(s2);

            Console.WriteLine("----------------------");

            Console.WriteLine(s1.GetType());
            Console.WriteLine(Enum.GetUnderlyingType(s1.GetType()));
        }
        enum Level{Low,Medium,High}
        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        enum Season : byte
        {
            Spring = 1,
            Summer = 2,
            Autumn = 3,
            Winter = 4
        }

        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }


    }

    public class UserAlreadyLoggedInException : Exception
    {
        public UserAlreadyLoggedInException() : base() { }
        public UserAlreadyLoggedInException(string message ) : base(message)
        {
            
        }

        public UserAlreadyLoggedInException(string message , Exception innerException) : base (message , innerException)
        {

        }

        public UserAlreadyLoggedInException( SerializationInfo info , StreamingContext context) : base(info, context)
        {

        }
    }
    
    public delegate void HelloFunctionDelegate(string Message);
    class TestDeleGate
    {
        public delegate void ShowMessage(string s);
        public void message1(string msg)
        {
            Console.WriteLine("1st Message is : {0}", msg);
        }
        public void message2(string msg)
        {
            Console.WriteLine("2nd Message is : {0}", msg);
        }
        public void message3(string msg)
        {
            Console.WriteLine("3rd Message is : {0}", msg);
        }
    }

    public class Vehicle  // base class (parent) 
    {
        public string brand = "Ford";  // Vehicle field
        public void honk()             // Vehicle method 
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }

    public class Car : Vehicle
    {
        public string modelName;  // Create a field
        public string color = "red";


        private string name; // field

        public string Name   // property
        {
            get { return name; }   // get method
            set { name = value; }  // set method
        }

        /*
         
        public	The code is accessible for all classes

        private	The code is only accessible within the same class

        protected	The code is accessible within the same class, or in a class that is inherited from that class.

        internal	The code is only accessible within its own assembly, but not from another assembly. 
         */

        // Create a class constructor for the Car class
        public Car(string Model)
        {
            modelName = Model; // Set the initial value for model
        }


        // Destructor
        ~Car()
        {
            // your code
        }



    }


    public class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("ParentClass Constructor called");
        }

        public ParentClass(string Message)
        {
            Console.WriteLine(Message);
        }
    }

    public class ChildClass : ParentClass
    {
        public ChildClass() : base ("Hi this is my message")
        {
            Console.WriteLine("childClass Constructor called");
        }
    }


    // polymorphis 

    // overwriting

    class Animal  // Base class (parent) 
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }


    // overloading 
    public class Methodoveloading
    {
        public int add(int a, int b)  //two int type Parameters method  
        {
            return a + b;

        }
        public int add(int a, int b, int c)  //three int type Parameters with same method same as above  
        {
            return a + b + c;

        }
        public float add(float a, float b, float c, float d)  //four float type Parameters with same method same as above two method 
        {
            return a + b + c + d;

        }
    }


    // getter && setter 

    class Person
    {
        private string name; // field

        public string Name   // property
        {
            get { return name; }   // get method
            set { name = value; }  // set method
        }
    }



    // struct diffrent with class

    // use when we want create many instance 

    // class is refrence type 
    // struct is a value type
    // in struct fields dose not get value 
    // in struct dose not need type new struct (ta zamani ke meghdar nadim fazaii to hafeze ekhtesas nmide )
    // struct dose not has destructor
    // struct dose not accept inheritance

    // constructor in struct should have at least one parameter



    // Interface
    public interface IAnimal
    {
        public void animalSound(); // interface method (does not have a body)
    }

    // Pig "implements" the IAnimal interface
    public class hours : IAnimal
    {
        public void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: ishi ishi wee");
        }
    }


    // Implement multiple interfaces
    interface IFirstInterface
    {
        void myMethod(); // interface method
    }

    interface ISecondInterface
    {
        void myOtherMethod(); // interface method
    }

    // Implement multiple interfaces
    class DemoClass : IFirstInterface, ISecondInterface
    {
        public void myMethod()
        {
            Console.WriteLine("Some text..");
        }
        public void myOtherMethod()
        {
            Console.WriteLine("Some other text...");
        }
    }


    // diffrent of abstract and interface 
    // https://www.dntips.ir/post/2884/%D8%AA%D9%81%D8%A7%D9%88%D8%AA-%D8%A8%DB%8C%D9%86-interface-%D9%88-%DA%A9%D9%84%D8%A7%D8%B3-abstract-%D8%AF%D8%B1-%DA%86%DB%8C%D8%B3%D8%AA



    
}
