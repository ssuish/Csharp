class Person
{
    // Object Attributes
    private string _name = "";
    private int _age;

    // Constructor
    public Person(string name)
    {
        _name = name;
    }

    // Object Methods
    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public int Age
    {
        get => _age;
        set => _age = value;
    }

    // Access Modifiers
    /*
        - public: accessible from anywhere
        - private: accessible only from within the class
        - protected: accessible from within the class and from derived classes
        - internal: accessible from within the assembly
        - protected internal: accessible from within the assembly and derived classes
        - private protected: accessible from within the class and derived classes
    */

    // Constructor Chaining
    public Person(string name, int age) : this(name)
    {
        this.Name = name;
        this.Age = age;
    }

    // Overriding toString()
    public override string ToString()
    {
        return $"{Name} is {Age} years old.";
    }

    // Object initializer
    public Person()
    {
        // Empty constructor
    }
}

class Job
{
    // Object Attributes
    private string _name;
    private int _salary;

    // Expression-bodied constructor
    public Job(string name, int salary) =>
        (this._name, this._salary) = (name, salary);

    public override string ToString() =>
        $"{this._name} earns {this._salary} dollars per month.";
}

// Target Typed new expression
class User
{
    public string FirstName
    {
        get;
        set;
    }

    public string LastName // fields
    {
        get;
        set;
    }

    public string Occupation // fields
    {
        get;
        set;
    }

    // Target Typed constructor
    public User(string firstName, string lastName, string occupation) =>
        (this.FirstName, this.LastName, this.Occupation) = (firstName, lastName, occupation);

    public override string ToString() =>
        $"{this.FirstName} {this.LastName} is a {this.Occupation}.";
}

class MathConstant
{
    // Class constants
    public const double PI = 3.14;
}

// Classs Inheritance I
// Base Class
class Human
{
    static int count = 0;

    public Human()
    {
        count++;
        Console.WriteLine("Human is created");
    }

    public void DoCount() =>
        Console.WriteLine($"There are {count} human/s.");
}

// Derived Class 1
class Madoka : Human
{
    public Madoka()
    {
        Console.WriteLine("Madoka is created");
    }
}

// Derived Class 2
class Toru : Human
{
    public Toru()
    {
        Console.WriteLine("Toru is created");
    }
}

// Class Inheritance II  
class Shape
{
    protected int x;
    protected int y;

    public Shape()
    {
        Console.WriteLine("Shape is created");
    }

    public Shape(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}

class Circle : Shape
{
    private int r;

    public Circle(int r, int x, int y) : base(x, y)
    {
        this.r = r;
    }

    public override string ToString()
    {
        return String.Format("Circle, r:{0}, x:{1}, y:{2}", r, x, y);
    }
}

// Abstract Classes and Method
abstract class Drawing
{
    protected int x = 0;
    protected int y = 0;
    public abstract double Area();
    public string GetCoordinates() =>
        string.Format($"x:{this.x}, y:{this.y}");
}

// Derived Class from Abstract Class
class Square : Drawing
{
    public Square(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public override double Area() =>
        this.x * this.y;
    public override string ToString() =>
        string.Format($"Square at x:{this.x}, y:{this.y}");
}

// Partial Classes
// Partial Class I
partial class Worker
{
    public string DoWork()
    {
        return "Doing work";
    }
}
// Partial Class II
partial class Worker
{
    public string DoPause()
    {
        return "Pausing";
    }
}