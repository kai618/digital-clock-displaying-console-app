using System;
namespace Time
{
    public class Position //co tat ca 9 vi tri theo layout [ 12 : 34 : 56 am ]
    {
        private int starting_x;
        private int starting_y;

        public void SetStartingPoint(int a, int b)
        {
            starting_x = a;
            starting_y = b;
        }
        private void PrintAt(string s, int x, int y)
        {
            Console.SetCursorPosition(starting_x + x, starting_y + y);
            Console.Write(s);
        }
        public void Show(char Character)
        {
            switch (Character)
            {
                case ' ':
                    PrintAt(" ", 0, 0);
                    PrintAt(" ", 0, 1);
                    PrintAt(" ", 0, 2);
                    PrintAt(" ", 0, 3);
                    PrintAt(" ", 0, 4);
                    PrintAt(" ", 2, 0);
                    PrintAt(" ", 2, 1);
                    PrintAt(" ", 2, 2);
                    PrintAt(" ", 2, 3);
                    PrintAt(" ", 2, 4);
                    PrintAt(" ", 4, 0);
                    PrintAt(" ", 4, 1);
                    PrintAt(" ", 4, 2);
                    PrintAt(" ", 4, 3);

                    PrintAt(" ", 4, 4);
                    break;
                case '0':
                    PrintAt("*", 0, 0);
                    PrintAt("*", 0, 1);
                    PrintAt("*", 0, 2);
                    PrintAt("*", 0, 3);
                    PrintAt("*", 0, 4);
                    PrintAt("*", 2, 0);
                    PrintAt("*", 2, 4);
                    PrintAt("*", 4, 0);
                    PrintAt("*", 4, 1);
                    PrintAt("*", 4, 2);
                    PrintAt("*", 4, 3);
                    PrintAt(" ", 2, 1);
                    PrintAt(" ", 2, 2);
                    PrintAt(" ", 2, 3);

                    PrintAt("*", 4, 4);
                    break;
                case '1':
                    PrintAt("*", 0, 0);
                    PrintAt("*", 0, 4);
                    PrintAt("*", 2, 0);
                    PrintAt("*", 2, 1);
                    PrintAt("*", 2, 2);
                    PrintAt("*", 2, 3);
                    PrintAt("*", 2, 4);
                    PrintAt(" ", 0, 1);
                    PrintAt(" ", 0, 2);
                    PrintAt(" ", 0, 3);
                    PrintAt(" ", 4, 0);
                    PrintAt(" ", 4, 1);
                    PrintAt(" ", 4, 2);
                    PrintAt(" ", 4, 3);

                    PrintAt("*", 4, 4);
                    break;
                case '2':
                    PrintAt("*", 0, 0);
                    PrintAt("*", 0, 2);
                    PrintAt("*", 0, 3);
                    PrintAt("*", 0, 4);
                    PrintAt("*", 2, 0);
                    PrintAt("*", 2, 2);
                    PrintAt("*", 2, 4);
                    PrintAt("*", 4, 0);
                    PrintAt("*", 4, 1);
                    PrintAt("*", 4, 2);
                    PrintAt(" ", 0, 1);
                    PrintAt(" ", 2, 1);
                    PrintAt(" ", 2, 3);
                    PrintAt(" ", 1, 3);
                    PrintAt(" ", 4, 3);

                    PrintAt("*", 4, 4);
                    break;
                case '3':
                    PrintAt("*", 0, 2);
                    PrintAt("*", 0, 0);
                    PrintAt("*", 0, 4);
                    PrintAt("*", 2, 0);
                    PrintAt("*", 2, 4);
                    PrintAt("*", 2, 2);
                    PrintAt("*", 4, 0);
                    PrintAt("*", 4, 1);
                    PrintAt("*", 4, 2);
                    PrintAt("*", 4, 3);
                    PrintAt("*", 4, 4);
                    PrintAt(" ", 0, 1);
                    PrintAt(" ", 0, 3);
                    PrintAt(" ", 2, 1);
                    PrintAt(" ", 2, 3);

                    PrintAt("*", 4, 4);
                    break;
                case '4':
                    PrintAt("*", 0, 0);
                    PrintAt("*", 0, 1);
                    PrintAt("*", 0, 2);
                    PrintAt("*", 2, 2);
                    PrintAt("*", 4, 0);
                    PrintAt("*", 4, 1);
                    PrintAt("*", 4, 2);
                    PrintAt("*", 4, 3);
                    PrintAt(" ", 0, 3);
                    PrintAt(" ", 0, 4);
                    PrintAt(" ", 2, 1);
                    PrintAt(" ", 2, 3);
                    PrintAt(" ", 2, 0);
                    PrintAt(" ", 2, 4);

                    PrintAt("*", 4, 4);
                    break;
                case '5':
                    PrintAt("*", 0, 0);
                    PrintAt("*", 0, 1);
                    PrintAt("*", 0, 2);
                    PrintAt("*", 0, 4);
                    PrintAt("*", 2, 0);
                    PrintAt("*", 2, 2);
                    PrintAt("*", 2, 4);
                    PrintAt("*", 4, 0);
                    PrintAt("*", 4, 2);
                    PrintAt("*", 4, 3);
                    PrintAt(" ", 0, 3);
                    PrintAt(" ", 2, 1);
                    PrintAt(" ", 2, 3);
                    PrintAt(" ", 4, 1);

                    PrintAt("*", 4, 4);
                    break;
                case '6':
                    PrintAt("*", 0, 0);
                    PrintAt("*", 0, 1);
                    PrintAt("*", 0, 2);
                    PrintAt("*", 0, 3);
                    PrintAt("*", 0, 4);
                    PrintAt("*", 2, 0);
                    PrintAt("*", 2, 2);
                    PrintAt("*", 2, 4);
                    PrintAt("*", 4, 0);
                    PrintAt("*", 4, 2);
                    PrintAt("*", 4, 3);
                    PrintAt(" ", 4, 1);

                    PrintAt("*", 4, 4);
                    break;
                case '7':
                    PrintAt("*", 0, 0);
                    PrintAt("*", 2, 0);
                    PrintAt("*", 4, 0);
                    PrintAt("*", 4, 1);
                    PrintAt("*", 4, 2);
                    PrintAt("*", 4, 3);
                    PrintAt(" ", 0, 1);
                    PrintAt(" ", 0, 2);
                    PrintAt(" ", 0, 3);
                    PrintAt(" ", 0, 4);
                    PrintAt(" ", 2, 1);
                    PrintAt(" ", 2, 2);
                    PrintAt(" ", 2, 3);
                    PrintAt(" ", 2, 4);

                    PrintAt("*", 4, 4);
                    break;
                case '8':
                    PrintAt("*", 0, 0);
                    PrintAt("*", 0, 1);
                    PrintAt("*", 0, 2);
                    PrintAt("*", 0, 3);
                    PrintAt("*", 0, 4);
                    PrintAt("*", 2, 0);
                    PrintAt("*", 2, 2);
                    PrintAt("*", 2, 4);
                    PrintAt("*", 4, 0);
                    PrintAt("*", 4, 1);
                    PrintAt("*", 4, 2);
                    PrintAt("*", 4, 3);
                    PrintAt(" ", 2, 1);
                    PrintAt(" ", 2, 3);

                    PrintAt("*", 4, 4);
                    break;
                case '9':
                    PrintAt("*", 0, 0);
                    PrintAt("*", 0, 1);
                    PrintAt("*", 0, 2);
                    PrintAt("*", 0, 4);
                    PrintAt("*", 2, 0);
                    PrintAt("*", 2, 2);
                    PrintAt("*", 2, 4);
                    PrintAt("*", 4, 0);
                    PrintAt("*", 4, 1);
                    PrintAt("*", 4, 2);
                    PrintAt("*", 4, 3);
                    PrintAt(" ", 0, 3);
                    PrintAt(" ", 2, 1);
                    PrintAt(" ", 2, 3);

                    PrintAt("*", 4, 4);
                    break;
                case ':':
                    PrintAt("*", 1, 1);
                    PrintAt("*", 1, 3);
                    break;
                case 'a':
                    PrintAt("*", 0, 1);
                    PrintAt("*", 0, 2);
                    PrintAt("*", 0, 3);
                    PrintAt("*", 2, 0);
                    PrintAt("*", 2, 2);
                    PrintAt("*", 4, 2);
                    PrintAt("*", 4, 1);
                    PrintAt("*", 4, 3);
                    PrintAt(" ", 0, 0);
                    PrintAt(" ", 2, 1);
                    PrintAt(" ", 2, 3);
                    PrintAt(" ", 4, 0);

                    PrintAt("*", 7, 0);
                    PrintAt("*", 7, 1);
                    PrintAt("*", 7, 2);
                    PrintAt("*", 7, 3);
                    PrintAt("*", 9, 1);
                    PrintAt("*", 11, 0);
                    PrintAt("*", 11, 1);
                    PrintAt("*", 11, 2);
                    PrintAt("*", 11, 3);
                    break;
                case 'p':
                    PrintAt("*", 0, 0);
                    PrintAt("*", 0, 1);
                    PrintAt("*", 0, 2);
                    PrintAt("*", 0, 3);
                    PrintAt("*", 2, 0);
                    PrintAt("*", 2, 2);
                    PrintAt("*", 4, 1);
                    PrintAt(" ", 2, 3);
                    PrintAt(" ", 2, 3);
                    PrintAt(" ", 4, 0);
                    PrintAt(" ", 4, 2);
                    PrintAt(" ", 4, 3);

                    PrintAt("*", 7, 0);
                    PrintAt("*", 7, 1);
                    PrintAt("*", 7, 2);
                    PrintAt("*", 7, 3);
                    PrintAt("*", 9, 1);
                    PrintAt("*", 11, 0);
                    PrintAt("*", 11, 1);
                    PrintAt("*", 11, 2);
                    PrintAt("*", 11, 3);
                    break;
                case 'h':
                    PrintAt("HIEU", 0, 0);
                    break;
                case 'd':
                    string s = DateTime.Today.ToString("dd-MM-yyyy");
                    PrintAt(s, 0, 0);
                    break;
            }
        }
    }
}