using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rullet
{
    class StillSword : abstractItem
    {
        public override void InitData()
        {
            WeaponName = "강철소드";
            WeaponDamage = 20;
            WeaponLevel = 0;

            //PrintStat();
        }

        public void Smith()
        {
            smith();

        }
    }
}
