/*using System.Security;
class program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);
        }
        Console.ReadKey();
    }
}*/

/*using System.Security;
class program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        foreach (int i in numbers )
        {
            Console.WriteLine(i);
        }
        Console.ReadKey();
    }
}*/


/*using System.Runtime.InteropServices;

class clockType
{
    public int hours;
    public int minutes;
    public int seconds;
    public clockType()
    {

        hours = 0;
        minutes = 0;
        seconds = 0;

    }
    public clockType(int h)
    {

        hours = h;
    }

    public clockType(int h, int m)
    {
        hours = h;
        minutes = m;
    }


    public clockType(int h, int m, int s)
    {

        hours = h;
        minutes = m;
        seconds = s;
    }




    public void incrementSecond()
    {

        seconds++;

    }
    public void incrementhours()
    {

        hours++;
    }


    public void incrementminutes()
    {
        minutes++;

    }



    public void printTime()
    {
        Console.WriteLine(hours + " " + minutes + " " + seconds);
    }

    public bool isEqual(int h, int m, int s)
    {

        if (hours == h && minutes == m && seconds == s)
        {
            return true;
        }
        else
        {

            return false;

        }

    }



    public bool isEqual(clockType temp)
    {

        if (hours == temp.hours && minutes == temp.minutes && seconds == temp.seconds)
        {
            return true;
        }
        else
        {



            return false;

        }
    }
}
class program
{
    static void Main(string[] args)
    {
        // default constructor
        clockType empty_time = new clockType();
        Console.Write("Empty time: ");
        empty_time.printTime();

        // Parameterized constructor (one parameter)
        clockType hour_time = new clockType(8);
        Console.Write("Hour time: ");
        hour_time.printTime();

        // Parameterized constructor (two parameters)
        clockType minute_time = new clockType(8, 10);
        Console.Write("Minute time: ");
        minute_time.printTime();

        // Parameterized constructor (three parameters)
        clockType full_time = new clockType(8, 10, 10);
        Console.Write("Full time: ");
        full_time.printTime();






        // increment second
        full_time.incrementSecond();
        Console.Write("Full time (Increment Second): ");
        full_time.printTime();

        // increment hours
        full_time.incrementhours();
        Console.Write("Full time (Increment hours): ");
        full_time.printTime();

        // increment mintues
        full_time.incrementminutes();
        Console.Write("Full time (Increment Mintues): ");
        full_time.printTime();





        // chcek if equal
        bool flag = full_time.isEqual(9, 11, 11);
        Console.WriteLine("Flag: " + flag);

        // chcek if equal with object
        clockType cmp = new clockType(10, 12, 1);
        flag = full_time.isEqual(cmp);
        Console.WriteLine("Object Flag: " + flag);


    }
}*/



/*class clockType
{
    public int hr;
    public int min;
    public int sec;

    public clockType(int h = 0, int m = 0, int s = 0)
    {
        hr = h;
        min = m;
        sec = s;
    }

    public int ElapsedTime()
    {
        return (hr * 3600) + (min * 60) + sec;
    }

    public int RemainingTime()
    {
        return (24 * 3600) - ElapsedTime();
    }

    public int Difference(clockType other)
    {
        int time1 = ElapsedTime();
        int time2 = other.ElapsedTime();

        if (time1 > time2)
            return time1 - time2;
        else
            return time2 - time1;
    }

    public void PrintTime()
    {
        Console.WriteLine(hr + ":" + min + ":" + sec);
    }
}

class Program
{
    static void Main()
    {
        // Create two clock objects
        clockType clock1 = new clockType(10, 30, 45);
        clockType clock2 = new clockType(8, 20, 30);

        // Display times
        Console.Write("Clock 1: ");
        clock1.PrintTime();

        Console.Write("Clock 2: ");
        clock2.PrintTime();

        // a. Elapsed time
        Console.WriteLine("Elapsed time of Clock 1: "
                          + clock1.ElapsedTime() + " seconds");

        // b. Remaining time
        Console.WriteLine("Remaining time of Clock 1: "
                          + clock1.RemainingTime() + " seconds");

        // c. Difference between clocks
        Console.WriteLine("Difference between clocks: "
                          + clock1.Difference(clock2) + " seconds");
    }
}*/




/*using System;
using System.Collections.Generic;

class Product
{
    public string Name;
    public string Category;
    public double Price;
    public int StockQuantity;
    public int MinimumStockQuantity;

    static List<Product> products = new List<Product>();

    
    public Product(string name, string category, double price,
                   int stock, int minimum)
    {
        this.Name = name;
        this.Category = category;
        this.Price = price;
        this.StockQuantity = stock;
        this.MinimumStockQuantity = minimum;
    }

    
    public void AddProduct()
    {
        Console.Write("Enter product name: ");
        string name = Console.ReadLine();

        Console.WriteLine("1. Groceries");
        Console.WriteLine("2. Fresh Fruit");
        Console.Write("Enter category: ");
        int choice = int.Parse(Console.ReadLine());

        string category;

        if (choice == 1)
            category = "Groceries";
        else if (choice == 2)
            category = "Fresh Fruit";
        else
        {
            Console.WriteLine("Invalid category!");
            return;
        }

        Console.Write("Enter unit price: ");
        double price = double.Parse(Console.ReadLine());

        Console.Write("Enter stock quantity: ");
        int stock = int.Parse(Console.ReadLine());

        Console.Write("Enter minimum stock quantity: ");
        int minimum = int.Parse(Console.ReadLine());

        Product p = new Product(name, category, price, stock, minimum);
        products.Add(p);

        Console.WriteLine("Product added successfully!");
    }

    
    public void ViewAllProducts()
    {
        if (products.Count == 0)
        {
            Console.WriteLine("No products available.");
            return;
        }

        for (int i = 0; i < products.Count; i++)
        {
            Console.WriteLine("\nProduct " + (i + 1));
            Console.WriteLine("Name: " + products[i].Name);
            Console.WriteLine("Category: " + products[i].Category);
            Console.WriteLine("Price: " + products[i].Price);
            Console.WriteLine("Stock: " + products[i].StockQuantity);
            Console.WriteLine("Minimum Stock: " +
                              products[i].MinimumStockQuantity);
        }
    }

    
    public void HighestPrice()
    {
        if (products.Count == 0)
        {
            Console.WriteLine("No products available.");
            return;
        }

        int highest = 0;

        for (int i = 1; i < products.Count; i++)
        {
            if (products[i].Price > products[highest].Price)
            {
                highest = i;
            }
        }

        Console.WriteLine("Highest Price Product: " +
                          products[highest].Name);
        Console.WriteLine("Unit Price: " + products[highest].Price);
    }

    
    public void ViewSalesTax()
    {
        double taxRate = 0.05;

        for (int i = 0; i < products.Count; i++)
        {
            double tax = products[i].Price * taxRate;

            Console.WriteLine(products[i].Name +
                              " - Sales Tax per unit: " + tax);
        }
    }

    
    public void ProductsToOrder()
    {
        bool found = false;

        for (int i = 0; i < products.Count; i++)
        {
            if (products[i].StockQuantity <
                products[i].MinimumStockQuantity)
            {
                Console.WriteLine("Product: " + products[i].Name);
                Console.WriteLine("Current Stock: " +
                                  products[i].StockQuantity);
                Console.WriteLine("Minimum Stock: " +
                                  products[i].MinimumStockQuantity);

                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("No products need to be ordered.");
        }
    }

    
    static void Main()
    {
        Product obj = new Product("", "", 0, 0, 0);
        int choice;

        do
        {
            Console.WriteLine("\n DEPARTMENTAL STORE ");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. View All Products");
            Console.WriteLine("3. Highest Unit Price");
            Console.WriteLine("4. View Sales Tax");
            Console.WriteLine("5. Products to Be Ordered");
            Console.WriteLine("6. Exit");
            Console.Write("Enter choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    obj.AddProduct();
                    break;

                case 2:
                    obj.ViewAllProducts();
                    break;

                case 3:
                    obj.HighestPrice();
                    break;

                case 4:
                    obj.ViewSalesTax();
                    break;

                case 5:
                    obj.ProductsToOrder();
                    break;

                case 6:
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

        } while (choice != 6);
    }
}*/







/*using System;

class Calculator
{
    
    public double number1;
    public double number2;

    // Default constructor
    public Calculator()
    {
        number1 = 10;
        number2 = 10;
    }

    
    public Calculator(double n1, double n2)
    {
        number1 = n1;
        number2 = n2;
    }

    
    public double Add()
    {
        return number1 + number2;
    }

    
    public double Subtract()
    {
        return number1 - number2;
    }

    
    public double Multiply()
    {
        return number1 * number2;
    }

    
    public double Divide()
    {
        if (number2 == 0)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
            return 0;
        }

        return number1 / number2;
    }

    
    public double Modulo()
    {
        if (number2 == 0)
        {
            Console.WriteLine("Error: Cannot perform modulo by zero.");
            return 0;
        }

        return number1 % number2;
    }

   
    static void Main()
    {
        Calculator obj = null;
        int choice;

        do
        {
            Console.WriteLine("\n===== CALCULATOR MENU =====");
            Console.WriteLine("1. Create a Single Object of Calculator");
            Console.WriteLine("2. Change Values of Attributes");
            Console.WriteLine("3. Add");
            Console.WriteLine("4. Subtract");
            Console.WriteLine("5. Multiply");
            Console.WriteLine("6. Divide");
            Console.WriteLine("7. Modulo");
            Console.WriteLine("8. Exit");

            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("1. Default Constructor");
                    Console.WriteLine("2. Parameterized Constructor");
                    Console.Write("Choose constructor: ");
                    int c = int.Parse(Console.ReadLine());

                    if (c == 1)
                    {
                        obj = new Calculator();
                    }
                    else if (c == 2)
                    {
                        Console.Write("Enter number 1: ");
                        double n1 = double.Parse(Console.ReadLine());

                        Console.Write("Enter number 2: ");
                        double n2 = double.Parse(Console.ReadLine());

                        obj = new Calculator(n1, n2);
                    }
                    else
                    {
                        Console.WriteLine("Invalid constructor choice.");
                        break;
                    }

                    Console.WriteLine("Calculator object created!");
                    Console.WriteLine("Number 1: " + obj.number1);
                    Console.WriteLine("Number 2: " + obj.number2);
                    break;

                case 2:
                    if (obj == null)
                    {
                        Console.WriteLine("Create the object first!");
                        break;
                    }

                    Console.Write("Enter new number 1: ");
                    obj.number1 = double.Parse(Console.ReadLine());

                    Console.Write("Enter new number 2: ");
                    obj.number2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Values updated successfully!");
                    break;

                case 3:
                    if (obj == null)
                    {
                        Console.WriteLine("Create the object first!");
                        break;
                    }

                    Console.WriteLine("Addition = " + obj.Add());
                    break;

                case 4:
                    if (obj == null)
                    {
                        Console.WriteLine("Create the object first!");
                        break;
                    }

                    Console.WriteLine("Subtraction = " + obj.Subtract());
                    break;

                case 5:
                    if (obj == null)
                    {
                        Console.WriteLine("Create the object first!");
                        break;
                    }

                    Console.WriteLine("Multiplication = " + obj.Multiply());
                    break;

                case 6:
                    if (obj == null)
                    {
                        Console.WriteLine("Create the object first!");
                        break;
                    }

                    double divisionResult = obj.Divide();

                    if (obj.number2 != 0)
                    {
                        Console.WriteLine("Division = " + divisionResult);
                    }
                    break;

                case 7:
                    if (obj == null)
                    {
                        Console.WriteLine("Create the object first!");
                        break;
                    }

                    double moduloResult = obj.Modulo();

                    if (obj.number2 != 0)
                    {
                        Console.WriteLine("Modulo = " + moduloResult);
                    }
                    break;

                case 8:
                    Console.WriteLine("Calculator closed.");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

        } while (choice != 8);
    }
}*/




/*using System;

class Calculator
{
    
    public double number1;
    public double number2;

    
    public Calculator()
    {
        number1 = 10;
        number2 = 10;
    }

    
    public Calculator(double n1, double n2)
    {
        number1 = n1;
        number2 = n2;
    }

    
    public double Add()
    {
        return number1 + number2;
    }

    public double Subtract()
    {
        return number1 - number2;
    }

    public double Multiply()
    {
        return number1 * number2;
    }

    public double Divide()
    {
        if (number2 == 0)
        {
            Console.WriteLine("Cannot divide by zero!");
            return 0;
        }

        return number1 / number2;
    }

    public double Modulo()
    {
        if (number2 == 0)
        {
            Console.WriteLine("Cannot perform modulo by zero!");
            return 0;
        }

        return number1 % number2;
    }

    

    
    public double Sqrt(int number)
    {
        if (number < 0)
        {
            Console.WriteLine("Square root of a negative number is not supported.");
            return 0;
        }

        return Math.Sqrt(number);
    }

    
    public double Exp(int number)
    {
        return Math.Exp(number);
    }

    
    public double Log(int number)
    {
        if (number <= 0)
        {
            Console.WriteLine("Logarithm requires a positive number.");
            return 0;
        }

        return Math.Log(number);
    }

    
    public double Sin(int angle)
    {
        double radians = angle * Math.PI / 180;
        return Math.Sin(radians);
    }

    
    public double Cos(int angle)
    {
        double radians = angle * Math.PI / 180;
        return Math.Cos(radians);
    }

    
    public double Tan(int angle)
    {
        double radians = angle * Math.PI / 180;
        return Math.Tan(radians);
    }

    
    static void Main()
    {
        Calculator obj = null;
        int choice;

        do
        {
            Console.WriteLine("\n===== CALCULATOR MENU =====");
            Console.WriteLine("1. Create Calculator Object");
            Console.WriteLine("2. Change Values of Attributes");
            Console.WriteLine("3. Add");
            Console.WriteLine("4. Subtract");
            Console.WriteLine("5. Multiply");
            Console.WriteLine("6. Divide");
            Console.WriteLine("7. Modulo");
            Console.WriteLine("8. Square Root");
            Console.WriteLine("9. Exponential");
            Console.WriteLine("10. Natural Logarithm");
            Console.WriteLine("11. Sin");
            Console.WriteLine("12. Cos");
            Console.WriteLine("13. Tan");
            Console.WriteLine("14. Exit");

            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("1. Default Constructor");
                    Console.WriteLine("2. Parameterized Constructor");
                    Console.Write("Choose: ");
                    int c = int.Parse(Console.ReadLine());

                    if (c == 1)
                    {
                        obj = new Calculator();
                    }
                    else if (c == 2)
                    {
                        Console.Write("Enter number 1: ");
                        double n1 = double.Parse(Console.ReadLine());

                        Console.Write("Enter number 2: ");
                        double n2 = double.Parse(Console.ReadLine());

                        obj = new Calculator(n1, n2);
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice!");
                        break;
                    }

                    Console.WriteLine("Object created successfully!");
                    Console.WriteLine("Number 1: " + obj.number1);
                    Console.WriteLine("Number 2: " + obj.number2);
                    break;

                case 2:
                    if (obj == null)
                    {
                        Console.WriteLine("Create the object first!");
                        break;
                    }

                    Console.Write("Enter number 1: ");
                    obj.number1 = double.Parse(Console.ReadLine());

                    Console.Write("Enter number 2: ");
                    obj.number2 = double.Parse(Console.ReadLine());
                    break;

                case 3:
                    if (obj == null) { Console.WriteLine("Create object first!"); break; }
                    Console.WriteLine("Addition = " + obj.Add());
                    break;

                case 4:
                    if (obj == null) { Console.WriteLine("Create object first!"); break; }
                    Console.WriteLine("Subtraction = " + obj.Subtract());
                    break;

                case 5:
                    if (obj == null) { Console.WriteLine("Create object first!"); break; }
                    Console.WriteLine("Multiplication = " + obj.Multiply());
                    break;

                case 6:
                    if (obj == null) { Console.WriteLine("Create object first!"); break; }
                    if (obj.number2 != 0)
                        Console.WriteLine("Division = " + obj.Divide());
                    else
                        obj.Divide();
                    break;

                case 7:
                    if (obj == null) { Console.WriteLine("Create object first!"); break; }
                    if (obj.number2 != 0)
                        Console.WriteLine("Modulo = " + obj.Modulo());
                    else
                        obj.Modulo();
                    break;

                case 8:
                    Console.Write("Enter an integer: ");
                    int sq = int.Parse(Console.ReadLine());
                    Console.WriteLine("Square Root = " + obj.Sqrt(sq));
                    break;

                case 9:
                    Console.Write("Enter exponent: ");
                    int ex = int.Parse(Console.ReadLine());
                    Console.WriteLine("Exponential = " + obj.Exp(ex));
                    break;

                case 10:
                    Console.Write("Enter a positive integer: ");
                    int lg = int.Parse(Console.ReadLine());
                    Console.WriteLine("Natural Log = " + obj.Log(lg));
                    break;

                case 11:
                    Console.Write("Enter angle in degrees: ");
                    int a1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Sin = " + obj.Sin(a1));
                    break;

                case 12:
                    Console.Write("Enter angle in degrees: ");
                    int a2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Cos = " + obj.Cos(a2));
                    break;

                case 13:
                    Console.Write("Enter angle in degrees: ");
                    int a3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Tan = " + obj.Tan(a3));
                    break;

                case 14:
                    Console.WriteLine("Calculator closed.");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

        } while (choice != 14);
    }
}*/

/*using System.Collections.Generic;

class Book
{
    
    public string title;
    public string author;
    public int publicationYear;
    public double price;
    public int quantityInStock;

    
    public Book(string t, string a, int year, double p, int quantity)
    {
        title = t;
        author = a;
        publicationYear = year;
        price = p;
        quantityInStock = quantity;
    }

    
    public string getTitle()
    {
        return "Title: " + title;
    }

    
    public string getAuthor()
    {
        return "Author: " + author;
    }

    
    public string getPublicationYear()
    {
        return "Publication Year: " + publicationYear;
    }

    
    public string getPrice()
    {
        return "Price: $" + price;
    }

    
    public void sellCopies(int numberOfCopies)
    {
        if (numberOfCopies <= 0)
        {
            Console.WriteLine("Enter a valid number of copies.");
        }
        else if (numberOfCopies <= quantityInStock)
        {
            quantityInStock = quantityInStock - numberOfCopies;
            Console.WriteLine("Copies sold successfully!");
        }
        else
        {
            Console.WriteLine("Not enough copies available in stock.");
        }
    }

    
    public void restock(int additionalCopies)
    {
        if (additionalCopies <= 0)
        {
            Console.WriteLine("Enter a valid quantity.");
        }
        else
        {
            quantityInStock = quantityInStock + additionalCopies;
            Console.WriteLine("Book restocked successfully!");
        }
    }

    
    public string bookDetails()
    {
        return getTitle() + "\n" +
               getAuthor() + "\n" +
               getPublicationYear() + "\n" +
               getPrice() + "\n" +
               "Quantity in Stock: " + quantityInStock;
    }

    
    static void Main()
    {
        List<Book> bookList = new List<Book>();

        
        Book b1 = new Book("Pride and Prejudice",
                           "Jane Austen", 1813, 19.99, 10);

        Book b2 = new Book("Hamlet",
                           "William Shakespeare", 1603, 15.50, 8);

        Book b3 = new Book("War and Peace",
                           "Leo Tolstoy", 1869, 25.99, 5);

        bookList.Add(b1);
        bookList.Add(b2);
        bookList.Add(b3);

        int choice;

        do
        {
            Console.WriteLine("\n===== BOOK MANAGEMENT SYSTEM =====");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. View All Books");
            Console.WriteLine("3. Get Author Details");
            Console.WriteLine("4. Sell Copies");
            Console.WriteLine("5. Restock Book");
            Console.WriteLine("6. Count Books");
            Console.WriteLine("7. Exit");

            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter book title: ");
                    string title = Console.ReadLine();

                    Console.Write("Enter author: ");
                    string author = Console.ReadLine();

                    Console.Write("Enter publication year: ");
                    int year = int.Parse(Console.ReadLine());

                    Console.Write("Enter price: ");
                    double price = double.Parse(Console.ReadLine());

                    Console.Write("Enter quantity in stock: ");
                    int quantity = int.Parse(Console.ReadLine());

                    Book newBook = new Book(title, author, year,
                                            price, quantity);

                    bookList.Add(newBook);

                    Console.WriteLine("Book added successfully!");
                    break;

                case 2:
                    if (bookList.Count == 0)
                    {
                        Console.WriteLine("No books available.");
                        break;
                    }

                    for (int i = 0; i < bookList.Count; i++)
                    {
                        Console.WriteLine("\nBook " + (i + 1));
                        Console.WriteLine(bookList[i].bookDetails());
                    }
                    break;

                case 3:
                    Console.Write("Enter book title: ");
                    string searchTitle = Console.ReadLine();

                    bool authorFound = false;

                    for (int i = 0; i < bookList.Count; i++)
                    {
                        if (bookList[i].title.Equals(
                            searchTitle,
                            StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine(bookList[i].getAuthor());
                            authorFound = true;
                            break;
                        }
                    }

                    if (!authorFound)
                    {
                        Console.WriteLine("Book not found.");
                    }
                    break;

                case 4:
                    Console.Write("Enter book title: ");
                    string sellTitle = Console.ReadLine();

                    bool sellFound = false;

                    for (int i = 0; i < bookList.Count; i++)
                    {
                        if (bookList[i].title.Equals(
                            sellTitle,
                            StringComparison.OrdinalIgnoreCase))
                        {
                            Console.Write("Enter copies to sell: ");
                            int copies = int.Parse(Console.ReadLine());

                            bookList[i].sellCopies(copies);
                            sellFound = true;
                            break;
                        }
                    }

                    if (!sellFound)
                    {
                        Console.WriteLine("Book not found.");
                    }
                    break;

                case 5:
                    Console.Write("Enter book title: ");
                    string restockTitle = Console.ReadLine();

                    bool restockFound = false;

                    for (int i = 0; i < bookList.Count; i++)
                    {
                        if (bookList[i].title.Equals(
                            restockTitle,
                            StringComparison.OrdinalIgnoreCase))
                        {
                            Console.Write("Enter additional copies: ");
                            int copies = int.Parse(Console.ReadLine());

                            bookList[i].restock(copies);
                            restockFound = true;
                            break;
                        }
                    }

                    if (!restockFound)
                    {
                        Console.WriteLine("Book not found.");
                    }
                    break;

                case 6:
                    Console.WriteLine("Total books: " + bookList.Count);
                    break;

                case 7:
                    Console.WriteLine("Program ended.");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

        } while (choice != 7);
    }
}*/



/*using System;
using System.Collections.Generic;

class Enemy
{
    public char displayCharacter;
    public int x;
    public int y;

    
    public Enemy(char symbol, int xPosition, int yPosition)
    {
        displayCharacter = symbol;
        x = xPosition;
        y = yPosition;
    }

    
    public void Move(int dx, int dy)
    {
        x = x + dx;
        y = y + dy;
    }

    
    public void Display()
    {
        Console.WriteLine("Enemy " + displayCharacter +
                          " Position: (" + x + ", " + y + ")");
    }
}

class Player
{
    public char displayCharacter;
    public int x;
    public int y;

    
    public Player(char symbol, int xPosition, int yPosition)
    {
        displayCharacter = symbol;
        x = xPosition;
        y = yPosition;
    }

    
    public void Move(int dx, int dy)
    {
        x = x + dx;
        y = y + dy;
    }

    
    public void Display()
    {
        Console.WriteLine("Player " + displayCharacter +
                          " Position: (" + x + ", " + y + ")");
    }
}

class Program
{
    static void Main()
    {
        
        List<Enemy> enemies = new List<Enemy>();

        Enemy e1 = new Enemy('E', 2, 3);
        Enemy e2 = new Enemy('X', 5, 6);
        Enemy e3 = new Enemy('Z', 7, 1);

        enemies.Add(e1);
        enemies.Add(e2);
        enemies.Add(e3);

        
        Player player = new Player('P', 0, 0);

        int choice;

        do
        {
            Console.WriteLine("\n===== SIMPLE GAME =====");
            Console.WriteLine("1. Display Player");
            Console.WriteLine("2. Move Player");
            Console.WriteLine("3. Display All Enemies");
            Console.WriteLine("4. Move All Enemies");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    player.Display();
                    break;

                case 2:
                    Console.WriteLine("1. Up");
                    Console.WriteLine("2. Down");
                    Console.WriteLine("3. Left");
                    Console.WriteLine("4. Right");
                    Console.Write("Choose direction: ");

                    int direction = int.Parse(Console.ReadLine());

                    if (direction == 1)
                        player.Move(0, 1);
                    else if (direction == 2)
                        player.Move(0, -1);
                    else if (direction == 3)
                        player.Move(-1, 0);
                    else if (direction == 4)
                        player.Move(1, 0);
                    else
                        Console.WriteLine("Invalid direction!");

                    player.Display();
                    break;

                case 3:
                    for (int i = 0; i < enemies.Count; i++)
                    {
                        enemies[i].Display();
                    }
                    break;

                case 4:
                    for (int i = 0; i < enemies.Count; i++)
                    {
                        enemies[i].Move(1, 0);
                    }

                    Console.WriteLine("All enemies moved one step right!");

                    for (int i = 0; i < enemies.Count; i++)
                    {
                        enemies[i].Display();
                    }
                    break;

                case 5:
                    Console.WriteLine("Game ended.");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

        } while (choice != 5);
    }
}*/
