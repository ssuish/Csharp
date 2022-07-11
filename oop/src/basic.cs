/*
// Object Attributes and Instances
var person = new Person("ABC");
Console.WriteLine(person.Name);
// Expected: ABC

var person2 = new Person("DEF");
Console.WriteLine(person2.Name);
// Expected: DEF

// with Constructor Chaining
var person3 = new Person("GHI", 30);
Console.WriteLine($"{person3.Name} is {person3.Age} years old");
// Expected: GHI is 30 years old

// with method overriding
Console.WriteLine(person3.ToString());
// Expected: GHI is 30 years old

// Object Initializer with empty constructor
var person4 = new Person { Name = "JKL", Age = 40 };
Console.WriteLine($"{person4.Name} is {person4.Age} years old");
// Expected: JKL is 40 years old

// Calling expression-bodied constructor
var Job = new Job("Someone", 1200);
Console.WriteLine(Job.ToString());
// Expected: Someone is 1200 dollars

// ===========================================================
// New OOP Feature for C# 9.0
// Target-Typed new expression
/* 
    The var keyword can be used to omit the type declaration on 
    the left side of the assignment, since the compiler can infer 
    the type from the right side.


var u1 = new User("Roger", "Roe", "Driver");
Console.WriteLine(u1);

/*
    The target-typed new expression allows us to omit the type 
    declaration on the right side of the assignment.


User u2 = new("John", "Doe", "Gardener");
Console.WriteLine(u2);

/*
    In a list initializer, we save a few key strokes by omitting 
    the type for each user.


var users = new List<User>
{
    new("Thomas", "Roove", "programmer"),
    new("Lucia", "Smith", "hair dresser"),
    new("Peter", "Holcomb", "painter"),
    new("Orlando", "Black", "actor"),
    new("Patrick", "Allen", "police officer")
};

// Print all data in the list

foreach (var u in users)
{
    Console.WriteLine(u);
}
// ===========================================================

// Class Inheritance II
var human = new Human();
human.DoCount();
var mdk = new Madoka();
mdk.DoCount();
var toru = new Toru();
toru.DoCount();

/* Expected Output
    Human is created
        There are 1 human/s.
    Human is created
        Madoka is created
            There are 2 human/s.
    Human is created
        Toru is created
            There are 3 human/s.


// Class Inheritance II
var circle = new Circle(6, 4, 5);
Console.WriteLine(circle.ToString());

/*  Expected Output
    Circle, r:6, x:4, y:5


// Abstract Classes and Method
var c = new Square(12, 45);
Console.WriteLine(c);
Console.WriteLine($"Area of Square:{c.Area()}");
Console.WriteLine(c.GetCoordinates());

/* Expected Results:
    Square at x:12, y:45
    Area of Square:540
    x:12, y:45


// Partial Classes
var worker = new Worker();
// Calling partial classes
Console.WriteLine(worker.DoWork());
Console.WriteLine(worker.DoWork());
Console.WriteLine(worker.DoPause());

/* Expected Result
    Doing work
    Doing work
    Pausing
*/