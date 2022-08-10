using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;


namespace Rullet
{
    class Item
    {
        public string WeaponName;
        public uint WeaponDamage;
        public uint WeaponLevel;
        

        public Item()
        {

            
            WeaponDamage = 0;
            WeaponLevel = 0;
        }
        public string GetName()
        {
            return WeaponName;
        }

        public uint GetWeaponDamage()
        {
            return WeaponDamage;
        }
        public uint GetWeaponLevel()
        {
            return WeaponLevel;
        }
        public void PrintStat()
        {
            SetCursorPosition(60, 22);
            Console.WriteLine($"무기이름 : {WeaponName}");
            SetCursorPosition(60, 23);
            Console.WriteLine($"무기 공격력 : {WeaponDamage}, 강화레벨: {WeaponLevel}");
        }
        public void Faildindex(ref int posY, ref int coin, uint Value, int per, int a)
        {
            if (posY == 0)
            {
                SetCursorPosition(40, 20);
                Console.WriteLine($"{WeaponName}이(가) {WeaponLevel}강 시도합니다.5강까지는 성공 확률은 {per}% 입니다");
                BackgroundColor = ConsoleColor.DarkRed;
                ForegroundColor = ConsoleColor.Black;
                Console.Clear();
                WeaponDamage -= Value;
                WeaponLevel--;
                
                coin -= a;

                BackgroundColor = ConsoleColor.Black;
                ForegroundColor = ConsoleColor.White;
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
               #######                                        ##                                             
                #######                                       ##                                             
                 #######                                   ########                                          
                   ######                                                                                    
                     #####                                                                                   
                        ###                                                                                  
                                                                                                             
#############################################################################################################");
                BackgroundColor = ConsoleColor.Black;
                ForegroundColor = ConsoleColor.White;
                SetCursorPosition(55, 5);
                WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                SetCursorPosition(55, 6);
                WriteLine("@@@     강화에 실패...했습니다!   @@@");
                SetCursorPosition(55, 7);
                WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");

                SetCursorPosition(70, 10);
                Console.WriteLine($"강화레벨 : {WeaponLevel} 데미지 : {WeaponDamage}로 감소");
                SetCursorPosition(95, 0);
                Console.WriteLine($"잔여 코인{coin}");
                Thread.Sleep(1000);
                Clear();

            }



        }
        public void Completeindex(ref int posY, ref int coin, uint Value, int per, int a)
        {
            
            if (posY == 0)
            {
                SetCursorPosition(40, 20);
                Console.WriteLine($"{WeaponName}이(가) {WeaponLevel}강 시도합니다.5강까지는 성공 확률은 {per}% 입니다");
                BackgroundColor = ConsoleColor.Green;
                ForegroundColor = ConsoleColor.DarkRed;
                Console.Clear();

                WeaponDamage += Value;
                WeaponLevel++;
                coin -= a;
                BackgroundColor = ConsoleColor.Black;
                ForegroundColor = ConsoleColor.White;
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
                                                                                                             
#############################################################################################################");
                BackgroundColor = ConsoleColor.Black;
                ForegroundColor = ConsoleColor.White;
                SetCursorPosition(55, 5);
                WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                SetCursorPosition(55, 6);
                WriteLine("@@@       강화에 성공했습니다!    @@@");
                SetCursorPosition(55, 7);
                WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                SetCursorPosition(70, 10);
                Console.WriteLine($"강화레벨 : {WeaponLevel} 데미지 : {WeaponDamage}로 증가");
                SetCursorPosition(95, 0);
                Console.WriteLine($"잔여 코인{coin}");
                Thread.Sleep(1000);
                Clear();

            }


        }



    }
}
