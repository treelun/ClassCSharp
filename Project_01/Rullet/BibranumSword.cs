using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;


namespace Rullet
{
    class BibranumSword : abstractItem
    {
        public override void InitData()
        {
            WeaponName = "비뷰라늄소드";
            WeaponDamage = 50;
            WeaponLevel = 0;

            //PrintStat();
        }

        public void Smith(ref int coin)
        {

        }
    }
}
