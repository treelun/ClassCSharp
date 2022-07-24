using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mygame
{
    class LifeEntity:ILifeEntity

    {
        protected int attackDamage = 10;
        protected int _Hp = 100;

        public int Hp
        {
            get
            {
                return Hp;

            }
            protected set
            {
                Hp = value;
            }
        }

        public string name = "";

        public virtual void Init()
        {

        }

        public virtual void Attack(LifeEntity lifeEntity)
        {
            lifeEntity.Attack(lifeEntity);
            Console.WriteLine("");
                
        }

        public void hit(int hitpoint)
        {
            throw new NotImplementedException();
        }
    }
}
