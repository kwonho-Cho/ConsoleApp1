using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS5
{
    public static class Question
    {
        public static int select = 0;
        public static int[] typeofTime = new int[2];
        public static void AskUsersJop()
        {

            InputNumberToString("1.학생\n2.직장인\n당신은 어느 직종이십니까 ? : ", out select );
        }
        public static void AskUsersDoing()
        {

            if (select == 1 || select ==2)
            {
                InputNumberToString("어느 시간에 무슨 일을 하고있는지 알고 싶으신가요 : ", out typeofTime[select - 1]);
            }
            else
            {
                Console.WriteLine("잘못 입력하셨습니다. 다시 입력해주세요.");
            }
            
            
        }
        static void InputNumberToString(string explain, out int result)
        {
            while (true)
            {
                Console.Write(explain);
                if (!int.TryParse(Console.ReadLine(), out result))
                    Console.WriteLine("숫자형 문자열을 입력하지 않았습니다.");
                else
                    break;
            }

        }
    }
}
