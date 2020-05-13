using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS2
{
    class Program
    {
        enum eItemEffect
        {
            공격력 = 1,
            방어력,
            공격속도 =4,
            이동속도 = 8
                
        }
        static void Main(string[] args)
        {
            {
                //int number = 0;
                //bool result1, result2;
                //Console.Write("정수를 입력하세요 : ");
                //number = int.Parse(Console.ReadLine());
                //Console.WriteLine("입력한 정수는 [{0}]입니다.", number);
                //result1 = number < 0;
                //result2 = number > 0;
                //if (result1)
                //{
                //    Console.WriteLine("[{0}]은 음의 정수입니다.", number);
                //}
                //else if (result2)
                //{
                //    Console.WriteLine("[{0}]은 양의 정수입니다.", number);
                //}

                //0일때는 조건이 없으므로 그냥 지나감
                //조건문에 들어가는 논리값이 반복가능성이 있는경우 변수로 써먹자
            }
            {
                //Console.Write("당신의 나이를 입력하세요 : ");
                //uint age = uint.Parse(Console.ReadLine());
                //if(age/10 < (int)eAge.소년)
                //{
                //    Console.WriteLine("당신은 {0}입니다.",eAge.소년);
                //}
                //else if(age/10 < (int)eAge.청소년)
                //{
                //    Console.WriteLine("당신은 청소년입니다.");
                //}
                //else if(age/10 < (int)eAge.청년)
                //{
                //    Console.WriteLine("당신은 청년입니다.");
                //}
                //else if (age/10 < (int)eAge.아저씨)
                //{
                //    Console.WriteLine("당신은 아저씨입니다.");
                //}
                /*조건문은 1) 우선순위. 상하관계가 있다. if, else if에서 전자가 '아닌'경우에 후자가 처리. 컴퓨터가 전자를 읽음.
                          2) 탈락시켜야하는 조건을 먼저 쓰는게 좋다.
                          3) 조건이 상하관계없이 대등할 경우 switch분기문을 쓰도록하자.
                */
                //int hour = 0;
                //Console.Write("현재 시간을 입력해 주세요(24시간 표기) : ");
                //hour = int.Parse(Console.ReadLine());

                //switch (hour/6)
                //{
                //    case 0:
                //       // Console.WriteLine("새벽 입니다.");
                //       // break;
                //    case 1:
                //       // Console.WriteLine("오전 입니다.");
                //       // break;
                //    case 2:
                //       // Console.WriteLine("오후 입니다.");
                //       // break;
                //    case 3:
                //        // Console.WriteLine("밤 입니다.");
                //        Console.WriteLine("{0}입니다", (eTimeType)(hour / 6));
                //        break;
                //    default:
                //        Console.WriteLine("그런 시간은 없습니다.");
                //        break;
                //}

                //Console.WriteLine("1.{0} 상승", eItemEffect.공격력);
                //Console.WriteLine("2.{0} 상승", eItemEffect.방어력);
                //Console.WriteLine("3.{0} 상승", eItemEffect.공격속도);
                //Console.Write("4.{0} 상승\n어떤 효과를 추가하실 건가요 : ", eItemEffect.이동속도);
                //int choice = int.Parse(Console.ReadLine());
                //int buff = 1 << (choice - 1); //변수가 분기문에 공통적으로 할당되야하므로 수식을 이용해서 분기시킬 수 있다.
                //switch (choice)
                //{
                //    case 1:
                //        Console.WriteLine("{0}이(가) 상승되었습니다",eItemEffect.공격력);
                //        Console.WriteLine("Buff = {0}입니다", buff);
                //        break;
                //    case 2:
                //        Console.WriteLine("{0}이(가) 상승되었습니다", eItemEffect.방어력);
                //        Console.WriteLine("Buff = {0}입니다", buff);
                //        break;
                //    case 3:
                //        Console.WriteLine("{0}이(가) 상승되었습니다", eItemEffect.공격속도);
                //        Console.WriteLine("Buff = {0}입니다", buff);
                //        break;
                //    case 4:
                //        Console.WriteLine("{0}이(가) 상승되었습니다", eItemEffect.이동속도);
                //        Console.WriteLine("Buff = {0}입니다", buff);
                //        break;
                //    default:
                //        Console.WriteLine("잘못 입력하셨습니다");
                //        break;
                //}
            }
            // ----------------------------------------while문-------------------------------------------------
            //int count = 5;
            //while (count-- > 0) //(count-- > 0)과 (--count > 0)은 반복횟수가 다르다. 전자는 논리평가 이후 증감연산이 들어간다
            //{

            //    Console.WriteLine($"{count}");

            //}
            //Console.Write("몇 회를 반복하시겠습니까? : ");
            //int count = int.Parse(Console.ReadLine());
            //int i = 0;
            //while(count > i) //변수 i를 추가했고 i의 값이 변하므로 이를 이용하여 연산자를 하나 줄일 수 있다.count--가 필요없음
            //{
            //    Console.WriteLine($"{++i}");

            //}
            //Console.WriteLine("5개의 정수를 합산하겠습니다.");
            //int count = 0;
            //int stack = 0;
            //while(count++ < 5)
            //{
            //    Console.Write("{0}번째 정수 : ", count);
            //    stack += int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("합은 {0}입니다", stack);

            //-----------------------------------------do ~ while문-----------------------------------------------
            /* do{
             * 
             * } while(조건식);  do~while문만 끝에 세미콜론을 쓰는 특이한 제어문
             */
            //Console.WriteLine("5개의 정수를 합산하겠습니다.");
            //int count = 0;
            //int stack = 0;
            //do
            //{
            //    Console.Write("{0}번째 정수 : ", count+1);
            //    stack += int.Parse(Console.ReadLine());
            //} while (++count < 5);
            //--------------------------------------------for문------------------------------------------------------

            //for(int no = 1; no <= 10; no++)//초기화식 -> {조건식확인 -> (참)명령실행 -> 증감연산 -> 조건식 확인 -> (참)명령실행}
            //{
            //    Console.WriteLine("no = " + no.ToString());
            //}
            //int oddSum = 0;

            //for(int i=0; i<10; i++)
            //{
            //    Console.Write("{0}번째 정수 : ", i+1);
            //    int num = int.Parse(Console.ReadLine());
            //    if (i%2 == 0)
            //    {
            //        oddSum += num;
            //    }
            //}
            //Console.WriteLine("홀수번째 총합은 {0}입니다", oddSum);

            //Random rd = new Random();
            //for(int n = 1; n < 3; n++)
            //{
            //    for (int no = 1; no <= 10; no ++)
            //    {
            //        if(no <= 2)
            //        {
            //            continue;
            //        }
            //        Console.WriteLine("value = " + rd.Next());
            //    }
            //}
            //Console.Write("반복횟수를 입력하세요 : ");
            //int count = Convert.ToInt32(Console.ReadLine());
            //Console.Write("출력 문자열을 입력하세요 : ");
            //string str = Console.ReadLine();
            ////결과1
            //for(int i = 0; i<count; i++)
            //{
            //    Console.WriteLine(str[i]);
            //}
            ////결과2                           만약 1열의 문자열 이후의 인덱스를 가진 문자열을 출력하고싶다면 i 를 분기문에 이용하자
            //for(int i = 0; i < count; i++)
            //{
            //    for(int j = 0; j < str.Length; j++)
            //    {
            //        Console.Write(str[j]);
            //    }
            //    Console.WriteLine();
            //}
            ////결과3 - 1                       '동일' 반복문에서 반복해야할 명령이 바뀐다면 if문, switch문을 유념하자.
            //for (int i = 1; i <= count; i++)
            //{
            //    for (int j = 0; j < str.Length; j++) 
            //    {
            //        if (j < str.Length - i)
            //        {
            //            Console.Write(" ");
            //        }
            //        else
            //        {
            //            Console.Write(str[j]);
            //        }
            //    }
            //    Console.WriteLine();
            //}
            ////결과3 - 2------------------------------------------+++++++++++++++++++++++++++++++++++++++++++++++++++
            //for (int i = 1; i <= count; i++)
            //{
            //    for (int j = 0; j < str.Length - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j =str.Length - i; j<str.Length ; j++)           //P)문자열 배열의 인덱스가 늘어나야하는데 for문 지역변수가 감소
            //    {                                                         //S)for문 지역변수를 임의 지점부터 시작시킴  
            //        Console.Write(str[j]);
            //    }
            //    Console.WriteLine();
            //}
            ////결과4
            //for (int i = 1; i <= count; i++)
            //{
            //    for (int j = 0; j < str.Length; j++)
            //    {
            //        if (j < str.Length - i)
            //        {
            //            Console.Write(" ");
            //        }
            //        else
            //        {
            //            Console.Write(str[j]);
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 1; i <= count-1; i++)
            //{
            //    for (int j = 0; j < str.Length; j++)
            //    {
            //        if(j < i)
            //        {
            //            Console.Write(" ");
            //        }
            //        else
            //        {
            //            Console.Write(str[j]);
            //        }
            //    }
            //    Console.WriteLine();
            //}
            Lab2.Assignment();





        }
    }
}
