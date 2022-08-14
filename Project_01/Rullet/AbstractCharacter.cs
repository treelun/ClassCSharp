using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Rullet
{
    abstract class AbstractCharacter : Character
    {
        public AbstractCharacter (ref int coin) : base()
        {
            InitData(ref coin);
        }
        public abstract void InitData(ref int coin);

        protected void SetAttack(AbstractCharacter player)
        {
            player.Damage(player.Attack_Power);
            
        }


        public abstract void Attack(AbstractCharacter player);

        public abstract void Levelup();

        public void Attack(AbstractMonster[] monsters, ref int coin, ref int PlayerHp, ref int PlayerExp)
        {
            Monster_Setting setting = new Monster_Setting();

            setting.CalledMonster(monsters);
            MainMenu menu = new MainMenu();
            while (true)//공격한다, 도망간다 선택 넣기. 레벨업 시스템 넣기.
            {
                
                string a1 = "공격한다.";
                string a2 = "도망간다.";
                string a3 = "플레이어 정보보기";
                string a4 = "몬스터 정보보기";
                int posY = 0;

                menu.mainMenu(ref posY, ref a1, ref a2, ref a3, ref a4);

                if (true)
                {
                    if (monsters[0].Hp > 0 && Hp > 0 && posY == 0)
                    {
                        Console.Clear();
                        monsters[0].Hp -= GetAttack_Power();
                        Console.WriteLine($"{GetName()}이(가) {monsters[0].GetName()}를 공격하였습니다.");
                        Console.WriteLine($"{monsters[0].GetName()}의 체력이 {GetAttack_Power()}만큼 줄었습니다.");
                        Console.WriteLine($"{monsters[0].GetName()}의 체력이 {monsters[0].Hp}만큼 남았습니다.");
                        Thread.Sleep(700);

                        Console.Clear();
                        Hp -= monsters[0].GetAttack_Power();
                        Console.WriteLine($"{monsters[0].GetName()}이(가) {GetName()}를 공격하였습니다.");
                        Console.WriteLine($"{GetName()}의 체력이 {monsters[0].GetAttack_Power()}만큼 줄었습니다.");
                        Console.WriteLine($"{GetName()}의 체력이 {Hp}만큼 남았습니다.");
                        Thread.Sleep(700);
                        
                    }
                    else if (monsters[0].Hp <= 0 && posY == 0)
                    {
                        Console.WriteLine($"{GetName()}이(가) {monsters[0].GetName()}를 처치하였습니다.");
                        Console.WriteLine($"경험치{monsters[0].GetExp()}획득 Coin{monsters[0].GetCoin()}획득하였습니다");
                        coin += monsters[0].GetCoin();
                        Exp += monsters[0].GetExp();
                        Console.WriteLine($"잔여 코인 수량{coin}");
                        if (monsters[0].Hp <= 0 && Exp >= 100)
                        {
                            Console.WriteLine("레벨업!");
                            Console.WriteLine("레벨업으로 인해 체력이 100 상승");
                            Levelup();
                            Hp += 100;
                            Exp = 0;
                        }
                        break;
                    }

                    else if (Hp <= 0)
                    {
                        Console.WriteLine("당신은 사망하였습니다. 게임을 종료합니다.");
                        coin = 5000;
                        break;
                    }
                    else if (posY == 2)
                    {
                        PrintPlayerStat();
                        continue;
                    }
                    else if (posY == 3)
                    {
                        monsters[0].PrintStat();
                        continue;
                    }
                    else if (posY == 1)
                    {
                        break;
                    }
                }


            }

        }
    }
}
