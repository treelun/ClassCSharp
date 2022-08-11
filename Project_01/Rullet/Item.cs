﻿using System;
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
            BackgroundColor = ConsoleColor.Black;
            ForegroundColor = ConsoleColor.DarkRed;
            SetCursorPosition(60, 22);
            Console.WriteLine($"무기이름 : {WeaponName}");
            SetCursorPosition(60, 23);
            Console.WriteLine($"무기 공격력 : {WeaponDamage}, 강화레벨: {WeaponLevel}");
        }
        public void Faildindex(ref int posY, ref int coin, uint Value, int per, int a)
        {
            if (posY == 0)
            {
                Console.Clear();
                SetCursorPosition(20, 10);
                Console.WriteLine($"{WeaponName}이(가) {WeaponLevel}강 시도합니다.5강까지는 성공 확률은 {per}% 입니다");
                Thread.Sleep(1000);
                Console.Clear();
                DrawMotion();

                
                WeaponDamage -= Value;
                WeaponLevel--;
                
                coin -= a;


                DrawFailLevel();

                Thread.Sleep(800);
                BackgroundColor = ConsoleColor.Black;
                ForegroundColor = ConsoleColor.White;
                Console.Clear();

                SetCursorPosition(32, 5);
                WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                SetCursorPosition(32, 6);
                WriteLine("@@@     강화에 실패...했습니다!   @@@");
                SetCursorPosition(32, 7);
                WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");

                SetCursorPosition(32, 13);
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
                Console.Clear();
                SetCursorPosition(20, 10);
                Console.WriteLine($"{WeaponName}이(가) {WeaponLevel}강 시도합니다.5강까지는 성공 확률은 {per}% 입니다");
                Thread.Sleep(1000);
                Clear();
                DrawMotion();
                DrawCompliteLevel();

                WeaponDamage += Value;
                WeaponLevel++;
                coin -= a;
                



                Thread.Sleep(800);
                BackgroundColor = ConsoleColor.Black;
                ForegroundColor = ConsoleColor.White;
                Console.Clear();

                
                SetCursorPosition(32, 5);
                WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                SetCursorPosition(32, 6);
                WriteLine("@@@       강화에 성공했습니다!    @@@");
                SetCursorPosition(32, 7);
                WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                SetCursorPosition(32, 13);
                Console.WriteLine($"강화레벨 : {WeaponLevel} 데미지 : {WeaponDamage}로 증가");
                SetCursorPosition(95, 0);
                Console.WriteLine($"잔여 코인{coin}");

                Thread.Sleep(1000);
                Clear();

            }


        }
        public void DrawCompliteLevel()
        {

            BackgroundColor = ConsoleColor.DarkGreen;
            ForegroundColor = ConsoleColor.White;
            SetCursorPosition(1, 5);
            Console.WriteLine("############################################################################################################");
            SetCursorPosition(1, 6);
            Console.WriteLine("#                                                                                                          #");
            SetCursorPosition(1, 7);
            Console.WriteLine("#                 ###                                                                                      #");
            SetCursorPosition(1, 8);
            Console.WriteLine("#                  ###                                                                                     #");
            SetCursorPosition(1, 9);
            Console.WriteLine("#                   ###                                                                                    #");
            SetCursorPosition(1, 10);
            Console.WriteLine("#                    ###                                  ##              ###                              #");
            SetCursorPosition(1, 11);
            Console.WriteLine("#                    ####                                 ##            #####                              #");
            SetCursorPosition(1, 12);
            Console.WriteLine("#              ###########                                ##           ##  ##                              #");
            SetCursorPosition(1, 13);
            Console.WriteLine("#                   #######                               ##               ##                              #");
            SetCursorPosition(1, 14);
            Console.WriteLine("#                    #######                      #################        ##                              #");
            SetCursorPosition(1, 15);
            Console.WriteLine("#                      #######                            ##               ##                              #");
            SetCursorPosition(1, 16);
            Console.WriteLine("#                       #######                           ##               ##                              #");
            SetCursorPosition(1, 17);
            Console.WriteLine("#                        #######                          ##               ##                              #");
            SetCursorPosition(1, 18);
            Console.WriteLine("#                          #######                        ##               ##                              #");
            SetCursorPosition(1, 19);
            Console.WriteLine("#                            ######                                                                        #");
            SetCursorPosition(1, 20);
            Console.WriteLine("#                             ######                                                                       #");
            SetCursorPosition(1, 21);
            Console.WriteLine("#                              ######                                                                      #");
            SetCursorPosition(1, 22);
            Console.WriteLine("#                                                                                                          #");
            SetCursorPosition(1, 23);
            Console.WriteLine("############################################################################################################");


        }
        public void DrawFailLevel()
        {

            BackgroundColor = ConsoleColor.DarkRed;
            ForegroundColor = ConsoleColor.White;
            SetCursorPosition(1, 5);
            Console.WriteLine("############################################################################################################");
            SetCursorPosition(1, 6);
            Console.WriteLine("#                                                                                                          #");
            SetCursorPosition(1, 7);
            Console.WriteLine("#                 ###                                                                                      #");
            SetCursorPosition(1, 8);
            Console.WriteLine("#                  ###                                                                                     #");
            SetCursorPosition(1, 9);
            Console.WriteLine("#                   ###                                                                                    #");
            SetCursorPosition(1, 10);
            Console.WriteLine("#                    ###                                                  ###                              #");
            SetCursorPosition(1, 11);
            Console.WriteLine("#                    ####                                               #####                              #");
            SetCursorPosition(1, 12);
            Console.WriteLine("#              ###########                                             ##  ##                              #");
            SetCursorPosition(1, 13);
            Console.WriteLine("#                   #######                                                ##                              #");
            SetCursorPosition(1, 14);
            Console.WriteLine("#                    #######                      #################        ##                              #");
            SetCursorPosition(1, 15);
            Console.WriteLine("#                      #######                                             ##                              #");
            SetCursorPosition(1, 16);
            Console.WriteLine("#                       #######                                            ##                              #");
            SetCursorPosition(1, 17);
            Console.WriteLine("#                        #######                                           ##                              #");
            SetCursorPosition(1, 18);
            Console.WriteLine("#                          #######                                         ##                              #");
            SetCursorPosition(1, 19);
            Console.WriteLine("#                            ######                                                                        #");
            SetCursorPosition(1, 20);
            Console.WriteLine("#                             ######                                                                       #");
            SetCursorPosition(1, 21);
            Console.WriteLine("#                              ######                                                                      #");
            SetCursorPosition(1, 22);
            Console.WriteLine("#                                                                                                          #");
            SetCursorPosition(1, 23);
            Console.WriteLine("############################################################################################################");


        }
        public void DrawMotion()
        {

            SetCursorPosition(1, 3);
            Console.WriteLine("############################################################################################################");
            SetCursorPosition(1, 4);
            Console.WriteLine("#                                                                                                          #");
            SetCursorPosition(1, 5);
            Console.WriteLine("#                                                                                                          #");
            SetCursorPosition(1, 6);
            Console.WriteLine("#                                                                                                          #");
            SetCursorPosition(1, 7);
            Console.WriteLine("#                                                                                                          #");
            SetCursorPosition(1, 8);
            Console.WriteLine("#                                                                    ##################                    #");
            SetCursorPosition(1, 9);
            Console.WriteLine("#                                                                    ##################                    #");
            SetCursorPosition(1, 10);
            Console.WriteLine("#                                                                    ##################                    #");
            SetCursorPosition(1, 11);
            Console.WriteLine("#                                                                    ##################                    #");
            SetCursorPosition(1, 12);
            Console.WriteLine("#                                                                           ####                           #");
            SetCursorPosition(1, 13);
            Console.WriteLine("#                                                                           ####                           #");
            SetCursorPosition(1, 14);
            Console.WriteLine("#                                                                           ####                           #");
            SetCursorPosition(1, 15);
            Console.WriteLine("#                                                                           ####                           #");
            SetCursorPosition(1, 16);
            Console.WriteLine("#                                                                           ####                           #");
            SetCursorPosition(1, 17);
            Console.WriteLine("#                                                                           ####                           #");
            SetCursorPosition(1, 18);
            Console.WriteLine("#                                                                           ####                           #");
            SetCursorPosition(1, 19);
            Console.WriteLine("#                                                                                                          #");
            SetCursorPosition(1, 20);
            Console.WriteLine("#                                      ###############                                                     #");
            SetCursorPosition(1, 21);
            Console.WriteLine("#                                    ###################                                                   #");
            SetCursorPosition(1, 22);
            Console.WriteLine("#                                    ###################                                                   #");
            SetCursorPosition(1, 23);
            Console.WriteLine("#                ##################################################                                        #");
            SetCursorPosition(1, 24);
            Console.WriteLine("#                ##################################################                                        #");
            SetCursorPosition(1, 25);
            Console.WriteLine("#                                                                                                          #");
            SetCursorPosition(1, 26);
            Console.WriteLine("############################################################################################################");
            Thread.Sleep(500);
            Clear();

            SetCursorPosition(1, 3);
            Console.WriteLine("############################################################################################################");
            SetCursorPosition(1, 4);
            Console.WriteLine("#                                                                                                          #");
            SetCursorPosition(1, 5);
            Console.WriteLine("#                                                                                                          #");
            SetCursorPosition(1, 6);
            Console.WriteLine("#                                                                                                          #");
            SetCursorPosition(1,7);
            Console.WriteLine("#                                                                                                          #");
            SetCursorPosition(1, 8);
            Console.WriteLine("#                                                                                                          #");
            SetCursorPosition(1, 9);
            Console.WriteLine("#                                                                                                          #");
            SetCursorPosition(1, 10);
            Console.WriteLine("#                                                                                                          #");
            SetCursorPosition(1, 11);
            Console.WriteLine("#                                                                                                          #");
            SetCursorPosition(1, 12);
            Console.WriteLine("#                                                                                                          #");
            SetCursorPosition(1, 13);
            Console.WriteLine("#                                                                                                          #");
            SetCursorPosition(1, 14);
            Console.WriteLine("#                                                                                                          #");
            SetCursorPosition(1, 15);
            Console.WriteLine("#                                        ###########                                                       #");
            SetCursorPosition(1, 16);
            Console.WriteLine("#                                        ###########                                                       #");
            SetCursorPosition(1, 17);
            Console.WriteLine("#                                        #######################################                           #");
            SetCursorPosition(1, 18);
            Console.WriteLine("#                                        #######################################                           #");
            SetCursorPosition(1, 19);
            Console.WriteLine("#                                        ###########                                                       #");
            SetCursorPosition(1, 20);
            Console.WriteLine("#                                    ### ########### ###                                                   #");
            SetCursorPosition(1, 21);
            Console.WriteLine("#                                    ###################                                                   #");
            SetCursorPosition(1, 22);
            Console.WriteLine("#                                    ###################                                                   #");
            SetCursorPosition(1, 23);
            Console.WriteLine("#                ##################################################                                        #");
            SetCursorPosition(1, 24);
            Console.WriteLine("#                ##################################################                                        #");
            SetCursorPosition(1, 25);
            Console.WriteLine("#                                                                                                          #");
            SetCursorPosition(1, 26);
            Console.WriteLine("############################################################################################################");
            Thread.Sleep(500);
            Clear();
            


            SetCursorPosition(1, 3);
            Console.WriteLine("############################################################################################################");
            SetCursorPosition(1, 4);
            Console.WriteLine("#                                                                                                          #");
            SetCursorPosition(1, 5);
            Console.WriteLine("#                                                                                                          #");
            SetCursorPosition(1, 6);
            Console.WriteLine("#                                                                                                          #");
            SetCursorPosition(1, 7);
            Console.WriteLine("#                                                                                                          #");
            SetCursorPosition(1, 8);
            Console.WriteLine("#                                                                    ##################                    #");
            SetCursorPosition(1, 9);
            Console.WriteLine("#                                                                    ##################                    #");
            SetCursorPosition(1, 10);
            Console.WriteLine("#                                                                    ##################                    #");
            SetCursorPosition(1, 11);
            Console.WriteLine("#                                                                    ##################                    #");
            SetCursorPosition(1, 12);
            Console.WriteLine("#                                                                           ####                           #");
            SetCursorPosition(1, 13);
            Console.WriteLine("#                                                                           ####                           #");
            SetCursorPosition(1, 14);
            Console.WriteLine("#                                                                           ####                           #");
            SetCursorPosition(1, 15);
            Console.WriteLine("#                                                                           ####                           #");
            SetCursorPosition(1, 16);
            Console.WriteLine("#                                                                           ####                           #");
            SetCursorPosition(1, 17);
            Console.WriteLine("#                                                                           ####                           #");
            SetCursorPosition(1, 18);
            Console.WriteLine("#                                                                           ####                           #");
            SetCursorPosition(1, 19);
            Console.WriteLine("#                                                                                                          #");
            SetCursorPosition(1, 20);
            Console.WriteLine("#                                    ###             ###                                                   #");
            SetCursorPosition(1, 21);
            Console.WriteLine("#                                    ###################                                                   #");
            SetCursorPosition(1, 22);
            Console.WriteLine("#                                    ###################                                                   #");
            SetCursorPosition(1, 23);
            Console.WriteLine("#                ##################################################                                        #");
            SetCursorPosition(1, 24);
            Console.WriteLine("#                ##################################################                                        #");
            SetCursorPosition(1, 25);
            Console.WriteLine("#                                                                                                          #");
            SetCursorPosition(1, 26);
            Console.WriteLine("############################################################################################################");
            Thread.Sleep(500);
            Clear();

        }
    }


    
}
