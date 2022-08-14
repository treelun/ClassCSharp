using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rullet
{
    class Monster_DeathKnight : AbstractMonster
    {

        public override void InitData()
        {
            Hp = 1000;


            Attack_Power = 40;

            Name = "데스나이트";

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
                         XXXXXXXXXXXXXXXXXXXXXXX
                     XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
                  XXXX                                XXXX
              XXXX                                        XXXX
           XXX                                                XXX
         XX                                                      XX
       XX                                                          XX
      XX                                                            XX
     XX                                                              XX
    XX                                                        X       XX
   XX                                                   XX     XX      XX
  XX                                                      XXX    XX     XX
 XX      XX   XX                                             XX         XX
 XX    XX   XX                                                 XX        XX
XX    X    X                                                    XX       XX
XX   X    X                                                               X
X   X    X                                                                X
X       X              8                                 8                X
X                       8                               8                 X
X                  8     8                             8   8              X
X                   8  8  8                           8  8   8            X
X                    8  8  8                         8  8  88             X
X                     8  8  8                       XXXX  8               X
X                      8 XXXX                       XXXXX8                X
XX                      XXXXXX                    XXXXXXXX               XX
XX                     XXXXXXXX                  XXXXXXXXXX              XX
XX                    XXXXXXXXXX                XXXXXXXXXXXX             XX
 XX                  XXXXXXXXXXXX               XXXXXXXXXXXXX           XX
  XX                 XXXXXXXXXXXXX             XXXXXXXXXXXXXX          XX
  XX                XXXXXXXXXXXXXX            XXXXXXXXXXXXXXX          XX
  XX                XXXXXXXXXXXXXX           XXXXXXXXXXXXXXXX          XX
   XX              XXXXXXXXXXXXXXX           XXXXXXXXXXXXXXXX         XX
    XX             XXXXXXXXXXXXXXX           XXXXXXX    XXXXX        XX
     XX            XXXXXXX   XXXXX           XXXXXX      XXXX       XX
     XX            XXXXXX     XXX            XXXXX       XXXX       XX
      XX           XXXXX  88  XXXX           XXXX   88   XXX       XX
      XX           XXXX  8888  XX            XXXX  8888  XXX       XX
       XX          XXXX  8888 XXX            XXXX  8888 XXX       XX
        XX         XXXXX  88 XXX              XXXX  88 XXX       XX
          XX        XXXX    XXX               XXXX    XXX       XX
           XXX       XXXXXXXXX                 XXXXXXXXX       XXX
           XX          XXXXX      XXXXXXXXXXX    XXXXX           XX
          XXX           XX    XXXX           XXX  XX             XXX
          XX                XX XXXXX          XXXXX                XX
          XX               X  XX    XXXX  XXXX  XXXX   XXXX        XX
          XX                    XXX     XX     XX   XXX    X       XX
          XX                       XXX     XXX                    XX
           XX                         XXXXX                     XXX
             XX                                               XXX
              XXXXX                                        XXXX
                   XXXXXXXXXXX                     XXXXXXXX
                              XXXX             XXXX
                                 XX           XX
                                  XX         XX
                                  XX         XX
                                  XX         XX");

        }
    }
}
