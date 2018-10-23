using System;
using System.Threading;
namespace Time
{
    public class Clock
    {
        Position Position1 = new Position();
        Position Position2 = new Position();
        Position Position3 = new Position();
        Position Position4 = new Position();
        Position Position5 = new Position();
        Position Position6 = new Position();
        Position Colon1 = new Position();
        Position Colon2 = new Position();
        Position AmPm = new Position();
        Position date = new Position();
        Position hieuLabel = new Position();
        private static int i; //dung cho ham ShowAMPM()

        void SetLayout24H()
        {
            int leftMargin = 15, topMargin = 3;
            Position1.SetStartingPoint(leftMargin, topMargin);
            Position2.SetStartingPoint(leftMargin + 8, topMargin);
            Colon1.SetStartingPoint(leftMargin + 15, topMargin);
            Position3.SetStartingPoint(leftMargin + 20, topMargin);
            Position4.SetStartingPoint(leftMargin + 28, topMargin);
            Colon2.SetStartingPoint(leftMargin + 35, topMargin);
            Position5.SetStartingPoint(leftMargin + 40, topMargin);
            Position6.SetStartingPoint(leftMargin + 48, topMargin);
            hieuLabel.SetStartingPoint(leftMargin + 38, topMargin + 5);
            date.SetStartingPoint(leftMargin + 43, topMargin + 5);
        }
        void SetLayout12H()
        {
            int leftMargin = 9, topMargin = 3;
            Position1.SetStartingPoint(leftMargin, topMargin);
            Position2.SetStartingPoint(leftMargin + 8, topMargin);
            Colon1.SetStartingPoint(leftMargin + 15, topMargin);
            Position3.SetStartingPoint(leftMargin + 20, topMargin);
            Position4.SetStartingPoint(leftMargin + 28, topMargin);
            Colon2.SetStartingPoint(leftMargin + 35, topMargin);
            Position5.SetStartingPoint(leftMargin + 40, topMargin);
            Position6.SetStartingPoint(leftMargin + 48, topMargin);
            AmPm.SetStartingPoint(leftMargin + 56, topMargin);
            hieuLabel.SetStartingPoint(leftMargin + 38, topMargin + 5);
            date.SetStartingPoint(leftMargin + 43, topMargin + 5);
        }
        public void ShowClock24H(Core coreTime)
        {
            SetLayout24H();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Colon1.Show(':');
            Colon2.Show(':');
            hieuLabel.Show('h');
            date.Show('d');
            Console.ForegroundColor = ConsoleColor.White;
            coreTime.ConvertTo24H();
            Position1.Show(coreTime.hh[0]);
            Position2.Show(coreTime.hh[1]);
            Position3.Show(coreTime.mm[0]);
            Position4.Show(coreTime.mm[1]);
            Position5.Show(coreTime.ss[0]);
            Position6.Show(coreTime.ss[1]);

            while (true)
            {
                coreTime.Increase1Sec();
                coreTime.ConvertTo24H();
                Thread.Sleep(1000);

                Position6.Show(coreTime.ss[1]);
                if (coreTime.s % 10 == 0) Position5.Show(coreTime.ss[0]);
                if (coreTime.s == 0)
                {
                    Position4.Show(coreTime.mm[1]);
                    if (coreTime.m % 10 == 0) Position3.Show(coreTime.mm[0]);
                }
                if (coreTime.m == 0)
                {
                    Position2.Show(coreTime.hh[1]);
                    if (coreTime.h % 10 == 0) Position1.Show(coreTime.hh[0]);
                }
            }

        }
        public void ShowAMPM()
        {
            if (i == 1)
            {
                AmPm.Show('p');
                i = -i;
            }
            else
            {
                AmPm.Show('a');
                i = -i;
            }
        }
        public void ShowClock12H(Core coreTime)
        {
            SetLayout12H();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Colon1.Show(':');
            Colon2.Show(':');
            hieuLabel.Show('h');
            date.Show('d');
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (coreTime.h > 11) i = 1;
            else i = -1;
            ShowAMPM();

            Console.ForegroundColor = ConsoleColor.White;
            coreTime.ConvertTo12H();
            Position6.Show(coreTime.ss[1]);
            Position5.Show(coreTime.ss[0]);
            Position4.Show(coreTime.mm[1]);
            Position3.Show(coreTime.mm[0]);
            Position2.Show(coreTime.hh[1]);
            Position1.Show(coreTime.hh[0]);

            while (true)
            {
                coreTime.Increase1Sec();
                coreTime.ConvertTo12H();
                Thread.Sleep(1000);

                Console.ForegroundColor = ConsoleColor.White;
                Position6.Show(coreTime.ss[1]);
                if (coreTime.s % 10 == 0) Position5.Show(coreTime.ss[0]);
                if (coreTime.s == 0)
                {
                    Position4.Show(coreTime.mm[1]);
                    if (coreTime.m % 10 == 0) Position3.Show(coreTime.mm[0]);
                }
                if (coreTime.m == 0)
                {
                    Position2.Show(coreTime.hh[1]);
                    if (coreTime.h % 10 == 0) Position1.Show(coreTime.hh[0]);
                }

                if (coreTime.s == 0 && coreTime.m == 0 && (coreTime.h == 0 || coreTime.h == 12))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    ShowAMPM();
                }
            }
        }
    }
}