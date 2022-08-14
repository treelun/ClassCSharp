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
        public void mainMenu(ref int posY, ref string first, ref string Second, ref string Third, ref string Fourth)
        {
            
            bool Start = false;
            SetCursorPosition(20, 20);
            WriteLine(first);

            SetCursorPosition(20, 21);
            WriteLine(Second);

            SetCursorPosition(20, 22);
            WriteLine(Third);

            SetCursorPosition(20, 23);
            WriteLine(Fourth);

            do
            {
                for (int k = 0; k < 4; k++)
                {
                    SetCursorPosition(17, k + 20);
                    Write("  ");
                }
                SetCursorPosition(17, posY + 20);
                Write("▶");

                ConsoleKeyInfo key = ReadKey(true);


                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        posY--;//(Y축 방향으로 위로1칸)
                        if (posY < 0)//(posY값이 0보다 작으면 원하는 출력값이 나오지않으므로 0보다 작을시 1로 바꿔줌)
                        {
                            posY = 3;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        posY++;//(Y축 방향으로 아래로1칸)
                        if (posY > 3)//(posY값이 1보다 클경우 원하는 출력값이 나오지않기에 0으로 돌려줌)
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

        public void Menu(ref int posY, ref string first, ref string Second, bool Start)
        {

            
            SetCursorPosition(20, 20);
            WriteLine(first);

            SetCursorPosition(20, 21);
            WriteLine(Second);



            do
            {
                for (int k = 0; k < 2; k++)
                {
                    SetCursorPosition(17, k + 20);
                    Write("  ");
                }
                SetCursorPosition(17, posY + 20);
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

        public void MonsterSelectMenu(ref int posY, ref string f, ref string d, ref string c, ref string b, ref string a, ref string S, ref string boss)
        {

            bool Start = false;
            SetCursorPosition(20, 15);
            WriteLine("몬스터 등급을 선택하세요");
            SetCursorPosition(20, 16);
            WriteLine(f);

            SetCursorPosition(20, 17);
            WriteLine(d);

            SetCursorPosition(20, 18);
            WriteLine(c);

            SetCursorPosition(20, 19);
            WriteLine(b);

            SetCursorPosition(20, 20);
            WriteLine(a);

            SetCursorPosition(20, 21);
            WriteLine(S);

            SetCursorPosition(20, 22);
            WriteLine(boss);



            do // 화살표 위치 조정
            {
                for (int k = 0; k < 6; k++)
                {
                    SetCursorPosition(16, k + 16);
                    Write("  ");
                }
                SetCursorPosition(16, posY + 16);

                Write("▶");

                ConsoleKeyInfo key = ReadKey(true);


                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        posY--;//(Y축 방향으로 위로1칸)
                        if (posY < 0)//(posY값이 0보다 작으면 원하는 출력값이 나오지않으므로 0보다 작을시 1로 바꿔줌)
                        {
                            posY = 6;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        posY++;//(Y축 방향으로 아래로1칸)
                        if (posY > 6)//<<값이 움직일수 있는 최대 범위
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
