namespace ReadKey_Log;

class ReadKey
{
    public int Run()
    {
        bool prog = true;
        Console.WriteLine("Esc to Escape");
        while (prog)
        {
            ConsoleKey key = Console.ReadKey(true).Key;
            Console.WriteLine(key);
            if (key == ConsoleKey.Escape)
            {
                prog = false;
            }
        }

        return 0;
    }
}