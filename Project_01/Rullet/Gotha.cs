using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace Rullet
{
    class Gotha : Item
    {
        
        public void Setting(abstractItem[] item)
        {
            
            

            for (int i = 0; i < item.Length; i++)
            {
                if (i <= 300) //30%
                {
                    item[i] = new Woodstick();
                }
                else if (i > 300 && i <= 500) // 20%
                {
                    item[i] = new Glove();
                }
                else if (i > 500 && i <= 700) // 20%
                {
                    item[i] = new StoneSword();
                }
                else if (i > 700 && i <= 800) //10%
                {
                    item[i] = new BronzeDagger();
                }
                else if (i > 800 && i <= 900) //10%
                {
                    item[i] = new StillSword();
                }
                else if (i > 900 && i <= 960)//6%
                {
                    item[i] = new TitanumSword();
                }
                else if (i > 960 && i <= 980)//2%
                {
                    item[i] = new AdamanSword();
                }
                else if (i > 980 && i <= 995)//1.5%
                {
                    item[i] = new BibranumSword();
                }
                else if (i > 995 && i <= 1000)//0.5%
                {
                    item[i] = new DarkmetterSword();
                }
            }
            
        }
        public void Gotcha(abstractItem[] item, ref int RandomNum, ref int coin, int posY)
        {
            
            Setting(item);
            MainMenu main = new MainMenu();
            posY = 0;
            int count = 0;
            
            
            while (true)
            {
                BackgroundColor = ConsoleColor.Black;
                ForegroundColor = ConsoleColor.Red;


                if (posY == 0 && coin > 0)
                {
                    Console.Clear();
                    item[RandomNum].PrintStat();
                    count++;
                    coin -= 500;
                    SetCursorPosition(95, 0);
                    Console.WriteLine($"잔여코인 {coin}");
                    Thread.Sleep(500);
                    break;
                }

                else if (posY == 1 && coin > 0)
                {
                    Console.Clear();
                    SetCursorPosition(95, 27);
                    Console.WriteLine($"뽑기를 종료합니다.");
                    SetCursorPosition(95, 28);
                    Console.WriteLine($"총뽑기횟수 {count}");
                    item[RandomNum].PrintStat();
                    //item[RandomNum].Smith();
                    break;
                }
                else if (coin < 0 && posY == 0)
                {
                    SetCursorPosition(40, 20);
                    Console.WriteLine($"코인이 부족합니다. 게임을 종료합니다.");
                    break;
                }
                else
                {
                    SetCursorPosition(40, 20);
                    Console.WriteLine($"잘못된 입력입니다. 다시 입력해 주세요");
                    continue;
                }

            }
            
        }

    }
}
