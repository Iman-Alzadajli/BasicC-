# 🌟 C# Basics –With Examples :)

This project is a simple and introduction to **C# programming** for beginners. It covers the most important topics you need to start coding with C#

---

## 📘 Topics Covered

### ✅ Variables
- **Purpose**: Store data for later use.
- **Example**:  
  ```csharp
  string name = "Iman";
  Console.WriteLine(name);

### ✅ Data Types 
- **Purpose**: Define the kind of data a variable holds (int,string..etc).
- **Example**:  
  ```csharp
  string name = "Iman";
  Console.WriteLine(name);
  // DATA TYPES
   int a = 10;             // Whole number
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



 ### ✅ Math Operators
- **Purpose**: Perform basic math
- **Example**:  
  ```csharp
  int result = 5 + 3;
  int result = 5 - 3 ;
  int result = 10 / 3 ;
  int result = 2*2;
  int result = 2 % 10;
  
✅ Increment & Decrement
Purpose: Increase or decrease a number
  ```csharp
 int a = 5;

        Console.WriteLine("Original a: " + a);  // 5

        // Post-increment
        Console.WriteLine("Post-increment a++: " + (a++));  // 5, then a becomes 6
        Console.WriteLine("After a++ a is: " + a);          // 6

        // Pre-increment
        Console.WriteLine("Pre-increment ++a: " + (++a));   // a becomes 7, then prints 7
        Console.WriteLine("After ++a a is: "
```

✅ Condition (if/else)
Purpose: Make decisions based on true/false
```
int age = 18;
if (age >= 18)
    Console.WriteLine("Adult");
else
    Console.WriteLine("Minor");

```

✅ Looping
Purpose: Repeat code multiple times

#using for loop
```
for (int i = 1; i <= 5; i++)
    Console.WriteLine(i); // print from 1 to 5

```

#using while loop

```
int i = 10;

while (i >= 6)
{
    Console.WriteLine(i);
    i--; // print from 10 to 6 
}

```

#do...while

```
int i = 1;
do
{
    Console.WriteLine(i);
    i++;
} while (i <= 3);  //print 1 to 3

```

#foreach 
foreach (datatype variable in collection)
```
string[] names = { "Iman", "Sara", "Laila" };

foreach (string name in names)
{
    Console.WriteLine(name);
}
```

✅ Function (Method)
Purpose: Group code that does a task and reuse it
```
void Greet()
{
    Console.WriteLine("Hello, Iman!");
}
Greet();  // Call the function

```
```
internal class Program
    {
        // This is a function that adds two numbers
        static void AddNumbers(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine("The sum is: " + sum);
        }

        static void Main(string[] args)
        {
            // Call the function
            AddNumbers(5, 3);  // Output: The sum is: 8
            AddNumbers(10, 20); // Output: The sum is: 30
        }
    }

```

✅ Delegate
Purpose: Store methods in variables and call them dynamically
```
delegate void MyDelegate();
MyDelegate d = Greet;
d();  // Calls Greet method

```

✅ OOP (Object-Oriented Programming)
Purpose: Organize code using objects and classes (real-world style)
```
class Car {
    public string model = "BMW";
}
Car myCar = new Car();
Console.WriteLine(myCar.model);

```

✅ Access Modifiers
Purpose: Control who can access parts of your code
```
public class Person {
    private string name = "Iman";  // Only accessible inside this class
}

```
