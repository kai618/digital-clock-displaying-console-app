//hoan thanh ngay 17/10/2018
using System;
namespace Time
{    
    public class Program
    {
        public static void Main()
        {
            Console.SetWindowSize(90, 12);

            Core coreTime = new Core();
            Clock Clock = new Clock();

            coreTime.SetStartingTime();

            Console.CursorVisible = false;
            Console.Clear();
            
            //chon kieu dong ho va xuat
            ConsoleKeyInfo a;
            Console.WriteLine("CHOOSE THE CLOCK TYPE >>\n12H Clock - Press key 1\n24H Clock - Press key 2");
            do
            {
                a = Console.ReadKey();
            } while (a.Key != ConsoleKey.D1 && a.Key != ConsoleKey.D2
                && a.Key != ConsoleKey.NumPad1 && a.Key != ConsoleKey.NumPad2);
            Console.Clear();
            if (a.Key == ConsoleKey.D1 || a.Key == ConsoleKey.NumPad1) Clock.ShowClock12H(coreTime);
            else Clock.ShowClock24H(coreTime);            
        }
    }
}