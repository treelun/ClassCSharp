using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mygame
{
    class LifeEntity : ILifeEntity

    {
        protected int attackDamage;
        protected int Hp;



        public string name = "";

        public virtual void Init()
        {

        }

        public virtual void Attack(LifeEntity lifeEntity)
        {

            Console.WriteLine(name + "은" + lifeEntity.name + "을(를) 공격했다");

            lifeEntity.hit(attackDamage);


        }

        public void hit(int hitpoint)
        {

            Hp -= hitpoint;

            Console.WriteLine(name + "은(는) 공격받았다.");
            Console.WriteLine(name + "은" + Hp + "의 Hp가 남았다.");
        }

        public virtual void defence(LifeEntity lifeEntity)
        {
            Console.WriteLine(name + "은" + lifeEntity.name + "의 공격을 막아냈다.");

        }


    }
}
