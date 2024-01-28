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


            // arraylist
            int intValue = 100;
            double doubleValue = 20.5;
            ArrayList arrayList = new ArrayList();
            arrayList.Add("John");
            arrayList.Add(intValue);
            arrayList.Add(doubleValue);
            for (int index = 0; index < arrayList.Count; index++)
                Console.WriteLine(arrayList[index]);


            // stack
            Stack stackObject = new Stack();
            stackObject.Push("Joydip");
            stackObject.Push("Steve");
            stackObject.Push("Jini");
            while (stackObject.Count > 0) Console.WriteLine(stackObject.Pop());
            Console.ReadLine();

            // queue
            Queue queueObject = new Queue();
            queueObject.Enqueue("Joydip");
            queueObject.Enqueue("Steve");
            queueObject.Enqueue("Jini");
            while (queueObject.Count > 0) Console.WriteLine(queueObject.Dequeue());
            Console.ReadLine();

            // Hashtable
            Hashtable hashTable = new Hashtable();
            hashTable.Add(1, "Joydip");
            hashTable.Add(2, "Manashi");
            hashTable.Add(3, "Jini");
            hashTable.Add(4, "Piku");
            Console.WriteLine("The keys and values are:");
            foreach (int k in hashTable.Keys)
            {
                Console.WriteLine(k);
                Console.WriteLine(hashTable[k].ToString());
            }

            // string builder | stringbuilder
            StringBuilder s = new StringBuilder("GeeksforGeeks");
            StringBuilder s1 = new StringBuilder("GeeksForGeeks", 20);
            s.Append("GFG");
            s.AppendLine("GEEKS");
            s.AppendFormat("{0:C} ", 50);
            s.Insert(6, "GEEKS");
            // remove starts from index 5 
            // and remove happes 3 index  
            // after index 5 
            s.Remove(5, 3);
            // Replace "GFG" with "Geeks For" 
            s.Replace("GFG", "Geeks For");

            // check if string is equal
            string s1 = "ProGeek 2.0";
            string s2 = "ProGeek 2.0";
            // Equals() method return true
            // as both string objects are equal
            Console.WriteLine(s1.Equals(s2));

            // check if string is equal
            string s1 = "ProGeek 2.0";
            string s2 = "ProGeek 2.0";
            // CompareTo() method return 0
            // as both string objects are equal
            Console.WriteLine(s1.CompareTo(s2));

            // anonymous types | anonymous object
            var student = new { Id = 1, FirstName = "James", LastName = "Bond" };

            // Nested Anonymous Type
            var student = new
            {
                Id = 1,
                FirstName = "James",
                LastName = "Bond",
                Address = new { Id = 1, City = "London", Country = "UK" }
            };


            // Array of Anonymous Types
            var students = new[] {
                        new { Id = 1, FirstName = "James", LastName = "Bond" },
                        new { Id = 2, FirstName = "Steve", LastName = "Jobs" },
                        new { Id = 3, FirstName = "Bill", LastName = "Gates" }
                };


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


    // Polymorphism: override -- dont forget to use 'virtual' and 'override' keywords | override keyword | method overriding
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

    // The yield Statement
    public class DaysOfTheWeek : System.Collections.IEnumerable
    {
        string[] m_Days = { "Sun", "Mon", "Tue", "Wed", "Thr", "Fri", "Sat" };
        public System.Collections.IEnumerator GetEnumerator()
        {
            for (int i = 0; i < m_Days.Length; i++)
            {
                yield return m_Days[i];
            }
        }
    }


    // Iterators: Example

    class TestDaysOfTheWeek
    {
        static void Main()
        {
            DaysOfTheWeek week = new DaysOfTheWeek();
            foreach (string day in week)
            {
                System.Console.Write(day + " ");
            }
        }
    }


    // Sealed class -- cannot be inherited
    sealed class SealedClass
    {

        // Calling Function
        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    // Define Generic Class
    class DataStore<T>
    {
        public T Data { get; set; }
    }

    // Generic Class with Multiple Type Parameters
    class KeyValuePair<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
    }





    // extension methods
    class Geek
    {

        // Method 1 
        public void M1()
        {
            Console.WriteLine("Method Name: M1");
        }

        // Method 2 
        public void M2()
        {
            Console.WriteLine("Method Name: M2");
        }

        // Method 3 
        public void M3()
        {
            Console.WriteLine("Method Name: M3");
        }

    }

    static class NewMethodClass
    {

        // Method 4 
        public static void M4(this Geek g)
        {
            Console.WriteLine("Method Name: M4");
        }

        // Method 5 
        public static void M5(this Geek g, string str)
        {
            Console.WriteLine(str);
        }
    }

    class MyClient
    {
        public static void Main()
        {
            try
            {
                throw new MyException(“Some error has happened");
            }
            catch (MyException e)
            {
                Console.WriteLine("Exception caught here" + e.ToString());
            }
            Console.WriteLine("LAST STATEMENT");
        }
    }

}


namespace GeeksForGeeks
{

    // declare class "Geeks"
    class Geeks
    {

        // Declaring the delegates
        // Here return type and parameter type should 
        // be same as the return type and parameter type
        // of the two methods
        // "addnum" and "subnum" are two delegate names
        public delegate void addnum(int a, int b);
        public delegate void subnum(int a, int b);

        // method "sum"
        public void sum(int a, int b)
        {
            Console.WriteLine("(100 + 40) = {0}", a + b);
        }

        // method "subtract"
        public void subtract(int a, int b)
        {
            Console.WriteLine("(100 - 60) = {0}", a - b);
        }

        // Main Method
        public static void Main(String[] args)
        {

            // creating object "obj" of class "Geeks"
            Geeks obj = new Geeks();

            // creating object of delegate, name as "del_obj1" 
            // for method "sum" and "del_obj2" for method "subtract" &
            // pass the parameter as the two methods by class object "obj"
            // instantiating the delegates
            addnum del_obj1 = new addnum(obj.sum);
            subnum del_obj2 = new subnum(obj.subtract);

            // pass the values to the methods by delegate object
            del_obj1(100, 40);
            del_obj2(100, 60);

            // These can be written as using
            // "Invoke" method
            // del_obj1.Invoke(100, 40);
            // del_obj2.Invoke(100, 60);
        }
    }

    class GFG
    {

        public delegate void petanim(string pet);

        // Main method 
        static public void Main()
        {

            // An lambda method with one parameter 
            petanim p = delegate (string mypet)
            {
                Console.WriteLine("My favorite pet is: {0}", mypet);
            };
            p("Dog");

            // An lambda method with one parameter 
            petanim p = delegate (string mypet) =>
            {
                Console.WriteLine("My favorite pet is: {0}", mypet);
            };
            p("Dog");


            // file reader, streamreader, stream reader
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("c:/jamaica.txt"))
                {
                    string line;

                    // Read and display lines from the file until 
                    // the end of the file is reached. 
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }

    // streamwriter, file writer, stream writer
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Zara Ali", "Nuha Ali" };

            using (StreamWriter sw = new StreamWriter("names.txt"))
            {

                foreach (string s in names)
                {
                    sw.WriteLine(s);
                }
            }

            // Read and show each line from the file.
            string line = "";
            using (StreamReader sr = new StreamReader("names.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            Console.ReadKey();
        }
    }


    // Binary reader, binaryreader, binarywriter, binary writer
    class Program
    {
        static void Main(string[] args)
        {
            BinaryWriter bw;
            BinaryReader br;

            int i = 25;
            double d = 3.14157;
            bool b = true;
            string s = "I am happy";

            //create the file
            try
            {
                bw = new BinaryWriter(new FileStream("mydata", FileMode.Create));
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot create file.");
                return;
            }

            //writing into the file
            try
            {
                bw.Write(i);
                bw.Write(d);
                bw.Write(b);
                bw.Write(s);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot write to file.");
                return;
            }
            bw.Close();

            //reading from the file
            try
            {
                br = new BinaryReader(new FileStream("mydata", FileMode.Open));
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot open file.");
                return;
            }

            try
            {
                i = br.ReadInt32();
                Console.WriteLine("Integer data: {0}", i);
                d = br.ReadDouble();
                Console.WriteLine("Double data: {0}", d);
                b = br.ReadBoolean();
                Console.WriteLine("Boolean data: {0}", b);
                s = br.ReadString();
                Console.WriteLine("String data: {0}", s);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot read from file.");
                return;
            }
            br.Close();
            Console.ReadKey();
        }
    }
}
