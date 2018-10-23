using System;
namespace Time
{
    public class Core //kernel la clock 24h
    {
        public int h;
        public int m;
        public int s;

        public char[] hh = new char[2]; //hh[0] luu hang don vi, hh[1] luu hang chuc cua gia tri hour
        public char[] mm = new char[2]; //mm[0] luu hang don vi, mm[1] luu hang chuc cua gia tri minute
        public char[] ss = new char[2]; //ss[0] luu hang don vi, ss[1] luu hang chuc cua gia tri giay

        public void SetStartingTime()
        {
            string hstr, mstr, sstr;

            Console.WriteLine("SET THE TIME >>");
            Console.Write("Input the hours: ");
            hstr = Console.ReadLine();
            if (!int.TryParse(hstr, out h) || h < 0 || h > 23)
            {
                Console.Write("!!! The value must be between 0 - 23: ");
                do
                {
                    hstr = Console.ReadLine();
                } while (!int.TryParse(hstr, out h) || h < 0 || h > 23);
            }

            Console.Write("Input the minutes: ");
            mstr = Console.ReadLine();
            if (!int.TryParse(mstr, out m) || m < 0 || m > 59)
            {
                Console.Write("!!! The value must be between 0 - 59: ");
                do
                {
                    mstr = Console.ReadLine();
                } while (!int.TryParse(mstr, out m) || m < 0 || m > 59);
            }

            Console.Write("Input the seconds: ");
            sstr = Console.ReadLine();
            if (!int.TryParse(sstr, out s) || s < 0 || s > 59)
            {
                Console.Write("!!! The value must be between 0 - 59: ");
                do
                {
                    sstr = Console.ReadLine();
                } while (!int.TryParse(sstr, out s) || s < 0 || s > 59);
            }
        }
        public void Increase1Sec()
        {
            s++;
            if (s == 60)
            {
                s = 0;
                m++;
                if (m == 60)
                {
                    m = 0;
                    h++;
                    if (h == 24) h = 0;
                }
            }
        }
        public void ConvertTo24H()
        {
            if (h < 10) hh[0] = ' ';
            else hh[0] = (char)(h / 10 + 48);
            hh[1] = (char)(h % 10 + 48);

            mm[0] = (char)(m / 10 + 48);
            mm[1] = (char)(m % 10 + 48);

            ss[0] = (char)(s / 10 + 48);
            ss[1] = (char)(s % 10 + 48);
            // + 48 de chuyen doi trong bang ma unicode
            // tu gia tri so sang ki tu so
            // VD: so 0 co ma unicode la 48
        }
        public void ConvertTo12H()
        {
            if (h <= 12)
            {
                if (h < 10) hh[0] = ' ';
                else hh[0] = (char)(h / 10 + 48);
                hh[1] = (char)(h % 10 + 48);
            }
            else
            {
                if (h - 12 < 10) hh[0] = ' ';
                else hh[0] = (char)((h - 12) / 10 + 48);
                hh[1] = (char)((h - 12) % 10 + 48);
            }

            mm[0] = (char)(m / 10 + 48);
            mm[1] = (char)(m % 10 + 48);

            ss[0] = (char)(s / 10 + 48);
            ss[1] = (char)(s % 10 + 48);
        }
    }
}