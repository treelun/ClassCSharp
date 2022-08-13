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
            bool start = false;
            string a1 = "뽑는다.";
            string a2 = "상점을 나간다.";

            while (coin > 0)
            {
                SetCursorPosition(10, 5);
                WriteLine("어서오세요 뽑기상점입니다.");
                SetCursorPosition(10, 6);
                WriteLine("상점직원 : 저희는 무기가 랜덤으로 나온답니다. 운이좋다면 한번에 좋은무기도 가져가실수있어요");
                Thread.Sleep(500);
                SetCursorPosition(10, 7);
                WriteLine("상점직원 : 뽑기 1회당 500코인이 소비됩니다.");

                Thread.Sleep(500);
                Console.Clear();


                BackgroundColor = ConsoleColor.Black;
                ForegroundColor = ConsoleColor.Red;
                

                if (posY == 0 && coin > 0)
                {
                    PrintBox();
                    PrintOpenBox();
                    Thread.Sleep(500);
                    Console.Clear();
                    //RandomNum = random.Next(0, 1000);
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
