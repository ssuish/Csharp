// Multi-Menus in Console App
namespace MultiMenu;

public class App
{
    public int Run()
    {
        // Only codes here are executed.

        bool loop = true;
        while (loop)
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("GOTO: [0] Menu A [1] Menu B [Esc] Exit");
            ConsoleKey key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.D0)
            {
                Console.WriteLine(key);
                loop = MenuA.StartMenuA();
            }
            else if (key == ConsoleKey.D1)
            {
                Console.WriteLine(key);
                loop = MenuB.StartMenuB();
            }
            else if (key == ConsoleKey.Escape)
            {
                loop = false;
            }
            else
            {
                Console.WriteLine(key);
                Console.WriteLine("Invalid Key");
            }
        }

        return 0;
    }
}

static class MenuA
{
    static public bool StartMenuA()
    {
        bool loop = true;
        while (loop)
        {
            Console.WriteLine("Welcome to MenuA");
            Console.WriteLine("GOTO: [0] SubMenuA [1] Back");
            ConsoleKey key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.D0)
            {
                Console.WriteLine(key);
                loop = SubMenuA();
            }
            else if (key == ConsoleKey.D1)
            {
                Console.WriteLine(key);
                break;
            }
            else
            {
                Console.WriteLine(key);
                Console.WriteLine("Invalid Key");
            }
        }
        return loop;
    }

    static bool SubMenuA()
    {
        bool loop = true;
        while (loop)
        {
            Console.WriteLine("Welcome to SubMenuA");
            Console.WriteLine("GOTO: [0] Back [Esc] Esc");
            ConsoleKey key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.D0)
            {
                Console.WriteLine(key);
                break;
            }
            else if (key == ConsoleKey.Escape) // Good
            {
                Console.WriteLine(key);
                return false;
            }
            else
            {
                Console.WriteLine(key);
                Console.WriteLine("Invalid Key");
            }
        }
        return loop;
    }
}

static class MenuB
{
    static public bool StartMenuB()
    {
        bool loop = true;
        while (loop)
        {
            Console.WriteLine("Welcome to MenuB");
            Console.WriteLine("GOTO: [0] SubMenuB [1] Back");
            ConsoleKey key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.D0)
            {
                Console.WriteLine(key);
                loop = SubMenuB();
            }
            else if (key == ConsoleKey.D1)
            {
                Console.WriteLine(key);
                break;
            }
            else
            {
                Console.WriteLine(key);
                Console.WriteLine("Invalid Key");
            }
        }
        return loop;
    }

    static bool SubMenuB()
    {
        bool loop = true;
        while (loop)
        {
            Console.WriteLine("Welcome to SubMenuB");
            Console.WriteLine("GOTO: [0] Back [Esc] Esc");
            ConsoleKey key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.D0)
            {
                Console.WriteLine(key);
                break;
            }
            else if (key == ConsoleKey.Escape) // Good
            {
                Console.WriteLine(key);
                return false;
            }
            else
            {
                Console.WriteLine(key);
                Console.WriteLine("Invalid Key");
            }
        }
        return loop;
    }
}