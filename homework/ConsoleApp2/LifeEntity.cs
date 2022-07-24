using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class LifeEntity : Interface
    {
        protected int attackPoint;
        protected int HP;

        public string name;

        public string weapon;
        public string ammor;
        public string potion;

        public int heal = 10;
        public int ammorPoint;

        public virtual void Init()
        {

        }
        public void Attack(LifeEntity lifeEntity)
        {
            Console.WriteLine(name + "은 " + lifeEntity.name + "을(를) 공격했다.");
            lifeEntity.Hit(attackPoint);
        }

        public void Hit(int hitpoint)
        {
            HP -= hitpoint;
            Console.WriteLine(name + "은 공격 받았다.");
            Console.WriteLine(name + "은" + HP + "가 남았다");
        }

        public void Defense(LifeEntity lifeEntity)
        {
            Console.WriteLine(name + "은 방어에 성공했다.");
        }

        public void Item(LifeEntity lifeEntity)
        {
            Console.WriteLine(name + "은 회복 물약을 사용했다.");
            lifeEntity.Potion(heal);
        }

        public void Potion(int healing)
        {
            heal += healing;
            Console.WriteLine(name + "은" + heal + "만큼의 체력을 회복했다.");

        }

        public void Weapon(LifeEntity lifeEntity)
        {
            weapon = "강철검";
            Console.WriteLine(name + "은" + weapon + "을(를) 습득했다.");
            lifeEntity.AttackPoint(attackPoint);

        }

        public void AttackPoint(int AttackPoint)
        {
            attackPoint = AttackPoint + 5;
            Console.WriteLine(name + "은 공격력이" + attackPoint + "로 상승했다.");
        }

        public void Ammor(LifeEntity lifeEntity)
        {
            ammor = "가죽갑옷";
            Console.WriteLine(name + "은" + ammor + "을 습득했다.");
            lifeEntity.AmmorPoint(ammorPoint);
        }

        public void AmmorPoint(int AmmorPoint)
        {
            ammorPoint = AmmorPoint + 1;
            Console.WriteLine(ammorPoint + "만큼 방어력 상승");

        }


        
    }
}


