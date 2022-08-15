using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rullet
{
    class Monster_Gagoil : AbstractMonster
    {

        public override void InitData()
        {
            Hp = 500;


            Attack_Power = 40;

            Name = "가고일";

            MonsterLevel = "S";
            Coin = 1000;
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
            Console.WriteLine(@"                                
         .-!      -;,         
        -;**      .=!:,       
      .:;$#:       !#=;:      
     ,:;$#=-       ~$#$;~     
    -~!$$#=-       ~$$#$;:.            투둑....
   -:*$#$$*~ ,.,-. :$$=#$!:.           닝겐 앞으로 나아갈수 없다...
  ,:*===$$=;~,.,,;~:*=$==$!~. 
 .~!$**===:;;:,.-~:;!==**==;-.
.~;=****=;~;*:*-~~!!-**=*!*=:-
-;=*!**!*;:!*~:*:;;!-*!!**!==:
:*=!!*!;!*;!=;;;!:!;~*!;!!!*=!
!=!;***!!*!:;=;*=*!-:*!!**!;*=
=*!;**;;!*!::=!!!*;,**!!;*!;!*
*!!;**!!!*!~:~$!;=;-!*;;!*!;!!
*!!!!!!!*=*:;:###=*~*=!!!*!!!!
*!!!***!**!;~:!#$==~=!*!!*!!!!
!!!!*!!;!-*!~::#==!-$;;!!**!!!
!;-;;-!!;~==::;#!!;:$!;*:-*:-;
~      :!!=$:~;#!;:!$!$~      
       ~,:$$;~:#;:~$=,-       
         ,=$*-~#;~:#-         
          !$*,~@;~;$~,        
         -!::~-#~--!#$:       
        -::~!!~;;~;!:;;-      
        -;=;!*;;!!***!!~      
        -:!!*!;;!*****!~      
        -;;!!!;;:;!!!!*-      
         :;!!!;;;!!**!*-      
         ,--------~----   ");

        }
    }
}
