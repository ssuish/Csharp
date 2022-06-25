// Multi-Menus in Console App
namespace MultiMenu;

public class App
{
    public int Run()
    {
        // Only codes here are executed.

        bool cky = true;
        while (cky)
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("GOTO: [0] Menu A [1] Menu B [Esc] Exit");
            if (Console.ReadKey(true).Key == ConsoleKey.D0)
            {
                
            }
            else if (Console.ReadKey(true).Key == ConsoleKey.D1)
            {

            }
            else if (Console.ReadKey(true).Key == ConsoleKey.Escape)
            {
                cky = false;
            }
        }

        return 0;
    }


}