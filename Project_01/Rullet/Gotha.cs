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
/*        public void Listsetting()
        {
            Random random = new Random();
            int randomValue = random.Next(0, 1000);
            List<abstractItem> items = new List<abstractItem>();
            items.Add(new Weapon_Woodstick());
            items.Add(new Weapon_Glove());
            items.Add(new Weapon_StoneSword());
            items.Add(new Weapon_BronzeDagger());
            items.Add(new Weapon_StillSword());
            items.Add(new Weapon_TitanumSword());
            items.Add(new Weapon_AdamanSword());
            items.Add(new Weapon_BibranumSword());
            items.Add(new Weapon_DarkmetterSword());
            if (randomValue <= 300)
            {
                Console.WriteLine(items[0]);
            }
            else if (randomValue > 300 && randomValue <= 500)
            {
                Console.WriteLine(items[1]);
            }
            else if (randomValue > 500 && randomValue <= 700)
            {
                Console.WriteLine(items[2]);
            }
            else if (randomValue > 700 && randomValue <= 800)
            {
                Console.WriteLine(items[3]);
            }
            else if (randomValue > 800 && randomValue <= 900)
            {
                Console.WriteLine(items[4]);
            }
            else if (randomValue > 900 && randomValue <= 960)
            {
                Console.WriteLine(items[5]);
            }
            else if (randomValue > 960 && randomValue <= 980)
            {
                Console.WriteLine(items[6]);
            }
            else if (randomValue > 980 && randomValue <= 995)
            {
                Console.WriteLine(items[7]);
            }
            else if (randomValue > 995 && randomValue <= 1000)
            {
                Console.WriteLine(items[8]);
            }
            
        }*/
        public void Setting(abstractItem[] item)
        {

            for (int i = 0; i < item.Length; i++)
            {
                if (i <= 300) //30%
                {
                    item[i] = new Weapon_Woodstick();
                }
                else if (i > 300 && i <= 500) // 20%
                {
                    item[i] = new Weapon_Glove();
                }
                else if (i > 500 && i <= 700) // 20%
                {
                    item[i] = new Weapon_StoneSword();
                }
                else if (i > 700 && i <= 800) //10%
                {
                    item[i] = new Weapon_BronzeDagger();
                }
                else if (i > 800 && i <= 900) //10%
                {
                    item[i] = new Weapon_StillSword();
                }
                else if (i > 900 && i <= 960)//6%
                {
                    item[i] = new Weapon_TitanumSword();
                }
                else if (i > 960 && i <= 980)//2%
                {
                    item[i] = new Weapon_AdamanSword();
                }
                else if (i > 980 && i <= 995)//1.5%
                {
                    item[i] = new Weapon_BibranumSword();
                }
                else if (i > 995 && i <= 1000)//0.5%
                {
                    item[i] = new Weapon_DarkmetterSword();
                }
            }
            
        }

        public void Gotcha(abstractItem[] item, ref int RandomNum, ref int coin, int posY)
        {
            

            int count = 0;

            while (coin > 0)
            {
                SetCursorPosition(10, 5);
                WriteLine("어서오세요 뽑기상점입니다.");
                Thread.Sleep(1000);
                SetCursorPosition(10, 6);
                WriteLine("뽑기 1회당 500코인이 소비됩니다.");

                Thread.Sleep(1000);
                Clear();

                BackgroundColor = ConsoleColor.Black;
                ForegroundColor = ConsoleColor.Red;
                

                if (posY == 0 && coin > 0)
                {
                    PrintBox();
                    PrintOpenBox();
                    Thread.Sleep(500);
                    Console.Clear();
                    //RandomNum = random.Next(0, 1000);
                    item[RandomNum].InitData();
                    item[RandomNum].PrintStat();
                    count++;
                    coin -= 500;
                    SetCursorPosition(95, 0);
                    Console.WriteLine($"잔여코인 {coin}");
                    Thread.Sleep(100);
                    break;
                }

                else if (posY == 1 && coin > 0)
                {
                    Console.Clear();
                    SetCursorPosition(80, 27);
                    Console.WriteLine($"뽑기를 종료합니다.");
                    SetCursorPosition(80, 28);
                    Console.WriteLine($"총뽑기횟수 {count}");
                    item[RandomNum].PrintStat();
                    //item[RandomNum].Smith();
                    break;
                }
                else if (coin < 0 && posY >= 0)
                {
                    SetCursorPosition(40, 20);
                    Console.WriteLine($"코인이 부족합니다. 게임을 종료합니다.");
                    break;
                }
                else 
                {
                    SetCursorPosition(40, 20);
                    Console.WriteLine($"잘못된 입력입니다. 다시 입력해 주세요");
                    
                    break;
                }

            }
            if (coin <= 0)
            {
                WriteLine("코인이 부족하시네요 몬스터를 잡아 코인을 모아오세요");
            }
           
            
        }
        public void PrintBox()
        {

            BackgroundColor = ConsoleColor.Black;
            ForegroundColor = ConsoleColor.DarkYellow;

            SetCursorPosition(13, 5);
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
            SetCursorPosition(13, 6);
            Console.WriteLine("■                                                                                ■");
            SetCursorPosition(13, 7);
            Console.WriteLine("■                                                                                ■");
            SetCursorPosition(13, 8);
            Console.WriteLine("■                                                                                ■");
            SetCursorPosition(13, 9);
            Console.WriteLine("■                                                                                ■");
            SetCursorPosition(13, 10);
            Console.WriteLine("■                                                                                ■");
            SetCursorPosition(13, 11);
            Console.WriteLine("■                                                                                ■");
            SetCursorPosition(13, 12);
            Console.WriteLine("■                                                                                ■");
            SetCursorPosition(13, 13);
            Console.WriteLine("■            ■■■■■■■■■■■■■■■■■■■■■■■■■■■■            ■");
            SetCursorPosition(13, 14);
            Console.WriteLine("■            ■                                                    ■            ■");
            SetCursorPosition(13, 15);
            Console.WriteLine("■            ■                      ■■■■■■                  ■            ■");
            SetCursorPosition(13, 16);
            Console.WriteLine("■            ■■■■■■■■■■■■■        ■■■■■■■■■■■            ■");
            SetCursorPosition(13, 17);
            Console.WriteLine("■            ■                      ■        ■                  ■            ■");
            SetCursorPosition(13, 18);
            Console.WriteLine("■            ■                      ■■■■■■                  ■            ■");
            SetCursorPosition(13, 19);
            Console.WriteLine("■            ■                                                    ■            ■");
            SetCursorPosition(13, 20);
            Console.WriteLine("■            ■                                                    ■            ■");
            SetCursorPosition(13, 21);
            Console.WriteLine("■            ■                                                    ■            ■");
            SetCursorPosition(13, 22);
            Console.WriteLine("■            ■■■■■■■■■■■■■■■■■■■■■■■■■■■■            ■");
            SetCursorPosition(13, 23);
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
            Thread.Sleep(500);
            Clear();

        }
        public void PrintOpenBox()
        {

            BackgroundColor = ConsoleColor.Black;
            ForegroundColor = ConsoleColor.DarkYellow;

            SetCursorPosition(13, 5);
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
            
            SetCursorPosition(13, 6);
            Console.WriteLine("■                                                                                ■");
            SetCursorPosition(13, 7);
            Console.WriteLine("■                                              ■                                ■");
            SetCursorPosition(13, 8);
            Console.WriteLine("■                          ■■■■■■■■■■■                                ■");
            SetCursorPosition(13, 9);
            Console.WriteLine("■                          ■                  ■■■■■                        ■");
            SetCursorPosition(13, 10);
            Console.WriteLine("■                          ■■■■■■■■■■■                                ■");
            SetCursorPosition(13, 11);
            Console.WriteLine("■                                              ■                                ■");
            SetCursorPosition(13, 12);
            Console.WriteLine("■        ■                                                            ■        ■");
            SetCursorPosition(13, 13);
            Console.WriteLine("■          ■                                                        ■          ■");
            SetCursorPosition(13, 14);
            Console.WriteLine("■            ■                                                    ■            ■");
            SetCursorPosition(13, 15);
            Console.WriteLine("■              ■                                                ■              ■");
            SetCursorPosition(13, 16);
            Console.WriteLine("■            ■■■■■■■■■■■■■■■■■■■■■■■■■■■■            ■");
            SetCursorPosition(13, 17);
            Console.WriteLine("■            ■                                                    ■            ■");
            SetCursorPosition(13, 18);
            Console.WriteLine("■            ■                                                    ■            ■");
            SetCursorPosition(13, 19);
            Console.WriteLine("■            ■                                                    ■            ■");
            SetCursorPosition(13, 20);
            Console.WriteLine("■            ■                                                    ■            ■");
            SetCursorPosition(13, 21);
            Console.WriteLine("■            ■                                                    ■            ■");
            SetCursorPosition(13, 22);
            Console.WriteLine("■            ■■■■■■■■■■■■■■■■■■■■■■■■■■■■            ■");
            SetCursorPosition(13, 23);
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
            Thread.Sleep(500);
            Clear();

        }
    }
}
