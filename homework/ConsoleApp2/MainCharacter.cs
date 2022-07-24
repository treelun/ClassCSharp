using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class MainCharacter : LifeEntity

    {
        public override void Init()
        {
            base.Init();
            name = "주인공";
            HP = 100;
            attackPoint = attackPoint;
            ammorPoint = 0;
        }
    }
}
