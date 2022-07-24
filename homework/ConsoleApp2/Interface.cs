using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    interface Interface
    {
        void Attack(LifeEntity lifeEntity);

        void Hit(int hitpoint);

        void Defense(LifeEntity lifeEntity);

        void Item(LifeEntity lifeEntity);

        void Potion(int healing);

        void Weapon(LifeEntity lifeEntity);

        void AttackPoint(int AttackPoint);

        void Ammor(LifeEntity lifeEntity);
        void AmmorPoint(int ammorPoint);
    }
}
