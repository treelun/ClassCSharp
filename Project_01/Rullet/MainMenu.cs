using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Rullet
{
    class MainMenu
    {
        public void mainMenu(ref int posY, ref string first, ref string Second, ref string Third)
        {
            
            bool Start = false;
            SetCursorPosition(30, 25);
            WriteLine(first);

            SetCursorPosition(30, 26);
            WriteLine(Second);

            SetCursorPosition(30, 27);
            WriteLine(Third);

            do
            {
                for (int k = 0; k < 3; k++)
                {
                    SetCursorPosition(25, k + 25);
                    Write("  ");
                }
                SetCursorPosition(25, posY + 25);
                Write("▶");

                ConsoleKeyInfo key = ReadKey(true);


                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        posY--;//(Y축 방향으로 위로1칸)
                        if (posY < 0)//(posY값이 0보다 작으면 원하는 출력값이 나오지않으므로 0보다 작을시 1로 바꿔줌)
                        {
                            posY = 2;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        posY++;//(Y축 방향으로 아래로1칸)
                        if (posY > 2)//(posY값이 1보다 클경우 원하는 출력값이 나오지않기에 0으로 돌려줌)
                        {
                            posY = 0;
                        }
                        break;
                    case ConsoleKey.Enter:

                        Start = true;
                        Clear();
                        break;
                }

            } while (!Start);
        }

        public void Title()
        {
            SetCursorPosition(50, 15);
            WriteLine(@"
                                @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
                                @@@        아이템 강화하기!       @@@
                                @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
        }

        public void Menu(ref int posY, ref string first, ref string Second)
        {

            bool Start = false;
            SetCursorPosition(30, 25);
            WriteLine(first);

            SetCursorPosition(30, 26);
            WriteLine(Second);



            do
            {
                for (int k = 0; k < 2; k++)
                {
                    SetCursorPosition(25, k + 25);
                    Write("  ");
                }
                SetCursorPosition(25, posY + 25);
                Write("▶");

                ConsoleKeyInfo key = ReadKey(true);


                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        posY--;//(Y축 방향으로 위로1칸)
                        if (posY < 0)//(posY값이 0보다 작으면 원하는 출력값이 나오지않으므로 0보다 작을시 1로 바꿔줌)
                        {
                            posY = 1;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        posY++;//(Y축 방향으로 아래로1칸)
                        if (posY > 1)//(posY값이 1보다 클경우 원하는 출력값이 나오지않기에 0으로 돌려줌)
                        {
                            posY = 0;
                        }
                        break;
                    case ConsoleKey.Enter:

                        Start = true;
                        Clear();
                        break;
                }

            } while (!Start);
        }
    }
}
