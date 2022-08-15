using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace Rullet
{
    class Weapon_StoneSword : abstractItem
    {
        public override void InitData()
        {
            WeaponName = "돌검";
            WeaponDamage = 20;
            WeaponLevel = 0;
            PrintWeapon();
            //PrintStat();
        }

        public void PrintWeapon()
        {
            BackgroundColor = ConsoleColor.Black;
            ForegroundColor = ConsoleColor.DarkGray;

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
