﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace Rullet
{
    class Weapon_TitanumSword : abstractItem
    {
        public override void InitData()
        {
            WeaponName = "티타늄소드";
            WeaponDamage = 30;
            WeaponLevel = 0;

            //PrintStat();
        }

        public void Smith(ref int coin)
        {

        }
    }
}