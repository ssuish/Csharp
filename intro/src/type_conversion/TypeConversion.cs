class TypeConversion
{
    public void Implicit()
    {
        // Implicit type conversion automatically converts one type to another.
        
        int x = 500;
        Console.WriteLine($"Type of x: {x.GetType()} \nValue of x: {x} ");
        Console.WriteLine("assigning int x to double y...");

        double y = x;
        Console.WriteLine($"Type of y: {y.GetType()} \nValue of y: {y}");
    }

    public void Explicit()
    {
        // Explicit type conversion 

        double x = 500;
        Console.WriteLine($"Type of x: {x.GetType()} \nValue of x: {x} ");
        Console.WriteLine("assigning double x to int y...");

        int y = (int)x;
        Console.WriteLine($"Type of y: {y.GetType()} \nValue of y: {y}");
    }

    public void Parsing()
    {

    }

    public void ConvertClass()
    {

    }
}