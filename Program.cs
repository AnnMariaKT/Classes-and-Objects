using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Classes_and_objects1
{
    public class Program
    {
        static void Main(string[] args)
        {

            //            Assignment 1: Circle Class
            //             Problem Statement: Create a Circle class with a property for Radius.Implement a getter to
            //             retrieve the radius and a setter to ensure that the radius cannot be negative.

            //            try
            //            {
            //                Circle circle = new Circle();
            //                circle.Radius = 5;
            //                Console.WriteLine("Radius = " + circle.Radius);

            //                Circle circle1 = new Circle();
            //                circle1.Radius = -2;
            //                Console.WriteLine("Radius = " + circle1.Radius);

            //            }
            //            catch (ArgumentException ex)
            //            {
            //                Console.WriteLine(ex.Message);
            //            }


            //            Console.ReadLine();

            //        }
            //    }
            //}


            //            ---------------------------------------------------------------------------------------------------------------------------------------------------------------



            //            Assignment 2: Employee Class
            //            Problem Statement: Design an Employee class with properties for Name and Salary.Use
            //            getters and setters to manage access to the salary, ensuring it cannot be set to a negative value.

            //            try
            //            {
            //                Employee employee = new Employee();
            //                employee.Name = "John";
            //                employee.Salary = 25000;
            //                Console.WriteLine("SALARY = " + employee.Salary);

            //                Employee employee1 = new Employee();
            //                employee1.Salary = -100;
            //                Console.WriteLine("SALARY = " + employee1.Salary);

            //            }
            //            catch (ArgumentException ex)
            //            {
            //                Console.WriteLine(ex.Message);
            //            }


            //            Console.ReadLine();
            //        }
            //    }
            //}





            //---------------------------------------------------------------------------------------------------------------------------------------------------------------





            //    Assignment 3: Library Management System
            //            Problem Statement: Design a library management system that manages books.Each book has a
            //            title, author, and ISBN number.The system should allow adding a book, removing a book, and
            //            displaying all books.




            //            Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", "123456");
            //            Book book2 = new Book("1984", "George Orwell", "654321");
            //            Book book3 = new Book("To Kill a Mockingbird", "Harper Lee", "111222");

            //            Library library = new Library();

            //            library.addBook(book1);
            //            library.addBook(book2);
            //            library.addBook(book3);

            //            Console.WriteLine("Library books:");
            //            library.DisplayBook();

            //            Console.WriteLine("\nRemoving book with ISBN 654321:");
            //            library.RemoveBook("654321");

            //            Console.WriteLine("\nLibrary books after removal:");
            //            library.DisplayBook();



            //            Console.ReadLine();
            //        }
            //    }
            //}



            //---------------------------------------------------------------------------------------------------------------------------------------------------------------




            //            Assignment 4: Banking System
            //            Problem Statement: Create a simple banking system that allows account creation and basic
            //            transactions.Each account has an account number, account holder name, and balance.Implement
            //            deposit and withdrawal methods.Use getters and setters to manage access to the balance,
            //            ensuring it cannot be set to a negative value. 



            //            BankAccount money = new BankAccount("11223344", "ABCD");
            //            Console.WriteLine("Name : " + money.Customer);
            //            Console.WriteLine("Avvount NUmber : " + money.AccountNumber);

            //            money.DepositMoney(1000);
            //            money.Withdrawal(5000);


            //            Console.ReadLine();
            //        }
            //    }
            //}

            //---------------------------------------------------------------------------------------------------------------------------------------------------------------



            //            Assignment 5: Student Management System
            //            Problem Statement: Develop a student management system that stores student details.Each
            //            student has a name, ID, and a list of grades.Implement methods to add a grade and calculate the
            //            average grade.

            //            Student student = new Student("ABC", 101);
            //            student.addgrades(89);
            //            student.addgrades(85);
            //            student.addgrades(84);
            //            student.DisplayDetails();

            //            double average = student.Average();
            //            Console.WriteLine("Average score = " + average);

            //            Student student1 = new Student("ABC", 101);
            //            student1.addgrades(90);
            //            student1.addgrades(87);
            //            student1.addgrades(80);
            //            student1.DisplayDetails();
            //            double average1 = student1.Average();
            //            Console.WriteLine("Average score = " + average1);


            //            Console.ReadLine();
            //        }
            //    }
            //}




            //---------------------------------------------------------------------------------------------------------------------------------------------------------------


            //            Assignment 6: Inventory System
            //            Problem Statement: Create an inventory management system that manages items in a store. 
            //            Each item has a name, stock, and price. Implement methods to add, remove, and update items. 
            //            Use getters and setters to manage access to the stock and price, ensuring it cannot be set to a
            //            negative value.


            //            Store store = new Store();

            //            store.AddItem(new Inventory("Apple", 50, 10));
            //            store.AddItem(new Inventory("Banana", 100, 5));

            //            Console.WriteLine("Inventory:");
            //            store.DisplayItems();

            //            store.UpdateItem("Apple", 30, 12);

            //            Console.WriteLine("\nUpdated Inventory:");
            //            store.DisplayItems();

            //            store.RemoveItem("Banana");

            //            Console.WriteLine("\nAfter removing Banana:");
            //            store.DisplayItems();
            //            Console.ReadLine();
            //        }
            //    }
            //}

            //---------------------------------------------------------------------------------------------------------------------------------------------------------------


            //            Assignment 7: E - commerce System
            //Problem Statement: Design an e - commerce system that manages products and orders. Each
            //            product has a name, price, and stock quantity.Implement methods to create an order that reduces
            //            stock quantity. Implement getters and setters to ensure that the price cannot be negative and the
            //            stock cannot be less than zero.




            //            ECommerce product = new ECommerce("Laptop", 1000, 10);

            //            product.DisplayProduct();
            //            product.CreateOrder(3);
            //            product.DisplayProduct();

            //            product.CreateOrder(8);

            //            product.Stock = -5;
            //            product.Price = -100;

            //            Console.ReadLine();
            //        }
            //    }
            //}

            //            ---------------------------------------------------------------------------------------------------------------------------------------------------------------


            //                        Assignment 8: Print Class
            //            Problem Statement: Design a Print class that contains overloaded methods to print different
            //            types of data: a string, an integer, and an array of integers.



            //            Print printer = new Print();

            //            printer.PrintData("Hello, World!");

            //            printer.PrintData(42);

            //            int[] numbers = { 1, 2, 3, 4, 5 };
            //            printer.PrintData(numbers);

            //            Console.ReadLine();
            //        }
            //    }
            //}


            //            ---------------------------------------------------------------------------------------------------------------------------------------------------------------



            //            Assignment 9: Rectangle Class
            //            Problem Statement: Create a Rectangle class with overloaded methods to calculate the area.
            //            Implement methods that take either width and height or just one side length (for a square). 




            //            Rectangle rectangle = new Rectangle(20, 10);
            //            rectangle.DisplayArea();
            //            rectangle.Area();

            //            Rectangle square = new Rectangle(25);
            //            square.DisplayArea();
            //            rectangle.Area();


            //            Console.ReadLine();
            //        }
            //    }

            //}

            //            ---------------------------------------------------------------------------------------------------------------------------------------------------------------





            //            Assignment 10: Time Class
            //            Problem Statement: Create a Time class with overloaded methods to set the time.Implement
            //            methods to set the time using hours and minutes, and another method to set the time using
            //            seconds.


            //            Timer timer1 = new Timer(11, 25);
            //            Timer timer2 = new Timer(3600);

            //            timer1.DisplayTime();
            //            timer2.DisplayTime();

            //            Console.ReadLine();
            //        }
            //    }
            //}








            //            ---------------------------------------------------------------------------------------------------------------------------------------------------------------


            //                        Static and Instance Blocks


            //            Assignment 11: Initializing a Static Field
            //            Problem Statement: Create a class Bank that has a static field for the interest rate and a non
            //            static field for the account holder’s balance.Write a static constructor to initialize the interest
            //            rate to a default value and a regular constructor for setting up the account balance.

            //            Bank bank = new Bank(2000);
            //            double B = bank.BalaceAmount();

            //            bank.Display();
            //            Console.WriteLine("Balance Amount = " + B);

            //            Console.ReadLine();
            //        }
            //    }
            //}





            //            ---------------------------------------------------------------------------------------------------------------------------------------------------------------





            //                        Assignment 12: Counting Objects with Static and Instance Fields
            //            Problem Statement: Create a class Car that counts how many instances of Car have been
            //            created using a static counter.Initialize this counter using a static constructor.





            //            Car car1 = new Car("Hyundai");
            //            Car car2 = new Car("Volkswagen");
            //            Car car3 = new Car("BMW");

            //            Console.WriteLine("Total number of Car instances created: " + Car.CarCount());

            //            Console.ReadLine();
            //        }
            //    }
            //}



            //            ---------------------------------------------------------------------------------------------------------------------------------------------------------------





            //                Assignment 13: Initializing Constants with Static Block
            //            Problem Statement: Create a class MathOperations that initializes a static field representing the
            //            value of Pi.Write a static constructor to assign this value.




            //            Console.WriteLine("Value of Pi: " + MathOperations.Pi);

            //            Console.ReadLine();
            //        }
            //    }
            //}


            //            ---------------------------------------------------------------------------------------------------------------------------------------------------------------



            //            Assignment 14: Initializing Configuration with Static Constructor 
            //            Problem Statement: Create a class Configuration to load system-wide settings (e.g., application 
            //            name) using a static constructor.Allow individual users to set preferences using an instance
            //            constructor.



            //            Configuration configuration = new Configuration("Hello");
            //            configuration.Display();

            //            Configuration configuration1 = new Configuration("World");
            //            configuration1.Display();
            //            Console.ReadLine();
            //        }
            //    }
            //}


            //            ---------------------------------------------------------------------------------------------------------------------------------------------------------------



            //                    Assignment15: Implementing and Understanding Copy Constructor
            //            Problem Statement:
            //                        Write a C# program that implements a copy constructor. The program should: 
            //            1.Create a class with several fields.
            //            2.Provide a constructor to initialize those fields.
            //            3. Provide a copy constructor that allows the creation of a new object from an existing
            //            object. 
            //            4. Demonstrate how the copy constructor works by comparing objects created using it with
            //            objects created via direct assignment(which just copies references). 



            //            Food food = new Food("Roti", 25);
            //            Food food3 = food;
            //            food3.Name = "Chicken";
            //            food3.Rate = 100;
            //            food3.DisplayFood();

            //            Food food1 = new Food(food);
            //            food.DisplayFood();

            //            food1.Name = "Spinach";
            //            food1.Rate = 200;
            //            food1.DisplayFood();

            //            food.DisplayFood();





            //            Console.ReadLine();
            //        }
            //    }
            //}


            //            ---------------------------------------------------------------------------------------------------------------------------------------------------------------




            //            Assignment 16: Identifying the Need for Chained Constructors 
            //            Tasks: 
            //            1.Create a class named Car with the following: 
            //            o Fields for make, model, year, and price. 
            //            o Multiple constructors: 
            //             A constructor that initializes only the make. 
            //             A constructor that initializes make and model. 
            //             A constructor that initializes make, model, and year. 
            //             A constructor that initializes all fields: make, model, year, and price. 
            //            o Use constructor chaining to avoid duplicating the logic for initializing fields. 
            //            2. In the Main() method: 
            //            o Create several Car objects using different constructors. 
            //            o Display the details of each car to verify that all fields are initialized correctly.



            //            Car car1 = new Car("Volkswagen");
            //            Car car2 = new Car("BMW", "i series");
            //            Car car3 = new Car("Honda", "City", 2023);
            //            Car car4 = new Car("Hyundai", "Verena", 2024, 250000);

            //            Console.WriteLine("Car 1 details");
            //            car1.DisplayCars();

            //            Console.WriteLine("Car 2 details");
            //            car2.DisplayCars();

            //            Console.WriteLine("Car 3 details");
            //            car3.DisplayCars();

            //            Console.WriteLine("Car 4 details");
            //            car4.DisplayCars();

            //            Console.ReadLine();
            //        }
            //    }
            //}




            //            ---------------------------------------------------------------------------------------------------------------------------------------------------------------







            //                Assignment 17: Understanding the Need for Constructor Overloading
            //            Problem Statement: 
            //            Write a C# program that models a Product class with overloaded constructors. The class should: 
            //            1. Provide flexibility in product initialization based on the availability of price and discount
            //            information.
            //            2. Use constructor overloading to handle cases where only basic product information is 
            //            available, as well as cases where detailed information(price and discount) is provided.
            //            Tasks: 
            //            1.Create a class named Product with the following: 
            //            o Fields for name, price, and discount.
            //            o Three constructors: 
            //             A constructor that initializes only the name.
            //             A constructor that initializes name and price.
            //             A constructor that initializes name, price, and discount. 
            //            2. Implement a method CalculateFinalPrice() that computes the final price after applying
            //            the discount (if applicable). 
            //            3. In the Main() method: 
            //            o Create different Product objects using various constructors.
            //            o Display the details of each product, including the final price after any applicable
            //            discount.


            //            Products products = new Products("Laptop");
            //            Products products2 = new Products("Mouse", 25.50);
            //            Products products3 = new Products("Keyboard", 100.00, 25);


            //            Console.WriteLine("Product 1");
            //            products.DisplayDetails();
            //            Console.WriteLine("Product 2");
            //            products2.DisplayDetails();
            //            Console.WriteLine("Product 3");
            //            products3.DisplayDetails();

            //            Console.ReadLine();
            //        }
            //    }
            //}





            //            ---------------------------------------------------------------------------------------------------------------------------------------------------------------






            //            Assignment 18: Exploring Different Ways to Initialize Objects  
            //            Problem Statement: 
            //            Write a C# program that demonstrates different ways to initialize an object of a class. The class 
            //            should represent a Product with properties such as Name, Price, and Category. Implement the 
            //            following methods of object initialization: 
            //            1.Constructor initialization.
            //            2.Object initializer syntax. 
            //            3.Static factory method. 
            //            4.Anonymous types.
            //            5.Reflection.
            //            6.Default values in constructors. 
            //            Tasks: 
            //            1.Create a class named Product with the following: 
            //            o Properties for Name, Price, and Category. 
            //            o A constructor that initializes all three properties. 
            //            o A static method to create a Product object. 
            //            o Use reflection to dynamically create a Product object. 
            //            o Implement a constructor that provides default values for the properties. 
            //            2. In the Main() method: 
            //            o Create instances of the Product class using the different initialization techniques 
            //            mentioned above. 
            //            o Display the details of each product. 





            //            // 1. Constructor Initialization
            //            Product product1 = new Product("Laptop", 999.99, "Electronics");
            //            Console.WriteLine("Constructor Initialization:");
            //            Console.WriteLine(product1);

            //            // 2. Object Initializer Syntax
            //            Product product2 = new Product
            //            {
            //                Name = "Smartphone",
            //                Price = 699.99,
            //                Category = "Electronics"
            //            };
            //            Console.WriteLine("\nObject Initializer Syntax:");
            //            Console.WriteLine(product2);

            //            // 3. Static Factory Method
            //            Product product3 = Product.CreateProduct("Tablet", 499.99, "Electronics");
            //            Console.WriteLine("\nStatic Factory Method:");
            //            Console.WriteLine(product3);

            //            // 4. Anonymous Type
            //            var anonymousProduct = new { Name = "Headphones", Price = 199.99, Category = "Accessories" };
            //            Console.WriteLine("\nAnonymous Type:");
            //            Console.WriteLine($"Name: {anonymousProduct.Name}, Price: {anonymousProduct.Price}, Category: {anonymousProduct.Category}");

            //            // 5. Reflection
            //            Product product4 = (Product)Activator.CreateInstance(typeof(Product), "Smart Watch", 299.99, "Wearables");
            //            Console.WriteLine("\nReflection:");
            //            Console.WriteLine(product4);

            //            // 6. Default values in constructor
            //            Product product5 = new Product();
            //            Console.WriteLine("\nDefault Constructor with Default Values:");
            //            Console.WriteLine(product5);

            //            Console.ReadLine();
            //        }
            //    }
            //}


            //            ---------------------------------------------------------------------------------------------------------------------------------------------------------------





            //Assignment 19: Exploring Initialization Using Tuples and Records
            //            Problem Statement: 
            //            Write a C# program that demonstrates object initialization using tuples and records. Create a 
            //            simple model for Student with properties like Name, Age, and Grade.Use tuples and records to
            //            initialize and work with this model.
            //            Tasks: 
            //            1.Create a Student class using the record keyword with properties Name, Age, and Grade.
            //            2. Use tuples to store and retrieve student details. 
            //            3. Create a method that accepts a tuple as a parameter and returns a Student record.
            //            4. Display the details of the students. 

            //              NOT WORKING IN UPDATED VERSION ALSO





            //            ---------------------------------------------------------------------------------------------------------------------------------------------------------------





            //                        Assignment 20: Shopping Cart
            //            Problem Statement: 
            //            You need to create a Shopping Cart class that holds a list of Product objects.The Product class
            //            will be a nested class. The system should allow users to add products to the cart and display the
            //            total price.
            //            Tasks: 
            //            1.Create a ShoppingCart class that contains:
            //o A list of Product objects.
            //            o Methods to add products and calculate the total price.
            //            2. Create a nested Product class with properties for Name, Price, and Quantity.
            //            3. Demonstrate adding products and displaying the total price in the Main() method.





            //            ShoppingCart myCart = new ShoppingCart();

            //            myCart.AddProduct("Apple", 1.50, 3);
            //            myCart.AddProduct("Bread", 2.00, 2);
            //            myCart.AddProduct("Milk", 1.75, 1);

            //            double total = myCart.CalculateTotalPrice();
            //            Console.WriteLine($"\nTotal Price of all products: {total}");

            //            Console.ReadLine();
            //        }
            //    }
            //}




            //            ---------------------------------------------------------------------------------------------------------------------------------------------------------------





            //                Assignment 21: Banking System
            //    Problem Statement: 
            //    You need to create a Bank class that contains a list of Customer objects.Each Customer can have
            //    multiple Account objects (nested class). Implement methods to add customers, add accounts, and
            //    display customer account details.
            //    Tasks: 
            //    1.Create a Bank class with :
            //    o A list of Customer objects.
            //    o Methods to add customers and accounts, and to display customer details.
            //    2. Create a nested Customer class with properties for Name and a list of accounts.
            //    3. Create a nested Account class with properties for AccountNumber and Balance.
            //    4. Demonstrate the functionality in the Main() method.



            //            Bank myBank = new Bank();

            //            myBank.AddCustomer("Alice");
            //            myBank.AddCustomer("Bob");

            //            myBank.AddAccount("Alice", 1001, 5000.00m);
            //            myBank.AddAccount("Alice", 1002, 1500.50m);
            //            myBank.AddAccount("Bob", 1003, 3000.75m);

            //            myBank.DisplayCustomerDetails();

            //            Console.ReadLine();
            //        }
            //    }
            //}



            //            ---------------------------------------------------------------------------------------------------------------------------------------------------------------





            //                Assignment 22: University System
            //    Problem Statement: 
            //    You need to create a University class that holds a list of Department objects.Each Department
            //    can have multiple Course objects (nested class). Implement methods to add departments, add
            //    courses, and display course information.
            //    Tasks: 
            //    1.Create a University class with :
            //    o A list of Department objects.
            //    o Methods to add departments and courses, and to display course details.
            //    2. Create a nested Department class with properties for Name and a list of courses.
            //    3. Create a nested Course class with properties for CourseName, CourseCode, and Credits.
            //    4. Demonstrate the functionality in the Main() method.






            University university = new University();

            university.AddDepartment("Computer Science");
            university.AddDepartment("Mathematics");

            university.AddCourse("Computer Science", "Data Structures", "CS101", 4);
            university.AddCourse("Computer Science", "Algorithms", "CS102", 3);
            university.AddCourse("Mathematics", "Calculus I", "MATH101", 4);
            university.AddCourse("Mathematics", "Linear Algebra", "MATH102", 3);

            university.DisplayCourseDetails();

            Console.ReadLine();
        }
    }
}






