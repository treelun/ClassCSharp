using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;


namespace Rullet
{
    class Weapon_AdamanSword : abstractItem
    {
        public override void InitData()
        {
            WeaponName = "아다만티움소드";
            WeaponDamage = 40;
            WeaponLevel = 0;
            PrintWeapon();
            //PrintStat();
        }
        public void PrintWeapon()
        {
            BackgroundColor = ConsoleColor.White;
            ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(@"


               
                                             ***
                                            *****
                                            *****        
                                            *****
                                            ** **
                                            ** **      
                                            ** **
                                            ** ** 
                                            ** **
                                            ** ** 
                                          *********         
                                             ***  
                                             ***  
                                             ***  
                                            *****
");

        }
    }
}
