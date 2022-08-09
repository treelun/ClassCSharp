using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace Rullet
{
    class TitanumSword : abstractItem
    {
        public override void InitData()
        {
            WeaponName = "티타늄소드";
            WeaponDamage = 30;
            WeaponLevel = 0;

            //PrintStat();
        }

        public override void Smith(ref int coin)
        {
            {
                MainMenu main = new MainMenu();
                Random ran = new Random();
                int WeaponLevelMax = 15;
                int posY = 0;
                string first = "강화를 시도 합니다.";
                string Second = "강화를 하지 않습니다.";
                main.Menu(ref posY, ref first, ref Second);

                while (posY == 0)
                {
                    first = "강화 시도";
                    Second = "강화 끝내기";
                    BackgroundColor = ConsoleColor.Black;
                    ForegroundColor = ConsoleColor.Cyan;
                    main.Menu(ref posY, ref first, ref Second);
                    // SetCursorPosition(40, 25);
                    /*                    Console.Write("강화를 진행");
                                        string Answer = Console.ReadLine();*/

                    if (posY == 0)
                    {

                        for (uint i = WeaponLevel; i < WeaponLevelMax; i++)
                        {
                            int num = ran.Next(0, 9);
                            if (i > 0 && i <= 5 && coin > 0)
                            {
                                SetCursorPosition(40, 20);
                                Console.WriteLine($"{WeaponName}이(가) {i}강 시도합니다.5강까지는 100프로 성공입니다");
                                main.Menu(ref posY, ref first, ref Second);
                                /*                                SetCursorPosition(40, 25);
                                                                Console.Write("강화를 계속 진행하시겠습니까? (Y/N)");
                                                                Answer = Console.ReadLine();*/

                                if (posY == 0)
                                {
                                    BackgroundColor = ConsoleColor.Green;
                                    ForegroundColor = ConsoleColor.DarkRed;
                                    Console.Clear();

                                    WeaponDamage += 2;
                                    WeaponLevel++;
                                    coin -= 100;
                                    Console.WriteLine(@"
#############################################################################################################
                                                                                                            
                                                                                                            
    ###                                 
      ###                             
        ###                        
         ###                    
           ###                     
            ###                              ##              ###      
            ####                             ##            #####        
      ###########                            ##           ##  ##            
           #######                           ##               ##                            
            #######                  #################        ##                             
             #######                         ##               ##                                    
              #######                        ##               ##                                        
               #######                       ##               ##    
                #######                      ##               ##     
                 #######                                   ########  
                   ######
                     #####
                        ###
                                                            
##############################################################################################################
");
                                    BackgroundColor = ConsoleColor.Black;
                                    ForegroundColor = ConsoleColor.White;
                                    SetCursorPosition(40, 18);
                                    WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                                    SetCursorPosition(40, 19);
                                    WriteLine("@@@       강화에 성공했습니다!    @@@");
                                    SetCursorPosition(40, 20);
                                    WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                                    SetCursorPosition(40, 22);
                                    Console.WriteLine($"강화레벨 : {WeaponLevel} 데미지 : {WeaponDamage}로 증가");
                                    SetCursorPosition(130, 0);
                                    Console.WriteLine($"잔여 코인{coin}");
                                    Thread.Sleep(1000);
                                    Clear();
                                    continue;
                                }
                                else if (posY == 1)
                                {
                                    Console.Clear();
                                    SetCursorPosition(100, 27);
                                    Console.WriteLine("강화를 종료합니다.");

                                    SetCursorPosition(90, 28);
                                    Console.WriteLine($"최종 강화레벨 : {WeaponLevel} 최종 데미지 : {WeaponDamage}");
                                    Thread.Sleep(1000);
                                    SetCursorPosition(30, 22);
                                    Player player = new Player();
                                    break;
                                }

                            }

                            else if (i > 5 && i <= 12 && num <= 7 && posY == 0 && coin > 0)
                            {
                                SetCursorPosition(40, 20);
                                Console.WriteLine($"{WeaponName}이(가) {i}강 시도합니다.성공 확률은 70프로 입니다");
                                main.Menu(ref posY, ref first, ref Second);
                                /*                                SetCursorPosition(40, 25);
                                                                Console.Write("계속 진행하시겠습니까? (Y/N)");
                                                                Answer = Console.ReadLine();*/

                                if (posY == 0)
                                {
                                    BackgroundColor = ConsoleColor.Green;
                                    ForegroundColor = ConsoleColor.Black;
                                    Console.Clear();
                                    WeaponDamage += 5;
                                    WeaponLevel++;
                                    coin -= 500;
                                    Console.WriteLine(@"
#############################################################################################################
                                                                                                            
                                                                                                            
    ###                                 
      ###                             
        ###                        
         ###                    
           ###                     
            ###                              ##              ###      
            ####                             ##            #####        
      ###########                            ##           ##  ##            
           #######                           ##               ##                            
            #######                  #################        ##                             
             #######                         ##               ##                                    
              #######                        ##               ##                                        
               #######                       ##               ##    
                #######                      ##               ##     
                 #######                                   ########  
                   ######
                     #####
                        ###
                                                            
##############################################################################################################
");
                                    BackgroundColor = ConsoleColor.Black;
                                    ForegroundColor = ConsoleColor.White;
                                    SetCursorPosition(40, 18);
                                    WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                                    SetCursorPosition(40, 19);
                                    WriteLine("@@@       강화에 성공했습니다!    @@@");
                                    SetCursorPosition(40, 20);
                                    WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                                    SetCursorPosition(40, 22);
                                    Console.WriteLine($"강화레벨 : {WeaponLevel} 데미지 : {WeaponDamage}로 증가");
                                    SetCursorPosition(130, 0);
                                    Console.WriteLine($"잔여 코인{coin}");
                                    Thread.Sleep(1000);
                                    Clear();
                                    continue;
                                }
                                else if (posY == 1)
                                {
                                    Console.Clear();
                                    SetCursorPosition(100, 27);
                                    Console.WriteLine("강화를 종료합니다.");

                                    SetCursorPosition(90, 28);
                                    Console.WriteLine($"최종 강화레벨 : {WeaponLevel} 최종 데미지 : {WeaponDamage}");
                                    break;
                                }

                            }
                            else if (i > 12 && num <= 2 && posY == 0 && coin > 0)
                            {
                                SetCursorPosition(40, 20);
                                Console.WriteLine($"{WeaponName}이(가) {i}강 시도합입니다.성공 확률은 30프로 입니다");
                                main.Menu(ref posY, ref first, ref Second);
                                /*                                SetCursorPosition(40, 25);
                                                                Console.Write("계속 진행하시겠습니까? (Y/N)");
                                                                Answer = Console.ReadLine();*/

                                if (posY == 0)
                                {
                                    BackgroundColor = ConsoleColor.Green;
                                    ForegroundColor = ConsoleColor.Black;
                                    Console.Clear();
                                    WeaponDamage += 10;
                                    WeaponLevel++;
                                    coin -= 1000;

                                    Console.WriteLine(@"
#############################################################################################################
                                                                                                            
                                                                                                            
    ###                                                                                                     
      ###                                                                                                   
        ###                                                                                                 
         ###                                                                                                
           ###                                                                                              
            ###                              ##              ###                                            
            ####                             ##            #####                                            
      ###########                            ##           ##  ##                                            
           #######                           ##               ##                                            
            #######                  #################        ##                                            
             #######                         ##               ##                                            
              #######                        ##               ##                                            
                ######                       ##               ##                                            
                 ######                      ##               ##                                            
                  ######                                   ########                                         
                   ######                                                                                   
                     #####                                                                                   
                        ###                                                                                  
                                                                                                            
##############################################################################################################
");
                                    BackgroundColor = ConsoleColor.Black;
                                    ForegroundColor = ConsoleColor.White;
                                    SetCursorPosition(40, 18);
                                    WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                                    SetCursorPosition(40, 19);
                                    WriteLine("@@@       강화에 성공했습니다!    @@@");
                                    SetCursorPosition(40, 20);
                                    WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                                    SetCursorPosition(40, 22);
                                    Console.WriteLine($"강화레벨 : {WeaponLevel} 데미지 : {WeaponDamage}로 증가");
                                    SetCursorPosition(130, 0);
                                    Console.WriteLine($"잔여 코인{coin}");
                                    Thread.Sleep(1000);
                                    Clear();
                                    continue;
                                }
                                else if (posY == 1)
                                {
                                    Console.Clear();
                                    SetCursorPosition(100, 27);
                                    Console.WriteLine("강화를 종료합니다.");

                                    SetCursorPosition(90, 28);
                                    Console.WriteLine($"최종 강화레벨 : {WeaponLevel} 최종 데미지 : {WeaponDamage}");
                                    break;
                                }

                            }
                            else if (i == 6 && coin > 0 && posY == 0 && num > 6)
                            {
                                SetCursorPosition(40, 20);
                                Console.WriteLine($"{WeaponName}이(가) {i}강 시도합니다.성공 확률은 70프로 입니다");
                                main.Menu(ref posY, ref first, ref Second);
                                /*                                SetCursorPosition(40, 25);
                                                                Console.Write("계속 진행하시겠습니까? (Y/N)");
                                                                Answer = Console.ReadLine();*/

                                if (posY == 0)
                                {

                                    BackgroundColor = ConsoleColor.DarkRed;
                                    ForegroundColor = ConsoleColor.Black;
                                    Console.Clear();
                                    WeaponDamage -= 2;
                                    WeaponLevel--;
                                    coin -= 500;
                                    i -= 2;

                                    Console.WriteLine(@"
#############################################################################################################
                                                                                                            
                                                                                                            
    ###                                                                                                     
      ###                                                                                                   
        ###                                                                                                 
         ###                                                                                                
           ###                                                                                              
            ###                                              ###                                            
            ####                                           #####                                            
      ###########                                         ##  ##                                            
           #######                                            ##                                            
            #######                  #################        ##                                            
             #######                                          ##                                            
              #######                                         ##                                            
                                                              ##                                            
                                                              ##                                            
               #######                                     ########                                         
              ######                                                                                        
             #####                                                                                          
            ###                                                                                             
                                                                                                            
##############################################################################################################
");
                                    BackgroundColor = ConsoleColor.Black;
                                    ForegroundColor = ConsoleColor.White;
                                    SetCursorPosition(40, 18);
                                    WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                                    SetCursorPosition(40, 19);
                                    WriteLine("@@@     강화에 실패...했습니다!   @@@");
                                    SetCursorPosition(40, 20);
                                    WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");

                                    SetCursorPosition(40, 22);
                                    Console.WriteLine($"강화레벨 : {WeaponLevel} 데미지 : {WeaponDamage}로 감소");
                                    SetCursorPosition(130, 0);
                                    Console.WriteLine($"잔여 코인{coin}");
                                    Thread.Sleep(1000);
                                    Clear();
                                    continue;
                                }
                                else if (posY == 1)
                                {
                                    Console.Clear();
                                    SetCursorPosition(100, 27);
                                    Console.WriteLine("강화를 종료합니다.");

                                    SetCursorPosition(90, 28);
                                    Console.WriteLine($"최종 강화레벨 : {WeaponLevel} 최종 데미지 : {WeaponDamage}");
                                    break;
                                }


                            }
                            else if (i > 5 && i <= 12 && num > 6 && coin > 0 && posY == 0)
                            {
                                SetCursorPosition(40, 20);
                                Console.WriteLine($"{WeaponName}이(가) {i}강 시도합니다.성공 확률은 70프로 입니다");
                                main.Menu(ref posY, ref first, ref Second);
                                /*                                SetCursorPosition(40, 25);
                                                                Console.Write("계속 진행하시겠습니까? (Y/N)");
                                                                Answer = Console.ReadLine();*/

                                if (posY == 0)
                                {

                                    BackgroundColor = ConsoleColor.DarkRed;
                                    ForegroundColor = ConsoleColor.Black;
                                    Console.Clear();
                                    WeaponDamage -= 5;
                                    WeaponLevel--;
                                    coin -= 500;
                                    i -= 2;
                                    Console.WriteLine(@"
#############################################################################################################
                                                                                                            
                                                                                                            
    ###                                                                                                     
      ###                                                                                                   
        ###                                                                                                 
         ###                                                                                                
           ###                                                                                              
            ###                                              ###                                            
            ####                                           #####                                            
      ###########                                         ##  ##                                            
           #######                                            ##                                            
            #######                  #################        ##                                            
             #######                                          ##                                            
              #######                                         ##                                            
                                                              ##                                            
                                                              ##                                            
               #######                                     ########                                         
              ######                                                                                        
             #####                                                                                          
            ###                                                                                             
                                                                                                            
##############################################################################################################
");
                                    BackgroundColor = ConsoleColor.Black;
                                    ForegroundColor = ConsoleColor.White;
                                    SetCursorPosition(40, 18);
                                    WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                                    SetCursorPosition(40, 19);
                                    WriteLine("@@@     강화에 실패...했습니다!   @@@");
                                    SetCursorPosition(40, 20);
                                    WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");

                                    SetCursorPosition(40, 22);
                                    Console.WriteLine($"강화레벨 : {WeaponLevel} 데미지 : {WeaponDamage}로 감소");
                                    SetCursorPosition(130, 0);
                                    Console.WriteLine($"잔여 코인{coin}");
                                    Thread.Sleep(1000);
                                    Clear();
                                    continue;
                                }
                                else if (posY == 1)
                                {
                                    Console.Clear();
                                    SetCursorPosition(100, 27);
                                    Console.WriteLine("강화를 종료합니다.");

                                    SetCursorPosition(90, 28);
                                    Console.WriteLine($"최종 강화레벨 : {WeaponLevel} 최종 데미지 : {WeaponDamage}");
                                    break;
                                }


                            }
                            else if (i > 12 && num > 2 && coin > 0 && posY == 0)
                            {
                                SetCursorPosition(40, 20);
                                Console.WriteLine($"{WeaponName}이(가) {i}강 시도합니다.성공 확률은 30프로 입니다");
                                main.Menu(ref posY, ref first, ref Second);
                                /*                                SetCursorPosition(40, 25);
                                                                Console.Write("계속 진행하시겠습니까? (Y/N)");
                                                                Answer = Console.ReadLine();*/

                                if (posY == 0)
                                {
                                    BackgroundColor = ConsoleColor.DarkRed;
                                    ForegroundColor = ConsoleColor.Black;

                                    Console.Clear();
                                    WeaponDamage -= 10;
                                    WeaponLevel--;
                                    coin -= 1000;
                                    i -= 2;
                                    Console.WriteLine(@"
#############################################################################################################
                                                                                                            
                                                                                                            
    ###                                 
      ###                             
        ###                        
         ###                    
           ###                     
            ###                                              ###      
            ####                                           #####        
      ###########                                         ##  ##            
           #######                                            ##                            
            #######                  #################        ##                             
             #######                                          ##                                    
              #######                                         ##                                        
                                                              ##    
                                                              ##     
               #######                                     ########  
              ######
             #####
            ###
                                                            
##############################################################################################################
");
                                    BackgroundColor = ConsoleColor.Black;
                                    ForegroundColor = ConsoleColor.White;
                                    SetCursorPosition(40, 18);
                                    WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                                    SetCursorPosition(40, 19);
                                    WriteLine("@@@     강화에 실패...했습니다!   @@@");
                                    SetCursorPosition(40, 20);
                                    WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");

                                    SetCursorPosition(40, 22);
                                    Console.WriteLine($"강화레벨 : {WeaponLevel} 데미지 : {WeaponDamage}로 감소");
                                    SetCursorPosition(130, 0);
                                    Console.WriteLine($"잔여 코인{coin}");
                                    Thread.Sleep(1000);
                                    Clear();
                                    continue;
                                }
                                else if (posY == 1)
                                {
                                    Console.Clear();
                                    SetCursorPosition(100, 27);
                                    Console.WriteLine("강화를 종료합니다.");

                                    SetCursorPosition(90, 28);
                                    Console.WriteLine($"최종 강화레벨 : {WeaponLevel} 최종 데미지 : {WeaponDamage}");
                                    break;
                                }


                            }
                            else if (coin <= 0 && posY == 0)
                            {
                                Clear();
                                SetCursorPosition(40, 20);
                                Console.WriteLine("코인이 부족합니다.");
                                SetCursorPosition(40, 22);
                                Console.WriteLine("강화를 종료합니다.");
                                break;
                            }
                            else if (WeaponLevel == WeaponLevelMax && posY == 0)
                            {
                                Clear();
                                SetCursorPosition(100, 27);
                                Console.WriteLine("강화가 완료되었습니다.");
                                SetCursorPosition(90, 28);
                                Console.WriteLine($"최종 강화레벨 : {WeaponLevel} 최종 데미지 : {WeaponDamage}");
                                break;
                            }
                        }
                    }




                }
            }

        }
    }
}
