using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;


namespace Rullet
{
    class Weapon_BronzeDagger : abstractItem
    {
        public override void InitData()
        {
            WeaponName = "동단검";
            WeaponDamage = 15;
            WeaponLevel = 0;

            //PrintStat();
        }


    }
}
