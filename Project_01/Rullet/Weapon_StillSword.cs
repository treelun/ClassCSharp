﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace Rullet
{
    class Weapon_StillSword : abstractItem
    {
        public override void InitData()
        {
            WeaponName = "강철소드";
            WeaponDamage = 20;
            WeaponLevel = 0;

            //PrintStat();
        }

        public void Smith(ref int coin)
        {

        }
    }
}