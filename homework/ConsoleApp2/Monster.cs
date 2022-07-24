using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Monster : LifeEntity
    {
        public override void Init()
        {
            base.Init();
            name = "몬스터";
            HP = 40;
            attackPoint = 3 - ammorPoint;
        }
    }
}
