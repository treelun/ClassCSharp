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
            Hp = 500;


            Attack_Power = 100;

            Name = "마왕";

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
        \_||_/    ||_/     \_||             호호호호
          ||       \_| . . |_/              어서오세요 닝겐
          ||         |  L  |                이곳은 제 성이랍니다
         ,||         |`==='|                
      |&gt;|  ___`&gt;  -&lt;'___             
      |&gt;|\    /             \            
      \&gt;| \  /  ,    . .     |           
          ||  \/  /| .  |  . |  |           
          ||\  ` / | ___|___ |  |     (     
       (( || `--'  | _______ |  |     ))  ( 
     (  )\|| (  )\ | - --- - | -| (  ( \  ))
     (\/  || ))/ ( | -- - -- |  | )) )  \(( 
      ( ()||((( ())|         |  |( (( () )FK");
            
        }
    }
}
