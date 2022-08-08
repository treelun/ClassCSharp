using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rullet
{
    class Glove : abstractItem
    {
        public override void InitData()
        {
            WeaponName = "권투글러브";
            WeaponDamage = 10;
            WeaponLevel = 0;

            //PrintStat();
        }

        public void Smith()
        {
            smith();

        }
    }
}
