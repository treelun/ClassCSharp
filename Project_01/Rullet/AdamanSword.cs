using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void Smith()
        {
            smith();

        }
    }
}
