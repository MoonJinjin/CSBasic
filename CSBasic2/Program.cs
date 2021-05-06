using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("입력:");
            string line = Console.ReadLine();
            if (line.Contains("안녕"))
            {
                Console.WriteLine("너도 안녕~");
            }else if (line.Contains("바보"))
            {
                Console.WriteLine("너가 바보야!");
            }else if (line.Contains("밥"))
            {
                Console.WriteLine("배고파~");
            }
            else
            {
                Console.WriteLine("심심해~");
            }

            ConsoleKeyInfo info;
            bool isLoop = true;
            while (isLoop)
            {
                info = Console.ReadKey();
                switch (info.Key)
                {
                    case ConsoleKey.UpArrow:
                        Console.Write("↑");
                        break;
                    case ConsoleKey.DownArrow:
                        Console.Write("↓");
                        break;
                    case ConsoleKey.RightArrow:
                        Console.Write("→");
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.Write("←");
                        break;
                    case ConsoleKey.Escape:
                        Console.WriteLine("으악!");
                        isLoop = false;
                        break;
                    default:
                        Console.WriteLine("\nUnknown key");
                        break;
                }
            }
        }
    }
}
