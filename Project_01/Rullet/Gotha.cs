using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Rullet
{
    class Gotha : Item
    {
        

        public void Gotcha()
        {
            abstractItem[] item = new abstractItem[1000];
            Random ran = new Random();
            
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

            int intputnum = 0; //랜덤값을 받아와서 저장함 (저장받지 않으면 뽑기종료시 다른값을 받아옴)
            
            int count = 0;
            while (true)
            {
                BackgroundColor = ConsoleColor.Black;
                ForegroundColor = ConsoleColor.Red;
                SetCursorPosition(40, 25);
                Console.Write("뽑기를 진행 하시겠습니까? (Y/N)");

                string Answer = Console.ReadLine();
                
                
                if (Answer == "Y" && coin > 0)
                {
                    Console.Clear();
                    intputnum = ran.Next(0, 1000);
                    
                    item[intputnum].PrintStat();
                    count++;
                    coin -= 500;
                    SetCursorPosition(130, 0);
                    Console.WriteLine($"잔여코인 {coin}");
                }
                
                else if (Answer == "N" && coin > 0)
                {
                    Console.Clear();
                    SetCursorPosition(130, 27);
                    Console.WriteLine($"뽑기를 종료합니다.");
                    SetCursorPosition(130, 28);
                    Console.WriteLine($"총뽑기횟수 {count}");
                    item[intputnum].PrintStat();
                    item[intputnum].smith();
                    break;
                }
                else if (coin < 0)
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
