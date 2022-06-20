class Person
{
    // Object Attributes
    private string _name;
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
}   