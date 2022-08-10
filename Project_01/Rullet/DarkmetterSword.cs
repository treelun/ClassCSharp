using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace Rullet
{
    class DarkmetterSword : abstractItem

    {
        public override void InitData()
        {
            WeaponName = "다크메터소드";
            WeaponDamage = 100;
            WeaponLevel = 0;

            //PrintStat();
        }

        public void Smith(ref int coin)
        {

        }
    }
}
