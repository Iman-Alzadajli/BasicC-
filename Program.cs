using System;

namespace BasicC_
{
    internal class Program
    {
        // Function to use in delegate
        static void Greet()
        {
            Console.WriteLine("Hello, Iman!");
        }

        static void Main(string[] args)
        {
            // VARIABLES
            string name = "Iman";
            Console.WriteLine(name);

            // DATA TYPES
            int a = 10;             // Whole number
            float q = 10.5f;        // Decimal with less precision
            double b = 10.5;        // More precise decimal
            decimal c = 10.5m;      // Precise for money
            char d = 'a';           // Single character
            bool e = true;          // True or false
            byte f = 255;           // 0 to 255
            short speed = 120;      // Small number

            object anything = "Hello";       // Can store any type
            var city = "Muscat";             // Automatically detects type
            var age = 20;

            dynamic data = 5;                // Type changes at runtime
            data = "Now it's text";

            DateTime today = DateTime.Now;   // Stores date & time

            // MATH OPERATORS
            int total = 5 + 3;
            Console.WriteLine("Total: " + total);

            // INCREMENT & DECREMENT
            int x = 5;
            x++;  // x = 6
            x--;  // x = 5 again

            // CONDITION
            int age1 = 18;
            if (age1 >= 18)
                Console.WriteLine("Adult");
            else
                Console.WriteLine("Minor");

            // LOOPING
            for (int i = 1; i <= 5; i++)
                Console.WriteLine(i);

            // FUNCTION
            Greet(); // Call function

            // OOP + ACCESS MODIFIERS
            Car myCar = new Car();
            Console.WriteLine(myCar.model);  // Access public variable

            // DELEGATE
         //   MyDelegate d = Greet;
          //  d(); // Call method using delegate
        }
    }

    // DELEGATE DEFINITION
    delegate void MyDelegate();

    // CLASS (OOP)
    public class Car
    {
        public string model = "BMW";       // public: accessible everywhere
        private string owner = "Iman";     // private: only inside this class
    }
}
