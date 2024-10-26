using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Classes_and_objects1
{


    //    Assignment 1: Circle Class
    //    Problem Statement: Create a Circle class with a property for Radius.Implement a getter to
    //    retrieve the radius and a setter to ensure that the radius cannot be negative.


    //    public class Circle
    //    {
    //        private int radius;
    //        public int Radius
    //        {
    //            get { return radius; }
    //            set
    //            {
    //                if (value < 0)
    //                {

    //                    throw new ArgumentException("Radius is less than 0");
    //                }

    //                else
    //                {
    //                    radius = value;
    //                }
    //            }
    //        }
    //    }
    //}



    //    ----------------------------------------------------------------------------------------------------------------------------------------------------------------


    //     Assignment 2: Employee Class
    //    Problem Statement: Design an Employee class with properties for Name and Salary.Use
    //    getters and setters to manage access to the salary, ensuring it cannot be set to a negative value.

    //    public class Employee
    //    {
    //        private int salary;
    //        public string Name;
    //        public int Salary

    //        {
    //            get { return salary; }
    //            set
    //            {
    //                if (value < 0)
    //                {

    //                    throw new ArgumentException("Salary is less than 0");
    //                }

    //                else
    //                {
    //                    salary = value;
    //                }
    //            }
    //        }
    //    }
    //}





    //----------------------------------------------------------------------------------------------------------------------------------------------------------------







    //    Assignment 3: Library Management System
    //    Problem Statement: Design a library management system that manages books.Each book has a
    //    title, author, and ISBN number.The system should allow adding a book, removing a book, and
    //    displaying all books.


    //    public class Book
    //    {
    //        public string title;
    //        public string author;
    //        public string ISBN;

    //        public Book(string Title, string Author, string isbn)
    //        {
    //            title = Title;
    //            author = Author;
    //            ISBN = isbn;
    //        }

    //        public override string ToString()
    //        {
    //            return $"{title} by {author} {ISBN}";
    //        }
    //    }

    //    public class Library
    //    {
    //        private List<Book> books = new List<Book>();

    //        public void addBook(Book book)
    //        {
    //            books.Add(book);
    //        }

    //        public void RemoveBook(string isbn)
    //        {
    //            books.RemoveAll(b => b.ISBN == isbn);
    //        }

    //        public void DisplayBook()
    //        {
    //            foreach (var book in books)
    //            {
    //                Console.WriteLine(book);
    //            }
    //        }
    //    }
    //}




    //    ----------------------------------------------------------------------------------------------------------------------------------------------------------------





    //                Assignment 4: Banking System
    //    Problem Statement: Create a simple banking system that allows account creation and basic
    //    transactions.Each account has an account number, account holder name, and balance.Implement
    //    deposit and withdrawal methods.Use getters and setters to manage access to the balance,
    //    ensuring it cannot be set to a negative value. 


    //    public class BankAccount
    //    {
    //        public string AccountNumber { get; set; }
    //        public string Customer { get; set; }
    //        private decimal balance;

    //        public decimal Balance
    //        {
    //            get { return balance; }
    //            set
    //            {
    //                if (value < 0)
    //                {
    //                    throw new ArgumentException("\nZero Balance not allowed");
    //                }
    //                balance = value;
    //            }
    //        }

    //        public BankAccount(string accountnumber, string customer)
    //        {
    //            AccountNumber = accountnumber;
    //            Customer = customer;
    //            Balance = 0;
    //        }

    //        public void DepositMoney(decimal amount)
    //        {
    //            if (amount > 0)
    //            {
    //                Balance = Balance + amount;
    //                Console.WriteLine("\nDeposited amount = " + amount);
    //                Console.WriteLine("\nBalance amount = " + Balance);
    //            }
    //            else
    //            {
    //                Console.WriteLine("\nAmount must be above 0");
    //            }
    //        }
    //        public void Withdrawal(decimal amount)
    //        {
    //            if (amount > 0 && amount <= Balance)
    //            {
    //                Balance = Balance - amount;
    //                Console.WriteLine("\nWithdrawn amount = " + amount);
    //                Console.WriteLine("\nBalance amount = " + Balance);
    //            }
    //            else
    //            {
    //                Console.WriteLine("\nCannot withdraw the money");
    //            }
    //        }
    //    }
    //}




    //    ----------------------------------------------------------------------------------------------------------------------------------------------------------------





    //    Assignment 5: Student Management System
    //    Problem Statement: Develop a student management system that stores student details.Each
    //    student has a name, ID, and a list of grades.Implement methods to add a grade and calculate the
    //    average grade.



    //    public class Student
    //    {
    //        public string StudentName { get; set; }
    //        public int StudentID { get; set; }
    //        public List<int> Grades = new List<int>();

    //        public Student(string studentName, int studentID)
    //        {
    //            StudentName = studentName;
    //            StudentID = studentID;

    //        }

    //        public void addgrades(int grade)
    //        {
    //            if (grade > 0 && grade <= 100)
    //            {
    //                Grades.Add(grade);
    //                // Console.WriteLine("");
    //            }
    //            else
    //            {
    //                Console.WriteLine("Enter valid marks");
    //            }
    //        }


    //        public double Average()
    //        {
    //            if (Grades.Count == 0)
    //            {
    //                Console.WriteLine("No score entered");
    //            }

    //            int total = 0;
    //            foreach (int grade in Grades)
    //            {
    //                total += grade;
    //            }
    //            return (double)total / Grades.Count;
    //        }


    //        public void DisplayDetails()
    //        {
    //            Console.WriteLine("Name :" + StudentName + "\nStudent ID = " + StudentID);
    //            foreach (var student in Grades)
    //            {
    //                Console.WriteLine(student);
    //            }
    //        }

    //    }
    //}





    //    ----------------------------------------------------------------------------------------------------------------------------------------------------------------





    //                Assignment 6: Inventory System
    //    Problem Statement: Create an inventory management system that manages items in a store. 
    //    Each item has a name, stock, and price. Implement methods to add, remove, and update items. 
    //    Use getters and setters to manage access to the stock and price, ensuring it cannot be set to a
    //    negative value.


    //    public class Inventory
    //    {
    //        public string Name { get; set; }
    //        private int stock;
    //        private int price;

    //        public int Stock
    //        {
    //            get { return stock; }
    //            set
    //            {
    //                if (value >= 0)
    //                {
    //                    stock = value;
    //                }
    //                else
    //                {
    //                    Console.WriteLine("Stock cannot be negative.");
    //                }
    //            }
    //        }

    //        public int Price
    //        {
    //            get { return price; }
    //            set
    //            {
    //                if (value >= 0)
    //                {
    //                    price = value;
    //                }
    //                else
    //                {
    //                    Console.WriteLine("Price cannot be negative.");
    //                }
    //            }
    //        }

    //        public Inventory(string name, int stock, int price)
    //        {
    //            Name = name;
    //            Stock = stock;
    //            Price = price;
    //        }

    //        public override string ToString()
    //        {
    //            return $"Item: {Name}, Stock: {Stock}, Price: {Price}";
    //        }
    //    }

    //    public class Store
    //    {
    //        private List<Inventory> inventory = new List<Inventory>();

    //        public void AddItem(Inventory item)
    //        {
    //            inventory.Add(item);
    //        }

    //        public void RemoveItem(string name)
    //        {
    //            //add check
    //            inventory.RemoveAll(b => b.Name == name);
    //        }

    //        public void UpdateItem(string name, int newStock, int newPrice)
    //        {
    //            Inventory item = inventory.Find(b => b.Name == name);
    //            if (item != null)
    //            {
    //                item.Stock = newStock;
    //                item.Price = newPrice;
    //            }
    //            else
    //            {
    //                Console.WriteLine($"Item {name} not found.");
    //            }
    //        }

    //        public void DisplayItems()
    //        {
    //            foreach (var item in inventory)
    //            {
    //                Console.WriteLine(item);
    //            }
    //        }
    //    }
    //}






    //----------------------------------------------------------------------------------------------------------------------------------------------------------------







    //            Assignment 7: E - commerce System
    //Problem Statement: Design an e - commerce system that manages products and orders. Each
    //    product has a name, price, and stock quantity.Implement methods to create an order that reduces
    //    stock quantity. Implement getters and setters to ensure that the price cannot be negative and the
    //    stock cannot be less than zero.



    //    public class ECommerce
    //    {
    //        public string Name { get; set; }
    //        private int stock;
    //        private int price;


    //        public ECommerce(string name, int price, int stock)
    //        {
    //            Name = name;
    //            Price = price;
    //            Stock = stock;
    //        }

    //        public int Stock
    //        {
    //            get { return stock; }
    //            set
    //            {
    //                if (value >= 0)
    //                {
    //                    stock = value;
    //                }
    //                else
    //                {
    //                    Console.WriteLine("Stock cannot be negative.");
    //                }
    //            }
    //        }

    //        public int Price
    //        {
    //            get { return price; }
    //            set
    //            {
    //                if (value >= 0)
    //                {
    //                    price = value;
    //                }
    //                else
    //                {
    //                    Console.WriteLine("Price cannot be negative.");
    //                }
    //            }
    //        }

    //        public void CreateOrder(int quantity)
    //        {
    //            if (quantity > 0 && quantity <= stock)
    //            {
    //                stock -= quantity;
    //                Console.WriteLine($"{quantity} units of {Name} ordered successfully.");
    //            }
    //            else if (quantity > stock)
    //            {
    //                Console.WriteLine($"Not enough stock available. Only {stock} units left.");
    //            }
    //            else
    //            {
    //                Console.WriteLine("Invalid order quantity.");
    //            }
    //        }

    //        public void DisplayProduct()
    //        {
    //            Console.WriteLine($"Product: {Name}, Price: {Price}, Stock: {Stock}");
    //        }
    //    }

    //}





    //    ----------------------------------------------------------------------------------------------------------------------------------------------------------------





    //                Assignment 8: Print Class
    //    Problem Statement: Design a Print class that contains overloaded methods to print different
    //    types of data: a string, an integer, and an array of integers.



    //    public class Print
    //    {
    //        public void PrintData(string data)
    //        {
    //            Console.WriteLine("String: " + data);
    //        }

    //        public void PrintData(int data)
    //        {
    //            Console.WriteLine("Integer: " + data);
    //        }

    //        public void PrintData(int[] data)
    //        {
    //            Console.Write("Array of Integers: ");
    //            for (int i = 0; i < data.Length; i++)
    //            {
    //                Console.Write(data[i] + "  ");
    //            }
    //            Console.WriteLine();
    //        }
    //    }
    //}





    //    ----------------------------------------------------------------------------------------------------------------------------------------------------------------






    //    Assignment 9: Rectangle Class
    //    Problem Statement: Create a Rectangle class with overloaded methods to calculate the area.
    //    Implement methods that take either width and height or just one side length (for a square). 




    //    public class Rectangle
    //    {
    //        public int a;

    //        public int Length { get; set; }
    //        public int Bredth { get; set; }
    //        public int side { get; set; }

    //        public Rectangle(int length, int bredth)
    //        {
    //            Length = length;
    //            Bredth = bredth;
    //        }

    //        public Rectangle(int Side)
    //        {
    //            side = Side;
    //        }
    //        public void Area()
    //        {
    //            if (side > 0)
    //            {
    //                int a = side * side;
    //                Console.WriteLine("Square Area = " +a);
    //            }
    //            else
    //            {
    //                int a = Length * Bredth;
    //                Console.WriteLine("Rectangle Area = " + a);

    //            }
    //        }
    //        public void DisplayArea()
    //        {
    //            if (side > 0)
    //            {
    //                Console.WriteLine("Side = " + side);

    //            }
    //            else
    //            {
    //                Console.WriteLine("Length : " + Length + "\tBreadth : " + Bredth);
    //            }
    //        }
    //    }
    //}







    //    ----------------------------------------------------------------------------------------------------------------------------------------------------------------








    //        Assignment 10: Time Class
    //    Problem Statement: Create a Time class with overloaded methods to set the time.Implement
    //    methods to set the time using hours and minutes, and another method to set the time using 
    //    seconds. 



    //    public class Timer
    //    {
    //        public int seconds { get; set; }
    //        public int minutes { get; set; }
    //        public int hours { get; set; }


    //        public Timer(int Hours, int Minutes)
    //        {
    //            hours = Hours;
    //            minutes = Minutes;

    //        }

    //        public Timer(int Seconds)
    //        {
    //            seconds = Seconds;
    //            hours = seconds / 3600;
    //            minutes = (seconds % 3600) / 60;
    //            seconds = seconds % 60;
    //        }



    //        public void DisplayTime()
    //        {
    //            Console.WriteLine("Housr : Minutes : Seconds");
    //            Console.WriteLine("Time is : " + hours + ":" + minutes + ":" + seconds);
    //        }

    //    }
    //}








    //    ---------------------------------------------------------------------------------------------------------------------------------------------------------------






    //                Static and Instance Blocks


    //    Assignment 11: Initializing a Static Field
    //    Problem Statement: Create a class Bank that has a static field for the interest rate and a non
    //    static field for the account holder’s balance.Write a static constructor to initialize the interest
    //    rate to a default value and a regular constructor for setting up the account balance.


    //    public class Bank
    //    {
    //        public static double Interest { get; set; }
    //        // public double Balance;
    //        public int amount { get; set; }

    //        static Bank()
    //        {
    //            Interest = 9.5;
    //        }

    //        public Bank(int Amount)
    //        {
    //            amount = Amount;
    //            BalaceAmount();
    //        }

    //        public double BalaceAmount()
    //        {
    //            return amount + (amount * Interest);

    //        }

    //        public void Display()
    //        {
    //            Console.WriteLine("Amount : " + amount + "\tInterest rate : " + Interest);
    //        }
    //    }
    //}





    //    ---------------------------------------------------------------------------------------------------------------------------------------------------------------





    //                Assignment 12: Counting Objects with Static and Instance Fields
    //    Problem Statement: Create a class Car that counts how many instances of Car have been
    //    created using a static counter.Initialize this counter using a static constructor.




    //    public class Car
    //    {


    //        private static int Count;

    //        public string Name { get; set; }

    //        static Car()
    //        {
    //            Count = 0;
    //        }

    //        public Car(string name)
    //        {
    //            Name = name;
    //            Count++;
    //        }

    //        public static int CarCount()
    //        {
    //            return Count;
    //        }
    //    }

    //}



    //    ----------------------------------------------------------------------------------------------------------------------------------------------------------------






    //        Assignment 13: Initializing Constants with Static Block
    //    Problem Statement: Create a class MathOperations that initializes a static field representing the
    //    value of Pi.Write a static constructor to assign this value.

    //    public class MathOperations
    //    {
    //        public static double Pi;

    //        static MathOperations()
    //        {
    //            Pi = 3.14159;
    //        }
    //    }
    //}



    //    ----------------------------------------------------------------------------------------------------------------------------------------------------------------




    //    Assignment 14: Initializing Configuration with Static Constructor 
    //    Problem Statement: Create a class Configuration to load system-wide settings (e.g., application 
    //    name) using a static constructor.Allow individual users to set preferences using an instance
    //    constructor.


    //    public class Configuration
    //    {
    //        public static string ApplicationName;
    //        public string Preference;


    //        static Configuration()
    //        {
    //            ApplicationName = "ABCD";
    //        }

    //        public Configuration(string preference)
    //        {
    //            Preference = preference;
    //        }

    //        public void Display()
    //        {
    //            Console.WriteLine(" Application : " + ApplicationName);
    //            Console.WriteLine(" Prefernce : " + Preference);
    //        }

    //    }

    //}






    //    ----------------------------------------------------------------------------------------------------------------------------------------------------------------






    //            Assignment15: Implementing and Understanding Copy Constructor
    //    Problem Statement:
    //                Write a C# program that implements a copy constructor. The program should: 
    //    1.Create a class with several fields.
    //    2.Provide a constructor to initialize those fields.
    //    3. Provide a copy constructor that allows the creation of a new object from an existing
    //    object. 
    //    4. Demonstrate how the copy constructor works by comparing objects created using it with
    //    objects created via direct assignment(which just copies references). 




    //    public class Food
    //    {
    //        public String Name { get; set; }
    //        public int Rate { get; set; }


    //        public Food(String name, int rate)
    //        {
    //            Name = name;
    //            Rate = rate;
    //        }
    //        public Food(Food food)
    //        {
    //            Name = food.Name;
    //            Rate = food.Rate;
    //        }

    //        public void DisplayFood()
    //        {
    //            Console.WriteLine("Food Name : " + Name + "\nRate : " + Rate);
    //        }

    //    }

    //}





    //    ----------------------------------------------------------------------------------------------------------------------------------------------------------------







    //    Assignment 16: Identifying the Need for Chained Constructors 
    //    Tasks: 
    //    1.Create a class named Car with the following: 
    //    o Fields for make, model, year, and price. 
    //    o Multiple constructors: 
    //     A constructor that initializes only the make. 
    //     A constructor that initializes make and model. 
    //     A constructor that initializes make, model, and year. 
    //     A constructor that initializes all fields: make, model, year, and price. 
    //    o Use constructor chaining to avoid duplicating the logic for initializing fields. 
    //    2. In the Main() method: 
    //    o Create several Car objects using different constructors. 
    //    o Display the details of each car to verify that all fields are initialized correctly.



    //    public class Car
    //    {
    //        public string Make;
    //        public string Model;
    //        public int Year;
    //        public int Price;

    //        public Car(string Make)
    //        {
    //            this.Make = Make;
    //            this.Model = "Unknown";
    //            this.Year = 0;
    //            this.Price = 0;
    //        }

    //        public Car(string Make, string Model) : this(Make)
    //        {
    //            this.Model = Model;
    //        }

    //        public Car(string Make, string Model, int Year) : this(Make, Model)
    //        {
    //            this.Year = Year;
    //        }

    //        public Car(string Make, string Model, int Year, int Price) : this(Make, Model, Year)
    //        {
    //            this.Price = Price;
    //        }



    //        public void DisplayCars()
    //        {
    //            Console.WriteLine($"Make : +{Make},  Model : {Model} , Year : {Year} , Price : {Price}");
    //        }

    //    }
    //}




    //    ----------------------------------------------------------------------------------------------------------------------------------------------------------------






    //        Assignment 17: Understanding the Need for Constructor Overloading
    //    Problem Statement: 
    //    Write a C# program that models a Product class with overloaded constructors. The class should: 
    //    1. Provide flexibility in product initialization based on the availability of price and discount
    //    information.
    //    2. Use constructor overloading to handle cases where only basic product information is 
    //    available, as well as cases where detailed information(price and discount) is provided.
    //    Tasks: 
    //    1.Create a class named Product with the following: 
    //    o Fields for name, price, and discount.
    //    o Three constructors: 
    //     A constructor that initializes only the name.
    //     A constructor that initializes name and price.
    //     A constructor that initializes name, price, and discount. 
    //    2. Implement a method CalculateFinalPrice() that computes the final price after applying
    //    the discount (if applicable). 
    //    3. In the Main() method: 
    //    o Create different Product objects using various constructors.
    //    o Display the details of each product, including the final price after any applicable
    //    discount.


    //    public class Products
    //    {
    //        public string Name;
    //        public double Price;
    //        public double Discount;


    //        public Products(string name)
    //        {
    //            Name = name;
    //            Price = 0;
    //            Discount = 0;
    //            CalculateFinalPrice();

    //        }


    //        public Products(string name, double price)
    //        {
    //            Name = name;
    //            Price = price;
    //            Discount = 0;
    //            CalculateFinalPrice();

    //        }


    //        public Products(string name, double price, double discount)
    //        {
    //            Name = name;
    //            Price = price;
    //            Discount = discount;
    //            CalculateFinalPrice();
    //        }



    //        public double Amount = 0;
    //        public void CalculateFinalPrice()
    //        {

    //            if (Discount != 0)
    //            {
    //                Amount = Price - (Price * Discount / 100);
    //                //   Console.WriteLine("No Discount applicable");

    //            }
    //            //else
    //            //{
    //            //    Amount = Price - (Price * Discount / 100);
    //            //}
    //        }


    //        public void DisplayDetails()

    //        {
    //            Console.WriteLine("Name : " + Name + "\tPrice : " + Price + "\tDiscount : " + Discount + "\tFinal Amount : " + Amount);
    //        }



    //    }


    //}





    //    ----------------------------------------------------------------------------------------------------------------------------------------------------------------






    //    Assignment 18: Exploring Different Ways to Initialize Objects  
    //    Problem Statement: 
    //    Write a C# program that demonstrates different ways to initialize an object of a class. The class 
    //    should represent a Product with properties such as Name, Price, and Category. Implement the 
    //    following methods of object initialization: 
    //    1.Constructor initialization.
    //    2.Object initializer syntax. 
    //    3.Static factory method. 
    //    4.Anonymous types.
    //    5.Reflection.
    //    6.Default values in constructors. 
    //    Tasks: 
    //    1.Create a class named Product with the following: 
    //    o Properties for Name, Price, and Category. 
    //    o A constructor that initializes all three properties. 
    //    o A static method to create a Product object. 
    //    o Use reflection to dynamically create a Product object. 
    //    o Implement a constructor that provides default values for the properties. 
    //    2. In the Main() method: 
    //    o Create instances of the Product class using the different initialization techniques 
    //    mentioned above. 
    //    o Display the details of each product. 


    //    public class Product
    //    {

    //        public string Name { get; set; }
    //        public double Price { get; set; }
    //        public string Category { get; set; }

    //        public Product(string name, double price, string category)
    //        {
    //            Name = name;
    //            Price = price;
    //            Category = category;
    //        }

    //        public Product()
    //        {
    //            Name = "Default Product";
    //            Price = 0.0;
    //            Category = "General";
    //        }

    //        public static Product CreateProduct(string name, double price, string category)
    //        {
    //            return new Product(name, price, category);
    //        }

    //        public override string ToString()
    //        {
    //            return $"Name: {Name}, Price: {Price}, Category: {Category}";
    //        }
    //    }
    //}




    //    ----------------------------------------------------------------------------------------------------------------------------------------------------------------





    //                Assignment 19: Exploring Initialization Using Tuples and Records
    //    Problem Statement: 
    //    Write a C# program that demonstrates object initialization using tuples and records. Create a 
    //    simple model for Student with properties like Name, Age, and Grade.Use tuples and records to
    //    initialize and work with this model.
    //    Tasks: 
    //    1.Create a Student class using the record keyword with properties Name, Age, and Grade.
    //    2. Use tuples to store and retrieve student details. 
    //    3. Create a method that accepts a tuple as a parameter and returns a Student record.
    //    4. Display the details of the students. 

    //      NOT WORKING IN UPDATED VERSION ALSO







    //    ----------------------------------------------------------------------------------------------------------------------------------------------------------------







    //                Assignment 20: Shopping Cart
    //    Problem Statement: 
    //    You need to create a Shopping Cart class that holds a list of Product objects.The Product class
    //    will be a nested class. The system should allow users to add products to the cart and display the
    //    total price.
    //    Tasks: 
    //    1.Create a ShoppingCart class that contains:
    //o A list of Product objects.
    //    o Methods to add products and calculate the total price.
    //    2. Create a nested Product class with properties for Name, Price, and Quantity.
    //    3. Demonstrate adding products and displaying the total price in the Main() method.






    //    public class ShoppingCart
    //    {
    //        private List<Product> products = new List<Product>();

    //        public void AddProduct(string productName, double price, int quantity)
    //        {
    //            Product newProduct = new Product(productName, price, quantity);
    //            products.Add(newProduct);
    //            Console.WriteLine($"Product '{productName}' added with price {price} and quantity {quantity}.");
    //        }

    //        public double CalculateTotalPrice()
    //        {
    //            double totalPrice = 0;

    //            foreach (Product product in products)
    //            {
    //                totalPrice += product.Price * product.Quantity;
    //            }

    //            return totalPrice;
    //        }

    //        public class Product
    //        {
    //            public string Name { get; private set; }
    //            public double Price { get; private set; }
    //            public int Quantity { get; private set; }

    //            public Product(string name, double price, int quantity)
    //            {
    //                Name = name;
    //                Price = price;
    //                Quantity = quantity;
    //            }
    //        }
    //    }
    //}





    //----------------------------------------------------------------------------------------------------------------------------------------------------------------







    //            Assignment 21: Banking System
    //Problem Statement: 
    //You need to create a Bank class that contains a list of Customer objects.Each Customer can have
    //multiple Account objects (nested class). Implement methods to add customers, add accounts, and
    //display customer account details.
    //Tasks: 
    //1.Create a Bank class with :
    //o A list of Customer objects.
    //o Methods to add customers and accounts, and to display customer details.
    //2. Create a nested Customer class with properties for Name and a list of accounts.
    //3. Create a nested Account class with properties for AccountNumber and Balance.
    //4. Demonstrate the functionality in the Main() method.





    //    public class Bank
    //    {
    //        private List<Customer> customers = new List<Customer>();

    //        public void AddCustomer(string customerName)
    //        {
    //            Customer newCustomer = new Customer(customerName);
    //            customers.Add(newCustomer);
    //            Console.WriteLine($"Customer '{customerName}' added.");
    //        }

    //        public void AddAccount(string customerName, int accountNumber, decimal initialBalance)
    //        {
    //            Customer foundCustomer = customers.Find(c => c.Name == customerName);

    //            if (foundCustomer != null)
    //            {
    //                foundCustomer.AddAccount(accountNumber, initialBalance);
    //                Console.WriteLine($"Account '{accountNumber}' added to customer '{customerName}'.");
    //            }
    //            else
    //            {
    //                Console.WriteLine($"Customer '{customerName}' not found.");
    //            }
    //        }

    //        public void DisplayCustomerDetails()
    //        {
    //            Console.WriteLine("\nCustomer Account Details:");

    //            foreach (Customer customer in customers)
    //            {
    //                Console.WriteLine($"Customer: {customer.Name}");
    //                customer.DisplayAccounts();
    //            }
    //        }

    //        public class Customer
    //        {
    //            public string Name { get; private set; }  
    //            private List<Account> accounts = new List<Account>();  

    //            public Customer(string name)
    //            {
    //                Name = name;
    //            }

    //            public void AddAccount(int accountNumber, decimal balance)
    //            {
    //                Account newAccount = new Account(accountNumber, balance);
    //                accounts.Add(newAccount);
    //            }

    //            public void DisplayAccounts()
    //            {
    //                foreach (Account account in accounts)
    //                {
    //                    Console.WriteLine($"\tAccount Number: {account.AccountNumber}, Balance: {account.Balance:C}");
    //                }
    //            }

    //            public class Account
    //            {
    //                public int AccountNumber { get; private set; }
    //                public decimal Balance { get; private set; }

    //                public Account(int accountNumber, decimal balance)
    //                {
    //                    AccountNumber = accountNumber;
    //                    Balance = balance;
    //                }
    //            }
    //        }
    //    }
    //}




    //----------------------------------------------------------------------------------------------------------------------------------------------------------------




    //            Assignment 22: University System
    //Problem Statement: 
    //You need to create a University class that holds a list of Department objects.Each Department
    //can have multiple Course objects (nested class). Implement methods to add departments, add
    //courses, and display course information.
    //Tasks: 
    //1.Create a University class with :
    //o A list of Department objects.
    //o Methods to add departments and courses, and to display course details.
    //2. Create a nested Department class with properties for Name and a list of courses.
    //3. Create a nested Course class with properties for CourseName, CourseCode, and Credits.
    //4. Demonstrate the functionality in the Main() method.



    public class University
    {
        private List<Department> departments = new List<Department>();

        public void AddDepartment(string name)
        {
            departments.Add(new Department(name));
            Console.WriteLine($"Department '{name}' added.");
        }

        public void AddCourse(string departmentName, string courseName, string courseCode, int credits)
        {
            var department = departments.Find(d => d.Name == departmentName);
            if (department != null)
            {
                department.AddCourse(courseName, courseCode, credits);
                Console.WriteLine($"Course '{courseName}' added to department '{departmentName}'.");
            }
            else
            {
                Console.WriteLine($"Department '{departmentName}' not found.");
            }
        }


        public void DisplayCourseDetails()
        {
            Console.WriteLine("\nCourse Details:");
            foreach (var department in departments)
            {
                Console.WriteLine($"Department: {department.Name}");
                department.DisplayCourses();
            }
        }

        public class Department
        {
            public string Name { get; set; }
            private List<Course> courses = new List<Course>();

            public Department(string name)
            {
                Name = name;
            }

            public void AddCourse(string courseName, string courseCode, int credits)
            {
                courses.Add(new Course(courseName, courseCode, credits));
            }

            public void DisplayCourses()
            {
                foreach (var course in courses)
                {
                    Console.WriteLine($"\tCourse Name: {course.CourseName}, Code: {course.CourseCode}, Credits: {course.Credits}");
                }
            }

            public class Course
            {
                public string CourseName { get; set; }
                public string CourseCode { get; set; }
                public int Credits { get; set; }

                public Course(string courseName, string courseCode, int credits)
                {
                    CourseName = courseName;
                    CourseCode = courseCode;
                    Credits = credits;
                }
            }
        }

    }
}
