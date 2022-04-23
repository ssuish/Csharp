// C# Functions and Classes
/*

C# Function syntax
<access modifier> <return type> <method name> (<parameter list>)
{
    // method body
    
    return // if return type is not void.
}

*/

static void printReverse(string str)
{
    try
    {
        if (str != null && str != string.Empty)
        {
            Console.Write("Reverse result: ");
            for (int i = 0; i < str.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(str[str.Length - i - 1]);
                Console.ResetColor();
            }
        }
        else
        {  
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("User input is empty!");
            Console.ResetColor();
        }
    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Fatal Error occured:\n" + ex);
        Console.ResetColor();
    }
}

try
{
    Console.Write("Enter a words or sentences to reverse: ");
    Console.ForegroundColor = ConsoleColor.Green;
    string str = Console.ReadLine() ?? string.Empty;
    Console.ResetColor();
    printReverse(str.Trim());
}
catch (Exception ex)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Fatal Error occured:\n" + ex);
    Console.ResetColor();
}