using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program //
    {
        /* <열거형>
         * 1.열거형 자료구조를 만든다
         * 2.열거형 자료명으로 변수 선언하여 사용한다
         */
        // enum eTribe
        //{
        //    임프 ,
        //    프레데터,
        //    에일리언 ,
        //    고스트
        //}


        static void Main(string[] args)
        {

            {//    { 
             //    /* <부호를 포함한 이진수에서 음수 표현하기>
             //     * EX) -15 를 표현하기 위해 우선 -1 이 1111 1111 임을 고려
             //     *      14를 더 빼주면 되므로, 14의 이진수인 0000 1110 을 빼준다 => 1111 0001
             //     */
             //    //실수 자료형은 근삿값이기 때문에 논리연산 == 은 사용하지 비교에 사용하지 않는다.
             //     }
             //    eTribe Etri = eTribe.고스트;

                //    Console.WriteLine("지정한 종족은 {0}입니다",(eTribe)2);
            }
            {
                //int a = 123;
                //long b = a;
                //float c = (float)a / 5;

                //int d = 12345;
                //string f = d.ToString() + 11;

                //int g = int.Parse("12345");
                //int h = Convert.ToInt32("12345");
                //float i = float.Parse("54.321");

                //Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
                //Console.WriteLine("d = {0}, f = {1}", d + 11, f);
                //Console.WriteLine("g = {0}, h = {1}, i = {2}", g + 12, h + 21, i + 3.14);
            }
            {// % 연산의 가장 큰 특징 우연산항보다 큰 수가 나올 수가 없음
             //int su1 = 10;
             //int su2 = 13;

                //Console.WriteLine("su1 % su2 = {0}", su1 % su2);
                //Console.WriteLine("su2 % su1 = {0}", su2 % su1);
                ////su1++;
                ////--su2;
                ////Console.WriteLine("su1++ = {0}, --su2 = {1}", su1++, --su2);
                //Console.WriteLine("su1 = {0}", su1);
                //Console.WriteLine("su1 = {0}", ++su1);
                //Console.WriteLine("su1 = {0}", su1++);
                //Console.WriteLine("su1 = {0}", su1);
                //Console.WriteLine("su1 < su2 = {0}", su1 < su2);
                //object result = (su1 > su2) ? true : false;
                //Console.WriteLine("(su1 > su2)? = {0}", result); // 삼항연산자의 참거짓 자료형은 같아야됨

                ////논리형 논리연산자 논리형
                //Console.WriteLine("true || false = {0}", su1 != su2 || su1 > su2);
            }
            //128 64  32  16   8   4   2   1
            // 0   0   0   0   0   0   0   0
            // 0   0   1   1   0   1   1   1 _ 55
            // 0000 0011 0111 0000 _ 512 + 256 + 64 + 32 + 16 == 880
            // 0000 0000 0000 0110 _ 6
            //Console.WriteLine("55 << 4 = {0}", 55 << 4);
            //Console.WriteLine("55 >> 3 = {0}", 55 >> 3);

            //128 64  32  16   8   4   2   1
            // 0   0   0   0   0   0   0   0
            // 0   0   1   1   0   1   1   1 _ 55
            // 1   0   1   1   0   0   0   1 _ 177
            // 0   0   1   1   0   0   0   1 _ 49
            // 0   0   1   1   1   1   0   0 _ 61
            // 0   0   1   1   1   1   1   1 _ 63
            //Console.WriteLine("55 & 177 = {0}", 55 & 177);
            //Console.WriteLine("55 | 61 = {0}", 55 | 61);

            // 0   0   1   1   0   1   1   1 _ 55
            // 1   1   0   0   1   0   0   0 _ -56

            //Console.WriteLine("~55 = {0}", ~55);
            //XOR연산
            // F  F    F
            // F  T    T
            // T  F    T
            // T  T    F
            // 0   0   1   1   0   1   1   1 _ 55
            // 1   0   0   0   0   0   1   0 _ 130
            // 1   0   1   1   0   1   0   1 _ 181
            //Console.WriteLine("55 ^ 130 = {0}", 55 ^ 130);
            //int su1=10;
            //Console.WriteLine("su 1 = {0}", su1);
            //su1 += 3;
            //Console.WriteLine("su 1 = {0}", su1);

            Lab1.Assignment();
           
        }
    }
}
