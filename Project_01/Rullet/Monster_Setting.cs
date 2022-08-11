using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Rullet
{
    class Monster_Setting : Character
    {
        public void CalledMonster(AbstractMonster[] monsters)
        {
            int Y = 0;
            string f = "F 등급 몬스터";
            string d = "D 등급 몬스터";
            string c = "C 등급 몬스터";
            string b = "B 등급 몬스터";
            string a = "A 등급 몬스터";
            string s = "S 등급 몬스터";
            string boss = "BOSS 등급 몬스터";
            MainMenu menu = new MainMenu();
            menu.MonsterSelectMenu(ref Y, ref f, ref d, ref c,ref b, ref a, ref s, ref boss);

            
            if (Y == 0)
            {
                monsters[0] = new Monster_Rabit();
                Console.WriteLine($"토끼 생성");
            }
            else if (Y == 1)
            {
                monsters[0] = new Monster_Goblin();
                Console.WriteLine("고블린 생성");
            }
            else if (Y == 2)
            {
                monsters[0] = new Monster_Orc();
                Console.WriteLine("오크 생성");
            }
            else if (Y == 3)
            {
                monsters[0] = new Monster_Oger();
                Console.WriteLine("오거 생성");
            }
            else if (Y == 4)
            {
                monsters[0] = new Monster_Vampire();
                Console.WriteLine("뱀파이어 생성");
            }
            else if (Y == 5)
            {
                monsters[0] = new Monster_DeathKnight();
                Console.WriteLine("데스나이트 생성");
            }
            else if (Y == 6)
            {
                monsters[0] = new Monster_Boss();
                Console.WriteLine("사우론 생성");
            }

            

        }
       /* public void Attack(AbstractMonster[] monsters, AbstractCharacter player,ref int coin, ref int PlayerHp, ref int PlayerExp)
        {

            CalledMonster(monsters);
            MainMenu menu = new MainMenu();
            while (true)//공격한다, 도망간다 선택 넣기. 레벨업 시스템 넣기.
            {
                
                string a1 = "공격한다.";
                string a2 = "도망간다.";
                string a3 = "플레이어 정보보기";
                string a4 = "몬스터 정보보기";
                int posY = 0;
                
                menu.mainMenu(ref posY, ref a1, ref a2,ref a3, ref a4);

                if (true)
                {
                    if (monsters[0].Hp > 0 && player.Hp > 0 && posY == 0)
                    {
                        Console.Clear();
                        monsters[0].Hp -= player.GetAttack_Power();
                        Console.WriteLine($"{player.GetName()}이(가) {monsters[0].GetName()}를 공격하였습니다.");
                        Console.WriteLine($"{monsters[0].GetName()}의 체력이 {player.GetAttack_Power()}만큼 줄었습니다.");
                        Console.WriteLine($"{monsters[0].GetName()}의 체력이 {monsters[0].Hp}만큼 남았습니다.");
                        Thread.Sleep(700);

                        Console.Clear();
                        PlayerHp -= monsters[0].GetAttack_Power();
                        Console.WriteLine($"{monsters[0].GetName()}이(가) {player.GetName()}를 공격하였습니다.");
                        Console.WriteLine($"{player.GetName()}의 체력이 {monsters[0].GetAttack_Power()}만큼 줄었습니다.");
                        Console.WriteLine($"{player.GetName()}의 체력이 {PlayerHp}만큼 남았습니다.");
                        Thread.Sleep(700);
                    }
                    else if (monsters[0].Hp <= 0 && posY == 0)
                    {
                        Console.WriteLine($"{player.GetName()}이(가) {monsters[0].GetName()}를 처치하였습니다.");
                        Console.WriteLine($"경험치{monsters[0].GetExp()}획득 Coin{monsters[0].GetCoin()}획득하였습니다");
                        coin += monsters[0].GetCoin();
                        Exp += monsters[0].GetExp();
                        Console.WriteLine($"잔여 코인 수량{coin}");
                        if (monsters[0].Hp <= 0 && Exp >= 100)
                        {
                            Console.WriteLine("레벨업!");
                            Console.WriteLine("레벨업으로 인해 체력이 100 상승");
                            player.Levelup();
                            PlayerHp += 100;
                        }
                        break;
                    }

                    else if (player.Hp <= 0)
                    {
                        Console.WriteLine("당신은 사망하였습니다. 게임을 종료합니다.");
                        coin = 30000;
                        break;
                    }
                    else if(posY == 2)
                    {
                        player.PrintPlayerStat();
                        continue;
                    }
                    else if(posY == 3)
                    {
                        monsters[0].PrintStat();
                        continue;
                    }
                    else if(posY == 1)
                    {
                        break;
                    }
                }
               
                
            }

        }*/
    }
}
