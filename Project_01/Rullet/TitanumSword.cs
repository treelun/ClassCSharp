using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rullet
{
    class TitanumSword : abstractItem
    {
        public override void InitData()
        {
            WeaponName = "티타늄소드";
            WeaponDamage = 30;
            WeaponLevel = 0;

            //PrintStat();
        }

        public void Smith()
        {
            smith();
            
        }
    }
}
