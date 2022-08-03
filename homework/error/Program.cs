using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace error
{
    class Program
    {
        static void Main(string[] args)
        {
            //Answer(); // Answer불러와서 세자리 숫자 정함
            
            int[] Answer_Array = Answer();
            int PlayRound = 1; // 플레이하는 중인 라운드
            Console.WriteLine($"{Answer_Array[0]}, {Answer_Array[1]}, {Answer_Array[2]}");
            while (true)
            {
                Console.WriteLine($"{PlayRound}번째 시도 중"); // 현 라운드 공지
                Console.WriteLine("숫자야구 3글자 입력, 겹치는 숫자X: ");
                string input_first = Console.ReadLine(); // input_first으로 숫자 받기
                char[] input_first_Array = input_first.ToCharArray(); // 숫자 받은걸 배열로 만듦


                if (Compare_first_Answer(input_first_Array, Answer_Array))  // Answer_Array에서 오류가 나요!
                {
                    break;
                }
                else
                {
                    PlayRound++;
                }
            }
            Console.WriteLine($"성공할 때까지의 횟수: {PlayRound}회");
        }

        // set Random Number 
        public static int[] Answer()
        {
            Random random = new Random();

            int set_hundred = 0; // 3자리수 설정 위함
            int[] Answer_Array = new int[3]; // 3자리수 각각 자리 설정 array로
            while (set_hundred < 3) // 백의 자리까지 돌아감
            {
                bool overlap = true; // 겹치면 false 반환해서 다시 돌리기 위함
                Answer_Array[set_hundred] = new Random().Next(0, 9); // 랜덤 숫자 넣음
                for (int i = set_hundred - 1; set_hundred >= 0; set_hundred--) // 일의 자리부터 겹치는지 확인 후 수정
                {
                    if (Answer_Array[set_hundred] == Answer_Array[i])
                    {
                        overlap = false;
                        break;
                    }
                    if (overlap) // 안겹치고 빠져나오면 자릿수 하나 높임
                    {
                        set_hundred++;
                    }
                }
            }
            return Answer_Array;
        }

        // 숫자 하나씩 비교할 때 쓰는 것
        public static bool Compare_Numbers(string s1, string s2)
        {
            if (s1 == s2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // 유저가 넣은 숫자와 비교
        public static bool Compare_first_Answer(char[] input_first_Array, int[] Answer_Array)
        {
            int strike = 0;
            int ball = 0;

            for (int input = 0; input < 3; input++) // input 숫자 증가시키며 확인
            {
                for (int answer = 0; answer < 3; answer++) // answer 숫자 증가시키며 확인
                {
                    if (Compare_Numbers(input_first_Array[input].ToString(), Answer_Array[answer].ToString()))
                    {
                        if (input==answer)
                        {
                            strike++;
                        }
                        else
                        {
                            ball++;
                        }
                    }
                }
            }
            Console.WriteLine($"스트라이크: {strike}, 볼: {ball}");
            if (strike == 3)
            {
                Console.WriteLine("정답!");
                return true;
            }
            return false;
        }
    }
}
