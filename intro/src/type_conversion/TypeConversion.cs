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
        // (int) x, is a cast expression that explicitly converts the double x into int type.
        Console.WriteLine($"Type of y: {y.GetType()} \nValue of y: {y}");
    }

    public void Parsing()
    {
        // Using Parse() method.

        string x = "500";
        int y = int.Parse(x);
        Console.WriteLine($"Type of x: {x.GetType()} \nValue of original string x: {x} ");
        Console.WriteLine($"Converted int value: {y}");

        // Using TryParse() method.
        string z = "500";
        bool isValid = int.TryParse(z, out int result);
        // TryParse() returns boolean value, and returns parsed value in variable 'result'.
        if (isValid)
        {
            Console.WriteLine($"Type of x: {z.GetType()} \nValue of original string x: {z} ");
            Console.WriteLine($"TryParse result: {isValid} \nConverted int value: {result}");
        }
        else
        {
            Console.WriteLine("Parsing error occurs");
            Console.WriteLine($"TryParse result: {isValid} \nConverted int value: {result}");
        }
    }

    public void ConvertClass()
    {
        // Using Convert class has methods that converts a type into boolean, char, double, int, and string.
        // create int variable

        int num = 100;
        Console.WriteLine("int value: " + num);

        // convert int to string
        string str = Convert.ToString(num);
        Console.WriteLine("string value: " + str);

        // convert int to Double
        Double doubleNum = Convert.ToDouble(num);
        Console.WriteLine("Double value: " + doubleNum);
    }
}