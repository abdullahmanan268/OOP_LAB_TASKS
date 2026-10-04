/* Abdullah Manan 
  2026SCS_11
 
 
  
  task_01
  public class Student
{
   public string name;
   public float EcatMarks;
   public float FscMaks;
   public float MatricMarks;
   public float aggregate;
}








class Program
{
    static void Main(string[] args)
   {
       Student  student=new Student();
        student.name="Ali";
   student.EcatMarks=300;
   student.FscMaks=800;
    student.MatricMarks=1000;
   Student student2= student;
       student2.name = "sarmad";
       Console.WriteLine(student2.name);
       Console.WriteLine(student.name);
       Console.ReadKey();

   }
}*/

/*task_02
  public class transaction
{
    public string ID;
    public string name;
    public float amount;
    public string date;
    public string  time;
    
    
}

class Program
{
    static void Main(string[] args)
    {
        transaction trans1 = new transaction();
        trans1.ID = "101";
        trans1.name = "Ali";
        trans1.amount = 300;
        trans1.date = "12/10/26";
        trans1.time = "10:00";

        transaction trans2= new transaction();
        trans2.ID = trans1.ID;
        
        trans2.name = trans1.name;
        trans2.amount = trans1.amount;
        trans2.date = trans1.date;
        trans2.time = trans1.time;
        trans1.name="abdullah";
        trans1.amount = 600;

        Console.WriteLine(trans1.ID);
        Console.WriteLine(trans1.name);
        Console.WriteLine(trans1.amount);
        Console.WriteLine(trans1.date);
        Console.WriteLine(trans1.time);
        Console.WriteLine(trans2.ID);
        Console.WriteLine(trans2.name);
        Console.WriteLine(trans2.amount);
        Console.WriteLine(trans2.date);
            Console.WriteLine(trans2.time);




        Console.ReadKey();

    }
}*/


/*task_03


public class calculator
{
    public float num1;
    
    public float num2;
    public void add() 
    {
        Console.WriteLine(num1 + num2);
    }

    public void subs()
    {
        Console.WriteLine(num1 - num2);
    }

    public void multi()
    {
        Console.WriteLine(num1 * num2);
    }
    public void div()
    {
        Console.WriteLine(num1 / num2);
    }
}


class Program
{
    static void Main(string[] args)
    {
        string oper;
        calculator cal = new calculator();
        Console.WriteLine("enter 1st number");
        cal.num1 =int.Parse( Console.ReadLine());
        Console.WriteLine("enter  opertor ");
        oper = Console.ReadLine();
        Console.WriteLine("enter 2nd number");
        cal.num2 =int.Parse(Console.ReadLine());
        if(oper == "+") {
            cal.add();
        }
        if (oper == "-")
        {
            cal.subs();
        }
        if (oper == "*")
        {
            cal.multi();
        }
        if (oper == "/")
        {
            cal.div();
        }





        Console.ReadKey();

    }
}*/

/*task_04
 * class ATM
{
    double balance;
    List<string> history = new List<string>();
    public ATM(double balance)
    {
        this.balance = balance;
    }
    public void deposit(double amount)
    {
        balance = balance + amount;
        history.Add("Deposit: " + amount);
        Console.WriteLine("Deposit: " + amount);
    }
    public void withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance = balance - amount;
            history.Add("withdraw: "+ amount);
            Console.WriteLine("withdrawal: " + amount);

        }
        else
        {
            Console.WriteLine("insufficient balance");
        }
    }
    public double checkbalance()
    {
        return balance;
    }
    public void trans_history()
    {
        Console.WriteLine("transaction history");
        for(int i=0;i<history.Count; i++)
        {
            Console.WriteLine(history[i]);
        }
    }

}

class program
{
    static void Main(string[] args)
    {
        ATM a = new ATM(5000);
        a.deposit (1000);
        a.withdraw(2000);
        a.withdraw(7000);
        Console.WriteLine("Current Balance: " + a.checkbalance());
        a.trans_history();
        Console.ReadKey();
    }
}*/






/*task_05
  
  class Student
{
    public string Name;
    public double MatricMarks;
    public double FscMarks;
    public double EcatMarks;

  
    public List<Student> Students = new List<Student>();

    
    public Student(string name, double matric, double fsc, double ecat)
    {
        Name = name;
        MatricMarks = matric;
        FscMarks = fsc;
        EcatMarks = ecat;
    }

    
    public void AddStudent()
    {
        Console.Write("Enter Student Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Matric Marks: ");
        double matric = double.Parse(Console.ReadLine());

        Console.Write("Enter FSc Marks: ");
        double fsc = double.Parse(Console.ReadLine());

        Console.Write("Enter ECAT Marks: ");
        double ecat = double.Parse(Console.ReadLine());

        Student student = new Student(name, matric, fsc, ecat);

        Students.Add(student);

        Console.WriteLine("Student Added Successfully!");
    }

    
    public double CalculateAggregate()
    {
        double aggregate;

        aggregate = (MatricMarks * 0.10) +
                    (FscMarks * 0.40) +
                    (EcatMarks * 0.50);

        return aggregate;
    }

    
    public void ShowStudents()
    {
        if (Students.Count == 0)
        {
            Console.WriteLine("No students available.");
            return;
        }

        for (int i = 0; i < Students.Count; i++)
        {
            Console.WriteLine("\nStudent " + (i + 1));

            Console.WriteLine("Name: " + Students[i].Name);
            Console.WriteLine("Matric Marks: " + Students[i].MatricMarks);
            Console.WriteLine("FSc Marks: " + Students[i].FscMarks);
            Console.WriteLine("ECAT Marks: " + Students[i].EcatMarks);

            Console.WriteLine(
                "Aggregate: " +
                Students[i].CalculateAggregate()
            );
        }
    }

    
    public void CalculateAllAggregates()
    {
        if (Students.Count == 0)
        {
            Console.WriteLine("No students available.");
            return;
        }

        for (int i = 0; i < Students.Count; i++)
        {
            Console.WriteLine(
                Students[i].Name +
                " = " +
                Students[i].CalculateAggregate()
            );
        }
    }

    
    public void TopStudents()
    {
        if (Students.Count == 0)
        {
            Console.WriteLine("No students available.");
            return;
        }

        List<Student> temp = new List<Student>(Students);

        
        for (int i = 0; i < temp.Count - 1; i++)
        {
            for (int j = i + 1; j < temp.Count; j++)
            {
                if (temp[j].CalculateAggregate() >
                    temp[i].CalculateAggregate())
                {
                    Student temporary = temp[i];
                    temp[i] = temp[j];
                    temp[j] = temporary;
                }
            }
        }

        int limit = temp.Count;

        if (limit > 3)
        {
            limit = 3;
        }

        Console.WriteLine(" TOP STUDENTS");

        for (int i = 0; i < limit; i++)
        {
            Console.WriteLine("\nRank " + (i + 1));
            Console.WriteLine("Name: " + temp[i].Name);
            Console.WriteLine("Matric: " + temp[i].MatricMarks);
            Console.WriteLine("FSc: " + temp[i].FscMarks);
            Console.WriteLine("ECAT: " + temp[i].EcatMarks);
            Console.WriteLine("Aggregate: " +
                              temp[i].CalculateAggregate());
        }
    }
}

class Program
{
    public static void Main()
    {
        
        Student student = new Student("", 0, 0, 0);

        int choice;

        do
        {
            Console.WriteLine(" STUDENT MANAGEMENT SYSTEM ");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Show Students");
            Console.WriteLine("3. Calculate Aggregate");
            Console.WriteLine("4. Top Students");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                student.AddStudent();
            }
            else if (choice == 2)
            {
                student.ShowStudents();
            }
            else if (choice == 3)
            {
                student.CalculateAllAggregates();
            }
            else if (choice == 4)
            {
                student.TopStudents();
            }
            else if (choice == 5)
            {
                Console.WriteLine("Program Ended.");
            }
            else
            {
                Console.WriteLine("Invalid Choice!");
            }

        } while (choice != 5);
    }
}*/





//task_06
class Product
{
    
    public int ID;
    public string Name;
    public double Price;
    public string Category;
    public string BrandName;
    public string Country;

    
    public List<Product> Products = new List<Product>();

    
    public Product(int id, string name, double price,
                   string category, string brandName, string country)
    {
        this.ID = id;
        this.Name = name;
        this.Price = price;
       this.Category = category;
       this. BrandName = brandName;
        this.Country = country;
    }

    
    public void AddProduct()
    {
        Console.Write("Enter Product ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter Product Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Price: ");
        double price = double.Parse(Console.ReadLine());

        Console.Write("Enter Category: ");
        string category = Console.ReadLine();

        Console.Write("Enter Brand Name: ");
        string brandName = Console.ReadLine();

        Console.Write("Enter Country: ");
        string country = Console.ReadLine();

        
        Product product = new Product(
            id, name, price, category, brandName, country
        );

        
        Products.Add(product);

        Console.WriteLine("Product Added Successfully!");
    }

    
    public void ShowProducts()
    {
        if (Products.Count == 0)
        {
            Console.WriteLine("No products available.");
            return;
        }

        for (int i = 0; i < Products.Count; i++)
        {
            Console.WriteLine("\nProduct " + (i + 1));

            Console.WriteLine("ID: " + Products[i].ID);
            Console.WriteLine("Name: " + Products[i].Name);
            Console.WriteLine("Price: " + Products[i].Price);
            Console.WriteLine("Category: " + Products[i].Category);
            Console.WriteLine("Brand Name: " + Products[i].BrandName);
            Console.WriteLine("Country: " + Products[i].Country);

            
        }
    }

    
    public void TotalStoreWorth()
    {
        if (Products.Count == 0)
        {
            Console.WriteLine("No products available.");
            return;
        }

        double total = 0;

        for (int i = 0; i < Products.Count; i++)
        {
            total = total + Products[i].Price;
        }

        Console.WriteLine("Total Store Worth = " + total);
    }
}

class Program
{
    public static void Main()
    {
        
        Product product = new Product(0, "", 0, "", "", "");

        int choice;

        do
        {
            Console.WriteLine("PRODUCTS MANAGEMENT SYSTEM ");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Show Products");
            Console.WriteLine("3. Total Store Worth");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                product.AddProduct();
            }
            else if (choice == 2)
            {
                product.ShowProducts();
            }
            else if (choice == 3)
            {
                product.TotalStoreWorth();
            }
            else if (choice == 4)
            {
                Console.WriteLine("Program Ended.");
            }
            else
            {
                Console.WriteLine("Invalid Choice!");
            }

        } while (choice != 4);
    }
}



