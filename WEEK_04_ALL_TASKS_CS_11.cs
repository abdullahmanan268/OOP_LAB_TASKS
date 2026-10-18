/*using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Numerics;

class Student
{
    public string name;
    public int roll_no;
    public float cgpa;
    public float matric;
    public float FSC_marks;
    public float Ecat;
    public string hometwon;
    public bool hostelite;
    public bool scholarship;



    public Student(string name,int roll_no,float cgpa,float matric,float FSC_marks,float Ecat,string hometwon,bool scholarship,bool hostelite)
    {
        this.name= name;
        this.roll_no= roll_no;
        this.cgpa= cgpa;
        this.matric = matric;
        this.FSC_marks= FSC_marks;
        this.Ecat= Ecat;
        this.hometwon= hometwon;
        this.hostelite = hostelite;
        this.scholarship= scholarship;
    }


    public float merit()
    {
        return (((matric / 1100) * 10) + ((FSC_marks / 1200) * 17) + (Ecat / 400) * 73);
    }


    public  bool avail_scholarship(float merit_percentage)
    {
        if (merit_percentage >= 90)
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
        Student s1 = new Student("abdullah", 11, 3, 1070, 1120, 320, "lahore", true, true);
        float merit_percentage = s1.merit();
        bool is_scholarship = s1.avail_scholarship(merit_percentage);
        if (is_scholarship)
        {
            Console.WriteLine(s1.name + " taking scholarship");
        }
        else
        {
            Console.WriteLine(s1.name + "is not taking scholarship");
        }
        Console.ReadKey();
    }
}*/



/*using System;

class Book
{
    private string title;
    private string[] authors;
    private int numberOfAuthors;
    private string publisher;
    private string ISBN;
    private double price;
    private int stock;

    
    public Book()
    {
        title = "";
        authors = new string[4];
        numberOfAuthors = 0;
        publisher = "";
        ISBN = "";
        price = 0;
        stock = 0;
    }

    
    public Book(string t, string p, string isbn,
                double pr, int s)
    {
        title = t;
        publisher = p;
        ISBN = isbn;
        price = pr;
        stock = s;

        authors = new string[4];
        numberOfAuthors = 0;
    }

    
    public void SetTitle(string t)
    {
        title = t;
    }

    
    public string GetTitle()
    {
        return title;
    }

    
    public bool IsTitle(string t)
    {
        return title.Equals(t,
            StringComparison.OrdinalIgnoreCase);
    }

    
    public void SetPublisher(string p)
    {
        publisher = p;
    }

    public string GetPublisher()
    {
        return publisher;
    }

    
    public void SetISBN(string isbn)
    {
        ISBN = isbn;
    }

    public string GetISBN()
    {
        return ISBN;
    }

    
    public void SetPrice(double pr)
    {
        price = pr;
    }

    public double GetPrice()
    {
        return price;
    }

    
    public void SetStock(int s)
    {
        stock = s;
    }

    public int GetStock()
    {
        return stock;
    }

    
    public void UpdateStock(int amount)
    {
        if (stock + amount >= 0)
        {
            stock = stock + amount;
        }
        else
        {
            Console.WriteLine("Not enough copies in stock!");
        }
    }

    
    public void AddAuthor(string author)
    {
        if (numberOfAuthors < 4)
        {
            authors[numberOfAuthors] = author;
            numberOfAuthors++;
        }
        else
        {
            Console.WriteLine("Maximum 4 authors allowed!");
        }
    }

    
    public void ShowAuthors()
    {
        for (int i = 0; i < numberOfAuthors; i++)
        {
            Console.WriteLine(authors[i]);
        }
    }

    
    public void DisplayBook()
    {
        Console.WriteLine("\nTitle: " + title);
        Console.WriteLine("Publisher: " + publisher);
        Console.WriteLine("ISBN: " + ISBN);
        Console.WriteLine("Price: " + price);
        Console.WriteLine("Stock: " + stock);

        Console.WriteLine("Authors:");
        ShowAuthors();
    }
}

class Program
{
    static void Main()
    {
        Book[] books = new Book[100];
        int count = 0;
        int choice;

        do
        {
            Console.WriteLine(" BOOK MENU ");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Search Book by Title");
            Console.WriteLine("3. Search Book by ISBN");
            Console.WriteLine("4. Update Book Stock");
            Console.WriteLine("5. Display All Books");
            Console.WriteLine("6. Exit");
            Console.Write("Enter choice: ");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                if (count < 100)
                {
                    Console.Write("Enter title: ");
                    string title = Console.ReadLine();

                    Console.Write("Enter publisher: ");
                    string publisher = Console.ReadLine();

                    Console.Write("Enter ISBN: ");
                    string isbn = Console.ReadLine();

                    Console.Write("Enter price: ");
                    double price = double.Parse(Console.ReadLine());

                    Console.Write("Enter stock: ");
                    int stock = int.Parse(Console.ReadLine());

                    Book b = new Book(title, publisher,
                                      isbn, price, stock);

                    Console.Write("How many authors (0-4)? ");
                    int n = int.Parse(Console.ReadLine());

                    if (n < 0 || n > 4)
                    {
                        Console.WriteLine("Invalid number of authors.");
                    }
                    else
                    {
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write("Enter author " + (i + 1) + ": ");
                            string author = Console.ReadLine();

                            b.AddAuthor(author);
                        }

                        books[count] = b;
                        count++;

                        Console.WriteLine("Book added successfully!");
                    }
                }
                else
                {
                    Console.WriteLine("Book array is full!");
                }
            }
            else if (choice == 2)
            {
                Console.Write("Enter title to search: ");
                string title = Console.ReadLine();

                bool found = false;

                for (int i = 0; i < count; i++)
                {
                    if (books[i].IsTitle(title))
                    {
                        books[i].DisplayBook();
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("Book not found!");
                }
            }
            else if (choice == 3)
            {
                Console.Write("Enter ISBN to search: ");
                string isbn = Console.ReadLine();

                bool found = false;

                for (int i = 0; i < count; i++)
                {
                    if (books[i].GetISBN() == isbn)
                    {
                        books[i].DisplayBook();
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("Book not found!");
                }
            }
            else if (choice == 4)
            {
                Console.Write("Enter ISBN of book: ");
                string isbn = Console.ReadLine();

                bool found = false;

                for (int i = 0; i < count; i++)
                {
                    if (books[i].GetISBN() == isbn)
                    {
                        Console.Write("Enter stock change (+ to add, - to remove): ");
                        int amount = int.Parse(Console.ReadLine());

                        books[i].UpdateStock(amount);

                        Console.WriteLine("Current stock: " +
                                           books[i].GetStock());

                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("Book not found!");
                }
            }
            else if (choice == 5)
            {
                if (count == 0)
                {
                    Console.WriteLine("No books available.");
                }

                for (int i = 0; i < count; i++)
                {
                    books[i].DisplayBook();
                }
            }
            else if (choice == 6)
            {
                Console.WriteLine("Program closed.");
            }
            else
            {
                Console.WriteLine("Invalid choice!");
            }

        } while (choice != 6);
    }
}*/





/*using System;
using System.Collections.Generic;

class Member
{
    private string name;
    private int memberID;
    private List<string> booksBought;
    private int numberOfBooksBought;
    private double moneyInBank;
    private double amountSpent;

    
    public Member()
    {
        name = "";
        memberID = 0;
        booksBought = new List<string>();
        numberOfBooksBought = 0;
        moneyInBank = 0;
        amountSpent = 0;
    }

    
    public Member(string n, int id, double money)
    {
        name = n;
        memberID = id;
        booksBought = new List<string>();
        numberOfBooksBought = 0;
        moneyInBank = money;
        amountSpent = 0;
    }

   
    public void SetName(string n)
    {
        name = n;
    }

    public string GetName()
    {
        return name;
    }

    
    public void SetMemberID(int id)
    {
        memberID = id;
    }

    public int GetMemberID()
    {
        return memberID;
    }

    
    public void AddBook(string book)
    {
        booksBought.Add(book);
        numberOfBooksBought++;
    }

    
    public void ShowBooks()
    {
        if (numberOfBooksBought == 0)
        {
            Console.WriteLine("No books bought yet.");
        }

        for (int i = 0; i < numberOfBooksBought; i++)
        {
            Console.WriteLine(booksBought[i]);
        }
    }

    
    public int GetNumberOfBooksBought()
    {
        return numberOfBooksBought;
    }

    
    public void SetNumberOfBooksBought(int number)
    {
        if (number < 0)
        {
            Console.WriteLine("Number cannot be negative.");
        }
        else if (number < numberOfBooksBought)
        {
            booksBought.RemoveRange(
                number, numberOfBooksBought - number);

            numberOfBooksBought = number;
        }
        else
        {
            while (numberOfBooksBought < number)
            {
                Console.Write("Enter book title: ");
                string book = Console.ReadLine();

                booksBought.Add(book);
                numberOfBooksBought++;
            }
        }
    }

    
    public void SetMoneyInBank(double money)
    {
        if (money >= 0)
            moneyInBank = money;
        else
            Console.WriteLine("Money cannot be negative.");
    }

    public double GetMoneyInBank()
    {
        return moneyInBank;
    }

    
    public void UpdateAmountSpent(double amount)
    {
        if (amount >= 0 && amount <= moneyInBank)
        {
            amountSpent += amount;
            moneyInBank -= amount;
        }
        else
        {
            Console.WriteLine("Invalid amount or insufficient money.");
        }
    }

    public void SetAmountSpent(double amount)
    {
        if (amount >= 0)
            amountSpent = amount;
        else
            Console.WriteLine("Amount cannot be negative.");
    }

    public double GetAmountSpent()
    {
        return amountSpent;
    }

    
    public void DisplayMember()
    {
        Console.WriteLine("\nMember Name: " + name);
        Console.WriteLine("Member ID: " + memberID);
        Console.WriteLine("Books Bought: " + numberOfBooksBought);
        Console.WriteLine("Money in Bank: " + moneyInBank);
        Console.WriteLine("Amount Spent: " + amountSpent);

        Console.WriteLine("Book List:");
        ShowBooks();
    }
}

class Program
{
    static void Main()
    {
        Member[] members = new Member[100];
        int count = 0;
        int choice;

        do
        {
            Console.WriteLine("MEMBER MENU ");
            Console.WriteLine("1. Add Member");
            Console.WriteLine("2. Display All Members");
            Console.WriteLine("3. Search Member by ID");
            Console.WriteLine("4. Modify Member Name");
            Console.WriteLine("5. Add Book to Member");
            Console.WriteLine("6. Update Money Spent");
            Console.WriteLine("7. Update Bank Balance");
            Console.WriteLine("8. Modify Number of Books");
            Console.WriteLine("9. Exit");

            Console.Write("Enter choice: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                if (count < 100)
                {
                    Console.Write("Enter name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter member ID: ");
                    int id = int.Parse(Console.ReadLine());

                    Console.Write("Enter money in bank: ");
                    double money = double.Parse(Console.ReadLine());

                    members[count] = new Member(name, id, money);
                    count++;

                    Console.WriteLine("Member added successfully!");
                }
                else
                {
                    Console.WriteLine("Member list is full!");
                }
            }
            else if (choice == 2)
            {
                for (int i = 0; i < count; i++)
                {
                    members[i].DisplayMember();
                }

                if (count == 0)
                    Console.WriteLine("No members available.");
            }
            else if (choice == 3)
            {
                Console.Write("Enter member ID: ");
                int id = int.Parse(Console.ReadLine());

                bool found = false;

                for (int i = 0; i < count; i++)
                {
                    if (members[i].GetMemberID() == id)
                    {
                        members[i].DisplayMember();
                        found = true;
                        break;
                    }
                }

                if (!found)
                    Console.WriteLine("Member not found.");
            }
            else if (choice == 4)
            {
                Console.Write("Enter member ID: ");
                int id = int.Parse(Console.ReadLine());

                bool found = false;

                for (int i = 0; i < count; i++)
                {
                    if (members[i].GetMemberID() == id)
                    {
                        Console.Write("Enter new name: ");
                        string name = Console.ReadLine();

                        members[i].SetName(name);

                        Console.WriteLine("Name updated!");
                        found = true;
                        break;
                    }
                }

                if (!found)
                    Console.WriteLine("Member not found.");
            }
            else if (choice == 5)
            {
                Console.Write("Enter member ID: ");
                int id = int.Parse(Console.ReadLine());

                bool found = false;

                for (int i = 0; i < count; i++)
                {
                    if (members[i].GetMemberID() == id)
                    {
                        Console.Write("Enter book title: ");
                        string book = Console.ReadLine();

                        members[i].AddBook(book);

                        Console.WriteLine("Book added!");
                        found = true;
                        break;
                    }
                }

                if (!found)
                    Console.WriteLine("Member not found.");
            }
            else if (choice == 6)
            {
                Console.Write("Enter member ID: ");
                int id = int.Parse(Console.ReadLine());

                bool found = false;

                for (int i = 0; i < count; i++)
                {
                    if (members[i].GetMemberID() == id)
                    {
                        Console.Write("Enter amount spent: ");
                        double amount = double.Parse(Console.ReadLine());

                        members[i].UpdateAmountSpent(amount);

                        Console.WriteLine("Amount spent: " +
                            members[i].GetAmountSpent());

                        found = true;
                        break;
                    }
                }

                if (!found)
                    Console.WriteLine("Member not found.");
            }
            else if (choice == 7)
            {
                Console.Write("Enter member ID: ");
                int id = int.Parse(Console.ReadLine());

                bool found = false;

                for (int i = 0; i < count; i++)
                {
                    if (members[i].GetMemberID() == id)
                    {
                        Console.Write("Enter new bank balance: ");
                        double money = double.Parse(Console.ReadLine());

                        members[i].SetMoneyInBank(money);

                        Console.WriteLine("Bank balance updated!");
                        found = true;
                        break;
                    }
                }

                if (!found)
                    Console.WriteLine("Member not found.");
            }
            else if (choice == 8)
            {
                Console.Write("Enter member ID: ");
                int id = int.Parse(Console.ReadLine());

                bool found = false;

                for (int i = 0; i < count; i++)
                {
                    if (members[i].GetMemberID() == id)
                    {
                        Console.Write("Enter new number of books: ");
                        int number = int.Parse(Console.ReadLine());

                        members[i].SetNumberOfBooksBought(number);

                        Console.WriteLine("Number of books: " +
                            members[i].GetNumberOfBooksBought());

                        found = true;
                        break;
                    }
                }

                if (!found)
                    Console.WriteLine("Member not found.");
            }
            else if (choice == 9)
            {
                Console.WriteLine("Program closed.");
            }
            else
            {
                Console.WriteLine("Invalid choice!");
            }

        } while (choice != 9);
    }
}*/
