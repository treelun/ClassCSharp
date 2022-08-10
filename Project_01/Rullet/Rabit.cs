using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rullet
{
    class Rabit : AbstractMonster
    {
        public override void InitData()
        {
            Hp = 100;


            Attack_Power = 2;

            Name = "토 끼";

            MonsterLevel = "F";

            //PrintStat();
        }
    }


}
