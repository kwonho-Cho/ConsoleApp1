using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS3
{
    class Program
    {
        enum ETypeSubject
        {
            KOR = 0,
            ENG,
            MATH,


            MAX
        }
        enum ETypeResult
        {
            KOR = 1,
            ENG,
            MATH,
            ALL
        }

        static void Main(string[] args)
        {

            // -------------------------------------------<배열>-----------------------------------------------------------
            { int[] aaa = new int[3] { 1, 2, 3 };
                int[] bbb = new int[] { 1, 2, 3, 4, 5 };
                int[] ccc = { 1, 2, 3, 4 };

                //aaa = { 10, 11, 12 }; // 이런 대입은 안됨.
                aaa[0] = 10;
                for (int n = 0; n < aaa.Length; n++)
                {
                    Console.WriteLine("aaa[{0}] = {1}", n, aaa[n]);
                }
                Console.WriteLine("<==============================================>");
                for (int n = 0; n < bbb.Length; n++)
                {
                    Console.WriteLine("bbb[{0}] = {1}", n, bbb[n]);
                }
                Console.WriteLine("<==============================================>");
                //for (int n= 0; n<ccc.Length; n++)
                //{
                //    Console.WriteLine("ccc[{0}] = {1}", n, ccc[n]);
                //}
                int idx = 0;
                foreach (int item in ccc) //foreach는 배열&컬렉션에서 쓰임
                {
                    //item = idx * 10; 불가능 ~ foreach 임의 변수에는 값을 할당할 수 없음
                    Console.WriteLine("ccc[{0}] = {1}", idx++, item);
                }
            }

            {
                //    int[] arr;
                //    int count = 0;
                //    Console.Write("몇 개의 자원을 가지는 배열을 만들겠습니까? : ");
                //    count = int.Parse(Console.ReadLine());
                //    arr = new int[count];
                //    for (int i = 0; i < count; i++)
                //    {
                //        arr[i] = (i * 2) + 1;
                //    }
                //    for (int i = 0; i < arr.Length; i++)  //내가 사용하려는 변수의 정보를 이용해서 구현하는게 최선(arr.Length) count가 변할 수가 있음
                //    {
                //        Console.WriteLine("arr[{0}] = {1}", i, arr[i]);
                //    }

                //    Console.ReadLine();
            }
            // -----------------------------------------<2차원 배열>--------------------------------------------------------
            {
                ////int[,] aaa = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
                ////int[,] bbb = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
                ////int[,] ccc = {{ 1,2,3}, { 4,5,6} };

                ////int[,] ddd = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
                ////for(int i = 0; i < ddd.GetLength(0); i++)
                ////{
                ////    for(int j = 0; j<ddd.GetLength(1); j++)
                ////    {
                ////        Console.WriteLine("ddd[{0},{1}] = {2}", i, j, ddd[i, j]);
                ////    }
                ////}

                //Random rd = new Random();
                //int[,] ScoresToStudents = new int[5, (int)ETypeSubject.MAX];
                //float[] resultAvers = new float[(int)ETypeResult.ALL];
                //bool isExit = false;
                //int alltotal = 0, total = 0;

                //for (int i = 0; i < ScoresToStudents.GetLength(0); i++)
                //{
                //    for (int j = 0; j < ScoresToStudents.GetLength(1); j++)
                //    {
                //        ScoresToStudents[i, j] = rd.Next(45, 101);
                //        //switch (j)
                //        //{
                //        //    case 0:
                //        //        resultAvers[0] += ScoresToStudents[i, j];
                //        //        break;
                //        //    case 1:
                //        //        resultAvers[1] += ScoresToStudents[i, j];
                //        //        break;
                //        //    case 2:
                //        //        resultAvers[2] += ScoresToStudents[i, j];
                //        //        break;
                //        //    default:
                //        //        break;
                //        //}
                //    }
                //}
                ////for (int i = 0; i < resultAvers.Length - 1; i++)
                ////{
                ////    resultAvers[3] += resultAvers[i];
                ////}

                //for (int j = 0; j < ScoresToStudents.GetLength(1); j++)
                //{
                //    total = 0;
                //    for (int i = 0; i < ScoresToStudents.GetLength(0); i++)
                //    {
                //        total += ScoresToStudents[i, j];
                //    }
                //    alltotal += total;
                //    resultAvers[j] = (float)total / ScoresToStudents.GetLength(0);
                //}
                //resultAvers[(int)ETypeResult.ALL - 1] = (float)alltotal / ScoresToStudents.Length;

                //while (!isExit)
                //{
                //    Console.Write("1.국어 평균 점수\n" +
                //    "2.영어 평균 점수\n" +
                //    "3.수학 평균 점수\n" +
                //    "4.전체 평균 점수\n무엇을 출력하시겠습니까 : ");
                //    int num = Convert.ToInt32(Console.ReadLine());

                //    for(int n = 0; n< ScoresToStudents.Length; n++)
                //    {
                //        int idx = n % ScoresToStudents.GetLength(1); //%연산자는 우항미만의 인덱스가 필요할떄 용이
                //        int idy = n / ScoresToStudents.GetLength(1);

                //        Console.WriteLine("{0}번째 학생의 {1}점수 : {2}", idy + 1, (ETypeSubject)idx, ScoresToStudents[idy, idx]);
                //    }

                //    switch (num)
                //    {
                //        case (int)ETypeResult.KOR:
                //            Console.WriteLine("학생들의 국어 평균 점수는 {0:F2}입니다", resultAvers[num - 1]);
                //            break;
                //        case (int)ETypeResult.ENG:
                //            Console.WriteLine("학생들의 영어 평균 점수는 {0:F2}입니다", resultAvers[num - 1]);
                //            break;
                //        case (int)ETypeResult.MATH:
                //            Console.WriteLine("학생들의 수학 평균 점수는 {0:F2}입니다", resultAvers[num - 1]);
                //            break;
                //        case (int)ETypeResult.ALL:
                //            Console.WriteLine("학생들의 전 과목 평균 점수는 {0:F2}입니다", resultAvers[num - 1]);
                //            break;
                //        default:
                //            Console.WriteLine("잘못 입력하셨습니다.");
                //            break;
                //    }

                //}
            }

            // -----------------------------------------<가변길이 배열>-----------------------------------------------------

            {
                //int[][] aaa = new int[3][];
                //aaa[0] = new int[5] { 1, 2, 3, 4, 5 };
                //aaa[1] = new int[] { 10, 20, 30 };
                //aaa[2] = new int[] { 100, 200, 300, 400 };

                float[][] studentsGrade = new float[4][];
                Random rd = new Random();
                int[] classStudents = new int[4];

                Console.Write("1반 학생 수를 입력하세요 : ");
                classStudents[0] = int.Parse(Console.ReadLine());
                Console.Write("2반 학생 수를 입력하세요 : ");
                classStudents[1] = int.Parse(Console.ReadLine());
                Console.Write("3반 학생 수를 입력하세요 : ");
                classStudents[2] = int.Parse(Console.ReadLine());
                Console.Write("4반 학생 수를 입력하세요 : ");
                classStudents[3] = int.Parse(Console.ReadLine());

                for (int i = 0; i < classStudents.Length; i++)
                {
                    studentsGrade[i] = new float[classStudents[i]]; // 가변배열에서 배열의 배열을 생성하는 방법
                    for (int j = 0; j < studentsGrade[i].Length; j++)
                    {
                        studentsGrade[i][j] = (float)rd.Next(5000, 10001);

                        Console.WriteLine("{0}반 {1}번째 학생의 평균점수는 {2:F2}입니다.", i + 1, j + 1, studentsGrade[i][j] / 100);
                    }
                    Console.WriteLine("--------------------------------------");

                }
            }

        }
    }
}
