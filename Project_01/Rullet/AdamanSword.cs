﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;


namespace Rullet
{
    class AdamanSword : abstractItem
    {
        public override void InitData()
        {
            WeaponName = "아다만티움소드";
            WeaponDamage = 40;
            WeaponLevel = 0;

            //PrintStat();
        }

        public void Smith(ref int coin)
        {

        }
    }
}
