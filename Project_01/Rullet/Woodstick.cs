using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace Rullet
{
    class Woodstick : abstractItem
    {

        public override void InitData()
        {
            WeaponName = "나무막대기";
            WeaponDamage = 5;
            WeaponLevel = 0;

            //PrintStat();
        }

        public void Smith(ref int coin)
        {

        }

    }
}

