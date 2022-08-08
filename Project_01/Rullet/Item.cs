using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Rullet
{
    class Item
    {
        protected string WeaponName;
        protected uint WeaponDamage;
        protected uint WeaponLevel;
        protected int coin;

        public Item()
        {
            coin = 30000;
        }
        public string GetName()
        {
            return WeaponName;
        }

        public uint GetWeaponDamage()
        {
            return WeaponDamage;
        }
        public void PrintStat()
        {
            SetCursorPosition(40, 15);
            Console.WriteLine($"무기이름 : {WeaponName}");
            SetCursorPosition(40, 16);
            Console.WriteLine($"무기 공격력 : {WeaponDamage}, 강화레벨: {WeaponLevel}");
        }

        public void smith()
        {
            {
                Random ran = new Random();
                int WeaponLevelMax = 15;
                
                while (WeaponLevel != WeaponLevelMax)
                {
                    BackgroundColor = ConsoleColor.Black;
                    ForegroundColor = ConsoleColor.Cyan;
                    SetCursorPosition(40, 25);
                    Console.Write("강화를 진행 하시겠습니까? (Y/N)");
                    string Answer = Console.ReadLine();

                    if (Answer == "Y")
                    {
                        
                        for (uint i = WeaponLevel; i < WeaponLevelMax; i++)
                        {
                            int num = ran.Next(0, 9);
                            if (i > 0 && i <= 5 && coin > 0)
                            {
                                SetCursorPosition(86,15);
                                Console.WriteLine($"{WeaponName}이(가) {i}강 시도합니다.5강까지는 100프로 성공입니다");
                                SetCursorPosition(40, 25);
                                Console.Write("강화를 계속 진행하시겠습니까? (Y/N)");
                                Answer = Console.ReadLine();

                                if (Answer == "Y")
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
                                    SetCursorPosition(120, 13);
                                    Console.WriteLine($"강화에 성공했습니다!");
                                    SetCursorPosition(116, 16);
                                    Console.WriteLine($"강화레벨 : {WeaponLevel} 데미지 : {WeaponDamage}로 증가");
                                    SetCursorPosition(130, 0);
                                    Console.WriteLine($"잔여 코인{coin}");
                                    continue;
                                }
                                else if (Answer == "N")
                                {
                                    Console.Clear();
                                    SetCursorPosition(100, 27);
                                    Console.WriteLine("강화를 종료합니다.");

                                    SetCursorPosition(90, 28);
                                    Console.WriteLine($"최종 강화레벨 : {WeaponLevel} 최종 데미지 : {WeaponDamage}");
                                    break;
                                }
                                
                            }

                            else if (i > 5 && i <= 12 && num <= 7 && Answer == "Y" && coin > 0)
                            {
                                SetCursorPosition(86, 15);
                                Console.WriteLine($"{WeaponName}이(가) {i}강 시도합니다.성공 확률은 70프로 입니다");
                                SetCursorPosition(40, 25);
                                Console.Write("계속 진행하시겠습니까? (Y/N)");
                                Answer = Console.ReadLine();

                                if (Answer == "Y")
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
                                    SetCursorPosition(120, 13);
                                    Console.WriteLine($"강화에 성공했습니다!");
                                    SetCursorPosition(116, 16);
                                    Console.WriteLine($"강화레벨 : {WeaponLevel} 데미지 : {WeaponDamage}로 증가");
                                    SetCursorPosition(130, 0);
                                    Console.WriteLine($"잔여 코인{coin}");
                                    continue;
                                }
                                else if (Answer == "N")
                                {
                                    Console.Clear();
                                    SetCursorPosition(100, 27);
                                    Console.WriteLine("강화를 종료합니다.");

                                    SetCursorPosition(90, 28);
                                    Console.WriteLine($"최종 강화레벨 : {WeaponLevel} 최종 데미지 : {WeaponDamage}");
                                    break;
                                }

                            }
                            else if (i > 12 && num <= 2 && Answer == "Y" && coin > 0)
                            {
                                SetCursorPosition(86, 15);
                                Console.WriteLine($"{WeaponName}이(가) {i}강 시도합입니다.성공 확률은 30프로 입니다");
                                SetCursorPosition(40, 25);
                                Console.Write("계속 진행하시겠습니까? (Y/N)");
                                Answer = Console.ReadLine();

                                if (Answer == "Y")
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
                                    SetCursorPosition(120, 13);
                                    Console.WriteLine($"강화에 성공했습니다!");
                                    SetCursorPosition(116, 16);
                                    Console.WriteLine($"강화레벨 : {WeaponLevel} 데미지 : {WeaponDamage}로 증가");
                                    SetCursorPosition(130, 0);
                                    Console.WriteLine($"잔여 코인{coin}");
                                    continue;
                                }
                                else if (Answer == "N")
                                {
                                    Console.Clear();
                                    SetCursorPosition(100, 27);
                                    Console.WriteLine("강화를 종료합니다.");

                                    SetCursorPosition(90, 28);
                                    Console.WriteLine($"최종 강화레벨 : {WeaponLevel} 최종 데미지 : {WeaponDamage}");
                                    break;
                                }

                            }
                            else if (i > 5 && i <= 12 && num > 7 && coin > 0 && Answer == "Y")
                            {
                                SetCursorPosition(86, 15);
                                Console.WriteLine($"{WeaponName}이(가) {i}강 시도합니다.성공 확률은 70프로 입니다");
                                SetCursorPosition(40, 25);
                                Console.Write("계속 진행하시겠습니까? (Y/N)");
                                Answer = Console.ReadLine();

                                if (Answer == "Y")
                                {

                                    BackgroundColor = ConsoleColor.DarkRed;
                                    ForegroundColor = ConsoleColor.Black;
                                    Console.Clear();
                                    WeaponDamage -= 5;
                                    WeaponLevel--;
                                    coin -= 500;
                                    i--;
                                    i--;
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
                                    SetCursorPosition(120, 13);
                                    Console.WriteLine($"강화에 실패...했습니다!");
                                    SetCursorPosition(116, 16);
                                    Console.WriteLine($"강화레벨 : {WeaponLevel} 데미지 : {WeaponDamage}로 감소");
                                    SetCursorPosition(130, 0);
                                    Console.WriteLine($"잔여 코인{coin}");
                                    continue;
                                }
                                else if (Answer == "N")
                                {
                                    Console.Clear();
                                    SetCursorPosition(100, 27);
                                    Console.WriteLine("강화를 종료합니다.");

                                    SetCursorPosition(90, 28);
                                    Console.WriteLine($"최종 강화레벨 : {WeaponLevel} 최종 데미지 : {WeaponDamage}");
                                    break;
                                }


                            }
                            else if (i > 12 && num > 2 && coin > 0 && Answer == "Y")
                            {
                                SetCursorPosition(86, 15);
                                Console.WriteLine($"{WeaponName}이(가) {i}강 시도합니다.성공 확률은 30프로 입니다");
                                SetCursorPosition(40, 25);
                                Console.Write("계속 진행하시겠습니까? (Y/N)");
                                Answer = Console.ReadLine();

                                if (Answer == "Y")
                                {
                                    BackgroundColor = ConsoleColor.DarkRed;
                                    ForegroundColor = ConsoleColor.Black;
                                    
                                    Console.Clear();
                                    WeaponDamage -= 10;
                                    WeaponLevel--;
                                    coin -= 1000;
                                    i--;
                                    i--;
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

                                    SetCursorPosition(120, 13);
                                    Console.WriteLine($"강화에 실패...했습니다!");
                                    SetCursorPosition(116, 16);
                                    Console.WriteLine($"강화레벨 : {WeaponLevel} 데미지 : {WeaponDamage}로 감소");
                                    SetCursorPosition(130, 0);
                                    Console.WriteLine($"잔여 코인{coin}");
                                    continue;
                                }
                                else if (Answer == "N")
                                {
                                    Console.Clear();
                                    SetCursorPosition(100, 27);
                                    Console.WriteLine("강화를 종료합니다.");

                                    SetCursorPosition(90, 28);
                                    Console.WriteLine($"최종 강화레벨 : {WeaponLevel} 최종 데미지 : {WeaponDamage}");
                                    break;
                                }


                            }
                            else if (coin <= 0)
                            {
                                SetCursorPosition(110, 1);
                                Console.WriteLine("코인이 부족합니다.");
                                SetCursorPosition(100, 28);
                                Console.WriteLine("강화를 종료합니다.");
                                break;
                            }
                            else if (WeaponLevel == WeaponLevelMax)
                            {
                                SetCursorPosition(100, 27);
                                Console.WriteLine("강화가 완료되었습니다.");
                                SetCursorPosition(90, 28);
                                Console.WriteLine($"최종 강화레벨 : {WeaponLevel} 최종 데미지 : {WeaponDamage}");
                                break;
                            }
                        }
                    }



                    break;
                }
            }
        }
    }
}
