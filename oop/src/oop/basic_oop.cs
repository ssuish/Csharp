namespace OOP; // declaring file-scoped namespace

// declaring public class Person
class Person
{
    // Access Modifiers
    /*
        - public: accessible from anywhere
        - private: accessible only from within the class
        - protected: accessible from within the class and from derived classes
        - internal: accessible from within the assembly
        - protected internal: accessible from within the assembly and derived classes
        - private protected: accessible from within the class and derived classes
    */

    // Object Attributes - Instance Variables
    private string _name; // Naming convention for private variables.
    private int _salary;
    // Object Attributes - Static Class Variables
    private static int _age;

    // Constructor
    public Person(string name, int age) // name is a params variable.
    {
        _name = name; // Instance initialization of private variables.
        _age = age;
    }

    // Class Objects - can be Methods, Fields, or Properties
    public string Name // Object Property
    {
        get { return _name; } // read property
        set { _name = value; } // write new value to property
    }

    // Alternative Declaration for Properties
    public int Age
    {
        get => _age;
        set => _age = value;
    }

    // Read-only Static Property
    public static double Salary
    {
        get => GetSalary(_age);
    }

    // Class Methods
    private static double GetSalary(int age)
    {
        return age > 16 ? Math.((age - 16) * 12000) : 0;
    }
}