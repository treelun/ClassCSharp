﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rullet
{
    class Monster_Orc : AbstractMonster
    {

        public override void InitData()
        {
            Hp = 100;


            Attack_Power = 10;

            Name = "오크";

            MonsterLevel = "C";
            Coin = 150;
            PrintMonster();
            GiveExp = 15;
            //PrintStat();
        }


        public void PrintMonster()
        {
            Console.WriteLine(@"   
########@@@##$=*$#########@@@#
#@@@###@@@#=;~~~~;*#@@###@@@##
@@@@###=##$:~---~:;*@@#$#@####
@@####$*##!:~----:;*$#$=######     오크!!
#######*##;;~~-~~:;*$#=#@####@     인간!! 죽인다!
#####@$**=;;:~~~::!*$#*#@@###@
@##@@@$*!*::~~:::;;*===#######
###@#*!=!*:~~;;;;;!!*$$$:*####
###;--!$==!;::!!*;;*$$#$;:;!$#
#=~--~!$=#$*$=$*$$$$###$;;;;!*
!~--~:!**$=*$==!$#$$$##$*!;;!!
~~-~:;*=**=!;!;~*$=##$$$=*!!!!
:~~:;!*=*!;:=;;;*=$=*=$$=**!!!
;:;;;!=$$$=*=##$#@##$##$==****
!!!!!*==$$$*;=$#@#$####$$=====
!!!!!**=$$$;;;*$$=$####$$=====
!!!!*!!=!$$!!!*===$###*$$=====
;;!*!!!*!=$*!**===$##!*$$$===*
;::;!!!**!$=*=*==$###~*$$$=***
!;;::;!*=;$##$$###@@*~=$$=====
!!;;;;!*=*=******===$=$$======
!!!!!!!*$===*!!!*=$###$$$$$$$$
*!!;;!!*#@@@@####@@@@@$$==$=$$
**!;;;;!*@@##@@@@@##@#======$$
=*!;;;;;!$@##########=======$$
$=*!!!!!!!$##$$$$$##=======$$#
#$=**!!!!!*=#######$======$$##
@#$$==*****==$###$$$====$$$##@
@@##$$=======$##$$$$$$$$$##@@@
@@@###$$$==$$$##$$$$$$$##@####");




        }
    }
}
