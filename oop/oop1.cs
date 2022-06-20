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