using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rullet
{
    class BronzeDagger : abstractItem
    {
        public override void InitData()
        {
            WeaponName = "동단검";
            WeaponDamage = 15;
            WeaponLevel = 0;

            //PrintStat();
        }

        public void Smith()
        {
            smith();

        }
    }
}
