using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mygame
{
    class Zombie : Monster
    {
    

        public override void Init()
        {
            base.Init();
            name = "Zombie";
            attackDamage = 5;
        }

    }
}
