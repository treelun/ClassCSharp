using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rullet
{
    class Monster_Boss : AbstractMonster
    {

        public override void InitData()
        {
            Hp = 1000;


            Attack_Power = 100;

            Name = "사우론";

            MonsterLevel = "SS";
            Coin = 10000;
            PrintMonster();
            GiveExp = 15;
            //PrintStat();
        }

        public override void Attack(AbstractMonster player)
        {
            base.SetAttack(player);
            string damageName = player.GetName();
            int gainExp = player.GetExp();


            Console.WriteLine($"{Name}이(가) {damageName}을 공격했다!");
            Console.WriteLine($"{Name}이(가) 경험치{gainExp}을 획득!");

        }
        public void PrintMonster()
        {
            Console.WriteLine(@"       , ,, ,                              
                                       | || |    ,/  _____  \.             
                                       \_||_/    ||_/     \_||             
                                         ||       \_| . . |_/              
                                         ||         |  L  |                
                                        ,||         |`==='|                
                                        |&gt;|  ___`&gt;  -&lt;'___             
                                        |&gt;|\    /          \            
                                        \&gt;| \  /  ,    . .  |           
                                         ||  \/  /| .  |  . |  |           
                                         ||\  ` / | ___|___ |  |     (     
                                      (( || `--'  | _______ |  |     ))  ( 
                                    (  )\|| (  )\ | - --- - | -| (  ( \  ))
                                    (\/  || ))/ ( | -- - -- |  | )) )  \(( 
                                     ( ()||((( ())|         |  |( (( () )FK");
            
        }
    }
}
