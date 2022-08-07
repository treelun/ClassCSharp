using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        const uint MAX_ARRAY = 20;
        static void Main(string[] args)
        {
            int coin = 10000;

            string weapon = "나뭇가지";
            string weapon2 = "권투글러브";
            string weapon3 = "돌검";
            string weapon4 = "청동검";
            string weapon5 = "강철검";
            string weapon6 = "티타늄검";
            string weapon7 = "아다만티움검";
            string weapon8 = "비뷰라늄검";
            string weapon9 = "암흑물질검";
            Character[] character = new Character[MAX_ARRAY];
            character[0] = new Rabit();
            


        }
    }
}
