using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Lab1
    {

        public static void Assignment()
        {
            ////과제1
            //Console.Write("출생년도를 입력하세요 : ");
            //int year = int.Parse(Console.ReadLine());
            //int age = 2020 - year + 1;
            //Console.WriteLine("당신의 나이는 {0}세 입니다.",age);
            //Console.WriteLine();

            ////과제2
            //Console.Write("가로길이 : ");
            //int horizontal = Convert.ToInt32(Console.ReadLine());
            //Console.Write("세로길이 : ");
            //int vertical = Convert.ToInt32(Console.ReadLine());
            //int area = horizontal * vertical;
            //Console.WriteLine("면적은 {0} 입니다", area);


            //문제1
            //Console.Write("기준이 되는 정수를 입력하세요 : ");
            //int stdInteger = Convert.ToInt32(Console.ReadLine());
            //Console.Write("쉬프트연산 할 정수를 입력하세요 : ");
            //int calcInteger = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine();
            //string str = null;
            //str = (calcInteger >= 10) ?
            //    string.Format("{0} << {1} = {2}", stdInteger, calcInteger, stdInteger << calcInteger)
            //    : string.Format("{0} >> {1} = {2}", stdInteger, calcInteger, stdInteger >> calcInteger);
            //Console.WriteLine(str);

            ////문제2
            //Console.Write("문자를 입력하세요 : ");
            //string input = Console.ReadLine();
            //int codeValue = input[0];
            //Console.WriteLine($"{codeValue}");

            //Console.Write("국어점수를 입력하세요 : ");
            //int scoreKor = Convert.ToInt32(Console.ReadLine());
            //Console.Write("영어점수를 입력하세요 : ");
            //int scoreEng = Convert.ToInt32(Console.ReadLine());
            //Console.Write("수학점수를 입력하세요 : ");
            //int scoreMath = Convert.ToInt32(Console.ReadLine());
            //int scoreTotal = scoreKor + scoreEng + scoreMath;
            //float scoreAverage = scoreTotal / 3.0f;
            //Console.WriteLine("세 과목의 총점은 {0}점입니다. 세 과목의 평균은 {1:F1}점 입니다", scoreTotal, scoreAverage);

            //Console.WriteLine();

            //Console.Write("집의 평 수를 입력하세요 : ");
            //float areaPyung = Convert.ToSingle(Console.ReadLine());
            //float areaM2 = areaPyung * 3.305f;
            //Console.WriteLine("{0}평은 {1:F2}제곱미터 입니다.", areaPyung, areaM2);

            //Console.Write("몇 초를 입력하시겠습니까? : ");
            //ulong sec = ulong.Parse(Console.ReadLine());
            //ulong min = sec / 60;
            //ulong hour = min / 60;
            //ulong days = hour / 24;
            //Console.WriteLine("{0}초는 {1}분 {2}시간 {3}일 입니다", sec, min, hour, days);


            //Console.WriteLine();

            //9
            {//Console.Write("파일의 용량을 입력하세요(기가바이트 단위) : ");
             //int byteGiga = int.Parse(Console.ReadLine());
             //int bytesMega = 1024 * byteGiga;
             //int bytesKilo = 1024 * bytesMega;
             //uint bytes = (uint)(1024 * bytesKilo);
             //Console.WriteLine("입력하신 용량은 {0:#,###}메가바이트이고, {1:#,###}킬로바이트입니다." +
             //    "바이트로는 {2:#,###}바이트입니다.", bytesMega, bytesKilo, bytes );
            }

            //10
            {
                //Console.Write("집의 면적을 입력하세요 : ");
                //float areaM2 = float.Parse(Console.ReadLine());
                //float areaPyung = areaM2 / 3.3f;
                //Console.Write("당신의 집은 {0:F1}평입니다.", areaPyung);
                //if (areaPyung > 34.0f)
                //{
                //    Console.WriteLine("부자시군요!!!");
                //}
                //else
                //{
                //    Console.WriteLine();
                //}
            }


            //11
            {//Console.Write("시간을 입력하세요(초단위로 입력) : ");
            //int sec = Convert.ToInt32(Console.ReadLine());
            //Console.Write("1.날\n2.시간\n3.분\n어떤 시간으로 변환하겠습니까 : ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //switch (num)
            //{
            //    case 1:
            //        float days = sec / 86400.0f;
            //        Console.Write("변환된 날은 {0}일 입니다", days);
            //        break;
            //    case 2:
            //        float hour = sec / 3600.0f;
            //        Console.Write("변환된 시간은 {0}시간 입니다.", hour);
            //        break;
            //    case 3:
            //        float min = sec / 60.0f;
            //        Console.Write("변환된 분은 {0}분 입니다.", min);
            //        break;
            //    default:
            //        break;
            //}
             }

            //12
            {//Console.Write("정수를 입력하세요 : ");
             //int finish = int.Parse(Console.ReadLine());
             //int total = 0;
             //if (finish >= 1)
             //{
             //    for (int i = 1; i <= finish; i++)
             //    {
             //        total += i;
             //    }
             //    Console.WriteLine("1~{0}까지의 총합은 {1}입니다", finish, total);
             //}
             //else
             //{
             //    Console.WriteLine("종료합니다!!");
             //}
            }

            //13
            {//Console.Write("국어점수를 입력하세요 : ");
             //int scoreKor = int.Parse(Console.ReadLine());
             //Console.Write("수학점수를 입력하세요 : ");
             //int scoreMath = int.Parse(Console.ReadLine());
             //Console.Write("영어점수를 입력하세요 : ");
             //int scoreEng = int.Parse(Console.ReadLine());
             //int scoreTotal = scoreKor + scoreMath + scoreEng;
             //float scoreAverage = scoreTotal / 3.0f;
            }

            //14 (+비트체크하는 방법도 생각해보기)

            {//Console.Write("첫번째 숫자를 입력하세요 : ");
             //int num1 = int.Parse(Console.ReadLine());
             //Console.Write("두번째 숫자를 입력하세요 : ");
             //int num2 = int.Parse(Console.ReadLine());
             //Console.Write("세번째 숫자를 입력하세요 : ");
             //int num3 = int.Parse(Console.ReadLine());

                //Console.WriteLine("1번 : 3개의 숫자 중 적어도 두 수의 값이 같다.\n" +
                //    "2번 : 3개의 숫자 중 적어도 두수의 크기가 모두 50보다 크다\n" +
                //    "3번 : 3개의 숫자 중 어떤 두 수의 합이 나머지 하나의 숫자와 같다\n" +
                //    "4번 : 3개의 숫자 중 어떤 하나의 수로 다른 두 수를 나누면 나누어 떨어진다.");

                //string condition1 = null, condition2 = null, condition3 = null, condition4 = null;


                //if (num1 == num2 || num1 == num3 || num2 == num3)
                //{
                //    condition1 = "1번 ";
                //}
                //if ((num1 % 10 > 5) && (num2 % 10 > 5) || (num1 % 10 > 5) && (num3 % 10 > 5) || (num2 % 10 > 5) && (num3 % 10 > 5))
                //{
                //    condition2 = "2번 ";
                //}
                //if ((num1 + num2 == num3) || (num1 + num3 == num2) || (num2 + num3 == num1))
                //{
                //    condition3 = "3번 ";
                //}
                //if ((num2 % num1 == 0 && num3 % num1 == 0) || (num1 % num2 == 0 && num3 % num2 == 0) || (num2 % num3 == 0 && num1 % num3 == 0))
                //{
                //    condition4 = "4번 ";
                //}

                //if (condition1==null && condition2 == null && condition3 == null && condition4 == null)
                //{
                //    Console.WriteLine("만족된 조건이 없습니다");
                //}
                //else
                //{
                //    Console.WriteLine("입력하신 세 개의 숫자는 {0}{1}{2}{3}을 만족합니다.", condition1, condition2, condition3, condition4);
                //}
            }


            //15
            {
                Console.Write("반복 횟수를 입력하세요 : ");
                int count = int.Parse(Console.ReadLine());
                int maxNum = 0, minNum = 0;

                for (int i = 1; i <= count; i++)
                {
                    Console.Write("{0}번 정수 : ", i);
                    int number = int.Parse(Console.ReadLine());
                    if (number >= maxNum)
                    {
                        maxNum = number;
                    }
                    else if ()
                    {

                    }

                }
                Console.Write("입력 수 중 가장 큰 수는 {0}입니다", maxNum);
                Console.Write("입력 수 중 가장 작은 수는 {0}입니다", minNum);
            }

        }
    }
}
