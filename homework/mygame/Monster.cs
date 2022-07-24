using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mygame
{
    class Monster : LifeEntity

    {

        public override void Init()
        {
            attackDamage = 3;
            Hp = 50;
            name = "몬스터";
        }
    

        
    }
}
