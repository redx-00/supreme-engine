using System;
using System.Threading;

class Program
{
    static int Main()
    {
        string[] frames = { "\\", "|", "/", "-" };
        int frame = 0;

        try
        {
            Console.CursorVisible = false;
            Console.Write("Press Enter to close ");

            while (true)
            {
                Console.Write(frames[frame]);
                Console.Write('\b');

                frame = (frame + 1) % frames.Length;

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(intercept: true);
                    if (key.Key == ConsoleKey.Enter)
                        break;
                }

                Thread.Sleep(100);
            }

            Console.WriteLine();
            return 0;
        }
        finally
        {
            Console.CursorVisible = true;
        }
    }
}
