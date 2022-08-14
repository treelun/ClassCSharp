using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using System.Threading;

namespace Rullet
{

    class Program
    {
        //1.가챠 만들기
        //리니지라이크 게임처럼 뽑기를 진행 보유 코인이있고 코인을 사용할때까지 뽑기하여 원하는 item을 획득하면 다음 게임으로 진행
        //아이템 종류 여러가지제작, 뽑기확률, 뽑았을시 다음단계로 진행.
        //2.아이템 강화하기
        //뽑은 아이템을 1부터 강화 max 단계를 정해놓고 강화시작
        //강화 성공시 Damage 증가 , 증가폭은 일단 보류
        //일정 강화단계에서 실패시 강화단계 확률로 하락
        //3. 강화한 아이템으로 몬스터 잡기
        //몬스터 만들기 , a,b,c,d,s등 랭크를 정하여 차례대로 처치
        //등급별 몬스터 능력치 차등적용
        //아이템 강화하기에서 강화가 어느정도 이상되면 s랭크는 손쉽게 잡을수 있도록 레벨링
        //s랭크 몬스터 처치시 게임 종료
        //4.주인공 캐릭터 생성, 무기착용, 체력 stat 있어야함
        //몬스터를 한번에 못죽일시 데미지 들어옴
        //주인공 공격먼저 -> 몬스터 공격
        /*        0. 편하게 최상단에
        using static System.Console; 을 적고 시작하세요
        System.Console 을 스킵할 수 있습니다.

        1. 방향키 입력 방식
                        ConsoleKeyInfo key = Console.ReadKey(true);
                        switch (key.Key)
                        {
                            case ConsoleKey.UpArrow:
                                break;
                            case ConsoleKey.DownArrow:
                                break;
                            case ConsoleKey.Enter:
                                break;
                        }

        2.원하는 위치에 커서 두기
           SetCursorPosition( x 좌표 , y 좌표 );

        3.화면 전체 지우기
           Clear();

        4.글자 꾸미기
        한번 바꾸면 이후로 모두 적용이 됩니다.
        때문에, 원하지 않는다면 원래대로 돌려놔야 합니다.
           4-1. 글자 바탕색(원래 검은색이기 때문에 다시 검은색으로 돌려놓아야함)
                       BackgroundColor = ConsoleColor.Yellow;
        Write("★☆");
        BackgroundColor = ConsoleColor.Black;

        4 - 2.글자 색 바꾸기
              Console.ForegroundColor = ConsoleColor.Blue;
        Write("★☆");
        Console.ForegroundColor = ConsoleColor.White;

        5.잠시 대기하기
        1000 이 1초
           Thread.Sleep(1000); //1초 대기. 1초후에 뒤에 내용이 실행됨
        */
        //8월 14일 무기 도트찍기.....



        static void Main(string[] args)
        {
            Start start = new Start();
            start.start();
            
        }


    }
}
