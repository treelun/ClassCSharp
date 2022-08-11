using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace Rullet
{
    class Weapon_Glove : abstractItem
    {
        public override void InitData()
        {
            WeaponName = "권투글러브";
            WeaponDamage = 10;
            WeaponLevel = 0;

            //PrintStat();
        }

        public void Smith(ref int coin)
        {

        }
        
        
    }
}
