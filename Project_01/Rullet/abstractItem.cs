using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace Rullet
{
    abstract class abstractItem : Item
    {
        public abstractItem() : base()
        {
            //InitData();
            
        }

        public abstract void InitData();

        public void Smith(ref int coin) // 아이템강화 함수
        {
            MainMenu main = new MainMenu();
            Random ran = new Random();
            
            int posY = 0;
            string first = "강화를 시도 합니다.";
            string Second = "강화를 하지 않습니다.";

            while (true)
            {
                BackgroundColor = ConsoleColor.Black;
                ForegroundColor = ConsoleColor.Cyan;

                main.Menu(ref posY, ref first, ref Second, false);

                int num = ran.Next(0, 9);
                if (WeaponLevel >= 0 && WeaponLevel < 5 && coin > 0 && posY == 0)
                {
                    Completeindex(ref posY, ref coin, 2, 100, 100);
                    continue;
                }
                else if (WeaponLevel >= 5 && WeaponLevel < 10 && num < 7 && posY == 0 && coin > 0)
                {
                    Completeindex(ref posY, ref coin, 5,  70, 500);
                    continue;
                }
                else if (WeaponLevel > 5 && WeaponLevel < 10 && num > 6 && coin > 0 && posY == 0)
                {
                    Faildindex(ref posY, ref coin, 5, 70, 500);
                    continue;
                }
                else if (WeaponLevel == 10 && num > 2 && coin > 0 && posY == 0)
                {
                    Faildindex(ref posY, ref coin, 5, 70, 500);
                    continue;
                }
                else if (WeaponLevel >= 10 && WeaponLevel < 15 && num <= 2 && coin > 0 && posY == 0)
                {
                    Completeindex(ref posY, ref coin, 10,  30, 1000);
                    continue;
                }
                else if (WeaponLevel > 10 && WeaponLevel < 15 && num > 2 && coin > 0 && posY == 0)
                {
                    Faildindex(ref posY, ref coin, 10, 30, 1000);
                    continue;
                }



                else if (coin <= 0 && posY == 0)
                {
                    Clear();
                    SetCursorPosition(60, 22);
                    Console.WriteLine("코인이 부족합니다.");
                    SetCursorPosition(60, 23);
                    Console.WriteLine("강화를 종료합니다.");
                    break;
                }
                else if (WeaponLevel > 0 && posY == 1)
                {
                        
                    SetCursorPosition(60, 22);
                    Console.WriteLine("강화가 완료되었습니다.");
                    SetCursorPosition(60, 23);
                    Console.WriteLine($"최종 강화레벨 : {WeaponLevel} 최종 데미지 : {WeaponDamage}");
                    break;
                }
                
            }

        }



    }
}
