using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mygame
{
    class MainCharacter : LifeEntity
    {

       

        public override void Init()
        {
            base.Init();
            name = "주인공";
            attackDamage = 10;
            Hp = 100;
        }


    }
}
