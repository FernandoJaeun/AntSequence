using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace 개미수열3
{
    class Program
    {
        static void Main(string[] args)
        {
            int repeat = Convert.ToInt32(ReadLine());        //반복횟수 입력
            WriteLine(1);
            for (int i = 0; i < repeat; i++)        //정해진 만큼 반복
            {
                AntNumber();        //개미수열
            }
        }
        public static StringBuilder sb = new StringBuilder(""); // 개미수열 결과 값
        public static string condition = "1";    //개미수열 할 값 
        public static int count = 0;        //같은 수 반복횟수
        static void AntNumber()
        {
            for (int i = 0; i < condition.ToString().Length; i++)
            {
                if (i > 0 && condition.ToString().Substring(i, 1) != condition.ToString().Substring(i - 1, 1))
                {
                    sb.Append(condition.ToString().Substring(i - 1,1) + count.ToString());
                    count = 0;
                }

                count++;  //몇번 나왔는지 계산하는 코드

                if (i + 1 == condition.ToString().Length)   // 배열이 끝나기 직전, 미처 입력 안된 값을
                {                                                                       // 결과값에 저장
                    sb.Append(condition.ToString().Substring(i, 1) + count.ToString());
                    count = 0;
                }
            }
            WriteLine(sb);
            condition = sb.ToString();
            sb.Remove(0, sb.Length);
        }

    }
}
