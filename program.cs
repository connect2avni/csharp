using System;
using System.Linq;

namespace Container
{
    class Program
    {
        // class variable | class member
        private string name; // field

        public string Name   // property
        {
            get { return name; }   // get method
            set { name = value; }  // set method
        }

        // enums | enum
        public enum Level
        {
            Low,
            Medium,
            High
        }

        enum Level
        {
            Low,
            Medium,
            High
        }

        // property
        public string name2 { get; set; }

        // constructor
        public Program()
        {
            name = "Avni";
        }

        // Create a class constructor with a parameter
        public Program(string name)
        {
            name = name;
        }

        public static void Main(string[] args)
        {

            // Data Types
            int myNum = 5;               // integer (whole number)
            double myDoubleNum = 5.99D;  // floating point number
            char myLetter = 'D';         // character
            bool myBool = true;          // boolean
            string myText = "Hello";     // string
            Console.WriteLine(myNum);
            Console.WriteLine(myDoubleNum);
            Console.WriteLine(myLetter);
            Console.WriteLine(myBool);
            Console.WriteLine(myText);




            Level myVar = Level.Medium;
            Console.WriteLine(myVar);


            // Type Casting
            // Implicit Type Casting
            int myInt = 9;
            double myDouble = myInt;       // Automatic casting: int to double
            Console.WriteLine(myInt);      // Outputs 9
            Console.WriteLine(myDouble);   // Outputs 9

            // Explicit Type Casting
            double myDouble = 9.78;
            int myInt = (int)myDouble;    // Manual casting: double to int
            Console.WriteLine(myDouble);   // Outputs 9.78
            Console.WriteLine(myInt);      // Outputs 9

            // Type Casting Functions
            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string


            // user input
            string userName = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());



            // Math'
            Math.Max(5, 10); // 10
            Math.Min(5, 10); // 5
            Math.Sqrt(64); // 8
            Math.Abs(-4.7); // 4.7
            Math.Round(9.99); // 10


            // string functions
            string txt = "Hello World";
            Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD"
            Console.WriteLine(txt.ToLower());   // Outputs "hello world"
            Console.WriteLinestring.Concat("abc", "123"));   // Outputs "abc123"
            string x = "10";
            string y = "20";
            string z = x + y;  // z will be 1020 (a string)

            // string interpolation
            string firstName = "John";
            string lastName = "Doe";
            string name = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name);

            // string
            string myString = "Hello";
            Console.WriteLine(myString[0]);  // Outputs "H"
            Console.WriteLine(myString.IndexOf("e"));  // Outputs "1"

            // Full name
            string name = "John Doe";
            // Location of the letter D
            int charPos = name.IndexOf("D");
            // Get last name
            string lastName = name.Substring(charPos);
            // Print the result
            Console.WriteLine(lastName); // output: Doe

            // escape sequence
            string txt = "We are the so-called \"Vikings\" from the north.";


            // switch
            int day = 4;
            switch (day)
            {
                case 6:
                    Console.WriteLine("Today is Saturday.");
                    break;
                case 7:
                    Console.WriteLine("Today is Sunday.");
                    break;
                default:
                    Console.WriteLine("Looking forward to the Weekend.");
                    break;
            }
            // Outputs "Looking forward to the Weekend."


            // switch case using enum
            Level myVar = Level.Medium;
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

            // while loop
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }


            // do while loop
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 5);

            // for loop
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            // for each loop | foreach
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }


            // array
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(cars[0]);
            // Outputs Volvo


            // Sort a string
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Array.Sort(cars);
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }


            // Sort an int
            int[] myNumbers = { 5, 1, 8, 9 };
            Array.Sort(myNumbers);
            foreach (int i in myNumbers)
            {
                Console.WriteLine(i);
            }

            // add 'using System.Linq'
            Console.WriteLine(myNumbers.Max());  // returns the largest value
            Console.WriteLine(myNumbers.Min());  // returns the smallest value
            Console.WriteLine(myNumbers.Sum());  // returns the sum of elements

            // Multidimentional Array, md array
            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };

            // access md array element
            Console.WriteLine(numbers[0, 2]);  // Outputs 2

            // modify array |  change array | modify or change array
            numbers[0, 0] = 5;  // Change value to 5
            Console.WriteLine(numbers[0, 0]); // Outputs 5 instead of 1


            // loop through 2D array | md array, multidimensional array
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.WriteLine(numbers[i, j]);
                }
            }


            // method overloading | same method name but different signature
            // call a method, invoke a static method
            MyMethod();

            // call a method, invoke a static parameters method
            MyMethod("hello");

            // call a method, invoke a static parameters method
            MyMethod("hello", 123);

            // call a method
            int num = MyMethod(4);

            // named parameter, named arguments
            MyMethod(child3: "John", child1: "Liam", child2: "Liam");


            // creating an object
            Program myObj = new Program();
            Console.WriteLine(myObj.myNum);

            // multiple objects
            Program obj1 = new Program();
            Program obj2 = new Program();

            // modify/change object value
            obj1.myNum = 10;

            // call a function in object / call a method in object
            obj1.fullThrottle();


            int num = 23;         // value type is int and assigned value 23
            Object Obj = num;    // Boxing
            int i = (int)Obj;    // Unboxing

        }

        // method overloading | same method name but different signature
        // static method
        static void MyMethod()
        {
            Console.WriteLine("I just got executed!");
        }

        // method overloading | same method name but different signature
        // static parametered method | parameter | parameters
        static void MyMethod(string fname)
        {
            Console.WriteLine(fname + " Refsnes");
        }

        // method overloading | same method name but different signature
        // static parametered method | parameter | parameters
        static void MyMethod(string fname, int age)
        {
            Console.WriteLine(fname + " is " + age);
        }

        // default parameter value | optional parameter
        static void MyMethod(string country = "Norway")
        {
            Console.WriteLine(country);
        }

        // return a int value from method
        static int MyMethod(int x)
        {
            return 5 + x;
        }

        // named parameter, named arguments
        static void MyMethod(string child1, string child2, string child3)
        {
            Console.WriteLine("The youngest child is: " + child3);
        }

        // non static method function
        public void fullThrottle()    // method
        {
            Console.WriteLine("The car is going as fast as it can!");
        }

    }


    // inheritance
    class Vehicle  // base class (parent) 
    {
        public string brand = "Ford";  // Vehicle field
        public void honk()             // Vehicle method 
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }

    // inheritance
    class Car : Vehicle  // derived class (child)
    {
        public string modelName = "Mustang";  // Car field
    }








    // Polymophism -- without override it doesnot work-- search for 'override'
    class Animal  // Base class (parent) 
    {
        public void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal  // Derived class (child) 
    {
        public void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog : Animal  // Derived class (child) 
    {
        public void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }


    }


    // Polymorphism: override -- dont forget to use 'virtual' and 'override' keywords
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


    // Abstract class | Abstraction
    abstract class Animal
    {
        // Abstract method (does not have a body)
        public abstract void animalSound();
        // Regular method
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    // Derived class (inherit from Animal)
    class Pig : Animal
    {
        public override void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }



    // Interface
    interface IAnimal
    {
        void animalSound(); // interface method (does not have a body)
    }

    // Pig "implements" the IAnimal interface
    class Pig : IAnimal
    {
        public void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }

}