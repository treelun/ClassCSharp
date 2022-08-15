using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;


namespace Rullet
{
    abstract class AbstractCharacter : Character
    {
        public AbstractCharacter (ref int coin) : base()
        {
            InitData(ref coin);
        }
        public abstract void InitData(ref int coin);



        public abstract void Levelup();

        public void Attack(AbstractMonster[] monsters, ref int coin) // 공격할때의 함수
        {
            Monster_Setting setting = new Monster_Setting();
            Random ran = new Random();
            setting.CalledMonster(monsters); // 몬스터 생성
            MainMenu menu = new MainMenu();
            while (true)//공격한다, 도망간다 선택 넣기. 레벨업 시스템 넣기. 가위바위보 추가로 인해 난이도 조절필요
            {
                
                string a1 = "공격한다.";
                string a2 = "도망간다.";
                string a3 = "플레이어 정보보기";
                string a4 = "몬스터 정보보기";
                int posY = 0;
                int Monsterattack = ran.Next(1, 4); // 몬스터 가위바위보
                menu.mainMenu(ref posY, ref a1, ref a2, ref a3, ref a4); //메인메뉴 클래스, 메뉴선택

                if (true)
                {
                    
                    if (monsters[0].Hp > 0 && Hp > 0 && posY == 0 ) // 1:가위, 2: 바위 , 3: 보
                    {
                        SetCursorPosition(10, 10);
                        Console.Write("가위(1), 바위(2), 보(3) 중 하나를(숫자로) 입력하세요 : ");
                        int playerattack = int.Parse(ReadLine());
                        switch (playerattack)  // 입력숫자를 한글로 변환
                        {
                            case 1:
                                SetCursorPosition(10, 11);
                                WriteLine("플레이어 : 가위");
                                break;
                            case 2:
                                SetCursorPosition(10, 11);
                                WriteLine("플레이어 : 바위");
                                break;
                            case 3:
                                SetCursorPosition(10, 11);
                                WriteLine("플레이어 : 보");
                                break;
                            default:
                                break;
                        }
                        switch (Monsterattack)
                        {
                            case 1:
                                SetCursorPosition(10, 12);
                                WriteLine("몬스터 : 가위");
                                break;
                            case 2:
                                SetCursorPosition(10, 12);
                                WriteLine("몬스터 : 바위");
                                break;
                            case 3:
                                SetCursorPosition(10, 12);
                                WriteLine("몬스터 : 보");
                                break;
                            default:
                                break;
                        }
                        Thread.Sleep(1000);
                        switch (playerattack)
                        {
                            case 1 : //1 : 가위를 입력받았을때
                                if (Monsterattack == 3) // 3 보를 내면 이기므로 공격
                                {
                                    
                                    monsters[0].Hp -= GetAttack_Power();// 플레이어가 공격
                                    SetCursorPosition(10, 13);
                                    Console.WriteLine($"{GetName()}이(가) 이겼습니다. {monsters[0].GetName()}를 공격하였습니다.");
                                    SetCursorPosition(10, 14);
                                    Console.WriteLine($"{monsters[0].GetName()}의 체력이 {GetAttack_Power()}만큼 줄었습니다.");
                                    SetCursorPosition(10, 15);
                                    Console.WriteLine($"{monsters[0].GetName()}의 체력이 {monsters[0].Hp}만큼 남았습니다.");
                                    Thread.Sleep(1500);
                                    if (monsters[0].Hp <= 0)//몬스터 처치시
                                    {
                                        SetCursorPosition(5, 27);
                                        Console.WriteLine($"{GetName()}이(가) {monsters[0].GetName()}를 처치하였습니다.");
                                        SetCursorPosition(5, 28);
                                        Console.WriteLine($"경험치{monsters[0].GetExp()}획득 Coin{monsters[0].GetCoin()}획득하였습니다");
                                        coin += monsters[0].GetCoin();
                                        Exp += monsters[0].GetExp();
                                        SetCursorPosition(95, 0);
                                        Console.WriteLine($"잔여코인 {coin}");
                                        if (monsters[0].Hp <= 0 && Exp >= 100)// 몬스터 처치후 경험치가 100 이면 Levelup
                                        {
                                            Console.WriteLine("레벨업!");
                                            Console.WriteLine("레벨업으로 인해 체력이 100 회복");
                                            Levelup();
                                            Hp += 100;
                                            Exp = 0; // 경험치를 0으로 초기화
                                        }
                                        break;
                                    }
                                }
                                else if (Monsterattack == 2)//2: 바위가 나오면 플레이어가 공격받음
                                {
                                    Hp -= monsters[0].GetAttack_Power(); // 몬스터가 공격
                                    SetCursorPosition(10, 13);
                                    Console.WriteLine($"{monsters[0].GetName()}이(가) 이겼습니다. {GetName()}를 공격하였습니다.");
                                    SetCursorPosition(10, 14);
                                    Console.WriteLine($"{GetName()}의 체력이 {monsters[0].GetAttack_Power()}만큼 줄었습니다.");
                                    SetCursorPosition(10, 15);
                                    Console.WriteLine($"{GetName()}의 체력이 {Hp}만큼 남았습니다.");
                                    Thread.Sleep(1000);
                                    if (Hp <= 0)//죽음
                                    {
                                        Console.WriteLine("당신은 사망하였습니다. 게임을 종료합니다.");
                                        PrintDeath();
                                        coin = 5000;
                                        break;
                                    }
                                }
                                else if (Monsterattack == 1)
                                {
                                    SetCursorPosition(10, 13);
                                    WriteLine("비겼습니다. 다음턴으로 진행됩니다.");
                                }
                                continue;
                            case 2://주인공이 2 : 바위를 냄
                                if (Monsterattack == 1) //몬스터가 1: 가위를 내면 이기므로 공격
                                {
                                    
                                    monsters[0].Hp -= GetAttack_Power();// 플레이어가 공격
                                    SetCursorPosition(10, 13);
                                    Console.WriteLine($"{GetName()}이(가) 이겼습니다. {monsters[0].GetName()}를 공격하였습니다.");
                                    SetCursorPosition(10, 14);
                                    Console.WriteLine($"{monsters[0].GetName()}의 체력이 {GetAttack_Power()}만큼 줄었습니다.");
                                    SetCursorPosition(10, 15);
                                    Console.WriteLine($"{monsters[0].GetName()}의 체력이 {monsters[0].Hp}만큼 남았습니다.");
                                    Thread.Sleep(1500);
                                    if (monsters[0].Hp <= 0)//몬스터 처치시
                                    {
                                        SetCursorPosition(5, 27);
                                        Console.WriteLine($"{GetName()}이(가) {monsters[0].GetName()}를 처치하였습니다.");
                                        SetCursorPosition(5, 28);
                                        Console.WriteLine($"경험치{monsters[0].GetExp()}획득 Coin{monsters[0].GetCoin()}획득하였습니다");
                                        coin += monsters[0].GetCoin();
                                        Exp += monsters[0].GetExp();
                                        SetCursorPosition(95, 0);
                                        Console.WriteLine($"잔여코인 {coin}");
                                        if (monsters[0].Hp <= 0 && Exp >= 100)// 몬스터 처치후 경험치가 100 이면 Levelup
                                        {
                                            Console.WriteLine("레벨업!");
                                            Console.WriteLine("레벨업으로 인해 체력이 100 회복");
                                            Levelup();
                                            Hp += 100;
                                            Exp = 0; // 경험치를 0으로 초기화
                                        }
                                        break;
                                    }
                                }
                                else if (Monsterattack == 3)//2: 보가 나오면 플레이어가 공격받음
                                {
                                    Hp -= monsters[0].GetAttack_Power(); //몬스터가 공격
                                    SetCursorPosition(10, 13);
                                    Console.WriteLine($"{monsters[0].GetName()}이(가) 이겼습니다. {GetName()}를 공격하였습니다.");
                                    SetCursorPosition(10, 14);
                                    Console.WriteLine($"{GetName()}의 체력이 {monsters[0].GetAttack_Power()}만큼 줄었습니다.");
                                    SetCursorPosition(10, 15);
                                    Console.WriteLine($"{GetName()}의 체력이 {Hp}만큼 남았습니다.");
                                    Thread.Sleep(1000);
                                    if (Hp <= 0)//죽음
                                    {
                                        Console.WriteLine("당신은 사망하였습니다. 게임을 종료합니다.");
                                        PrintDeath();
                                        coin = 5000;
                                        break;
                                    }
                                }
                                else if (Monsterattack == 2)//2: 바위가 나오면 비기므로 아무런 공방없이 진행
                                {
                                    SetCursorPosition(10, 13);
                                    WriteLine("비겼습니다. 다음턴으로 진행됩니다.");
                                }
                                continue;
                            case 3://3:보
                                if (Monsterattack == 2) // 주먹
                                {
                                    
                                    monsters[0].Hp -= GetAttack_Power();//플레이어가 공격
                                    SetCursorPosition(10, 13);
                                    Console.WriteLine($"{GetName()}이(가) 이겼습니다. {monsters[0].GetName()}를 공격하였습니다.");
                                    SetCursorPosition(10, 14);
                                    Console.WriteLine($"{monsters[0].GetName()}의 체력이 {GetAttack_Power()}만큼 줄었습니다.");
                                    SetCursorPosition(10, 15);
                                    Console.WriteLine($"{monsters[0].GetName()}의 체력이 {monsters[0].Hp}만큼 남았습니다.");
                                    Thread.Sleep(1500);
                                    if (monsters[0].Hp <= 0)//몬스터 처치시
                                    {
                                        SetCursorPosition(5, 27);
                                        Console.WriteLine($"{GetName()}이(가) {monsters[0].GetName()}를 처치하였습니다.");
                                        SetCursorPosition(5, 28);
                                        Console.WriteLine($"경험치{monsters[0].GetExp()}획득 Coin{monsters[0].GetCoin()}획득하였습니다");
                                        coin += monsters[0].GetCoin();
                                        Exp += monsters[0].GetExp();
                                        SetCursorPosition(95, 0);
                                        Console.WriteLine($"잔여코인 {coin}");
                                        if (monsters[0].Hp <= 0 && Exp >= 100)// 몬스터 처치후 경험치가 100 이면 Levelup
                                        {
                                            Console.WriteLine("레벨업!");
                                            Console.WriteLine("레벨업으로 인해 체력이 100 회복");
                                            Levelup();
                                            Hp += 100;
                                            Exp = 0; // 경험치를 0으로 초기화
                                        }
                                        break;
                                    }
                                }
                                else if (Monsterattack == 1)//1: 가위가 나오면 플레이어가 공격받음
                                {
                                    Hp -= monsters[0].GetAttack_Power(); //몬스터가 공격
                                    SetCursorPosition(10, 13);
                                    Console.WriteLine($"{monsters[0].GetName()}이(가) 이겼습니다. {GetName()}를 공격하였습니다.");
                                    SetCursorPosition(10, 14);
                                    Console.WriteLine($"{GetName()}의 체력이 {monsters[0].GetAttack_Power()}만큼 줄었습니다.");
                                    SetCursorPosition(10, 15);
                                    Console.WriteLine($"{GetName()}의 체력이 {Hp}만큼 남았습니다.");
                                    Thread.Sleep(1000);
                                    if (Hp <= 0)//죽음
                                    {
                                        Console.WriteLine("당신은 사망하였습니다. 게임을 종료합니다.");
                                        PrintDeath();
                                        coin = 5000;
                                        break;
                                    }
                                }
                                else if (Monsterattack == 3)
                                {
                                    SetCursorPosition(10, 13);
                                    WriteLine($"비겼습니다. 다음턴으로 진행됩니다.");
                                }
                                continue;
                            default:
                                break;
                        }

                        
                    }
/*                    else if (monsters[0].Hp <= 0 && posY == 0)//몬스터 처치시
                    {
                        SetCursorPosition(5, 27);
                        Console.WriteLine($"{GetName()}이(가) {monsters[0].GetName()}를 처치하였습니다.");
                        SetCursorPosition(5, 28);
                        Console.WriteLine($"경험치{monsters[0].GetExp()}획득 Coin{monsters[0].GetCoin()}획득하였습니다");
                        coin += monsters[0].GetCoin();
                        Exp += monsters[0].GetExp();
                        SetCursorPosition(95, 0);
                        Console.WriteLine($"잔여코인 {coin}");
                        if (monsters[0].Hp <= 0 && Exp >= 100)// 몬스터 처치후 경험치가 100 이면 Levelup
                        {
                            Console.WriteLine("레벨업!");
                            Console.WriteLine("레벨업으로 인해 체력이 100 회복");
                            Levelup();
                            Hp += 100;
                            Exp = 0; // 경험치를 0으로 초기화
                        }
                        break;
                    }*/

/*                    if (Hp <= 0)//죽음
                    {
                        Console.WriteLine("당신은 사망하였습니다. 게임을 종료합니다.");
                        PrintDeath();
                        coin = 5000;
                        break;
                    }*/
                    else if (posY == 2) // 주인공 정보보기
                    {
                        PrintPlayerStat();
                        continue;
                    }
                    else if (posY == 3) // 몬스터 정보보기
                    {
                        monsters[0].PrintStat();
                        continue;
                    }
                    else if (posY == 1)
                    {
                        break;
                    }
                    else
                    {
                        SetCursorPosition(10, 10);
                        Console.WriteLine("몬스터를 재생성합니다.");
                        setting.CalledMonster(monsters);
                        continue;
                    }
                }


            }


        }
        public void PrintDeath()
        {
            Write(@"                 #n    n#n  n#n  #n  n#n   n#    n
                                     ####n######################## n#|
                                     |###############################
                                      ##############################|
                                      ##############################
                                     |#~~nnnnnn~~###~~nnnnn~~######|
                                     ~n##########n~n#########n~####|
                                     #############|############ ###
                                    |####~#######|####~########||#~
                          nnn        ###########~~|############ #n#~n
                         |###|        ~#####~nnn##n~#########~n###n##|
                         |####       nnnn~~~|#######nn~~~~~nn###n~##~
                          |###      |#######n~~~~~nn#############|
                          |##|     |#########################~ ###
                      nn#nn###nn#n  ~~#################~~~~ n| ##|
                     |##########~##    ~~~~~ nnnn nnnn ###~ ~ n##
                    |###########|n#        n ~~~~ ~~~~nnnn~~nn##
                     ~###########|~       |##nn~~~~~~~~nnn####~
                      ~~########|          ~~~###############|
                        |#######                 nnnnnn######
                        |#######|         nnnn###n~~~~~~~~~nn#####nnn
                        |########      nn##############################n
");
        }
    }
}
