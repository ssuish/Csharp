// ===========================================================
// Object Oriented Programming with C# 
/*
    Links for reference: 
    - https://zetcode.com/lang/csharp/oopi/
    - https://zetcode.com/lang/csharp/oopii/
    - https://zetcode.com/lang/csharp/methods/
    - https://zetcode.com/lang/csharp/properties/
    - https://zetcode.com/lang/csharp/structures/
    - https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/classes-and-structs
*/
// ===========================================================

// Object Attributes and Instances
var person = new Person("ABC");
Console.WriteLine(person.Name);

var person2 = new Person("DEF");
Console.WriteLine(person2.Name);

var person3 = new Person("GHI", 30);
Console.WriteLine(person3.Name, person3.Age);