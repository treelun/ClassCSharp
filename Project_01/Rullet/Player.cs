using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rullet
{
    class Player : AbstractCharacter
    {
        public override void InitData(abstractItem[] item, ref int RandomValue)
        {
            
            
            Hp = 300;


            Attack_Power = item[RandomValue].WeaponDamage;

            Name = "주인공";

            PlayerLevel = 0;

            Exp = 0;
            //PrintPlayerStat(item, ref RandomValue);
        }

        public override void Attack(AbstractMonster damageArmy, ref int coin)
        {
            base.SetAttack(damageArmy, ref coin);
            string damageName = damageArmy.GetName();
            int gainExp = damageArmy.GetExp();

            Console.WriteLine($"{Name}이(가) {damageName}을 공격했다!");
            Console.WriteLine($"{Name}이(가) {gainExp}을 획득!");
        }

        public void Levelup()
        {
            if (Exp == 100)
            {
                PlayerLevel += 1;
            }
        }
    }
}
