using System;

namespace LearnCS5
{
    public  class WorkMan : BasicNeeds
    {
        string rank;

        public void WhatTime(int nowTime)
        {
            TimeSchedule = nowTime;

            if (TimeSchedule < 7 || TimeSchedule == 23 || TimeSchedule == 24)
            {
                Sleep();
            }
            else if (TimeSchedule == 7)
            {
                WakeUp();
                Wash();
            }
            else if (TimeSchedule > 7 && TimeSchedule < 8)
            {
                Blackfirst();
            }
            else if (TimeSchedule >= 8 && TimeSchedule < 9)
            {
                GotoBusiness();
            }
            else if (TimeSchedule >= 9 && TimeSchedule < 20)
            {
                if (TimeSchedule >= 12 && TimeSchedule < 13)
                {
                    Lunch();
                }
                else if(TimeSchedule >=14 && TimeSchedule < 16)
                {
                    DoConference();
                }
                else if (TimeSchedule >= 17 && TimeSchedule < 18)
                {
                    Dinner();
                }
                else
                {
                    WorkHard();
                }
            }

            else if (TimeSchedule >= 20 && TimeSchedule < 22)
            {
                DoOutting();
            }
            else if (TimeSchedule >= 22 && TimeSchedule < 23)
            {
                ExitBusiness();
            }
            else if (TimeSchedule >= 23 && TimeSchedule <= 24)
            {
                Sleep();
            }
            else if (TimeSchedule > 24)
            {
                Console.WriteLine("잘못입력하셨습니다. 다시 입력해주세요.");
            }
        }

        void GotoBusiness()
        {
            Console.WriteLine("출근을 한다");
        }
        void WorkHard()
        {
            Console.WriteLine("업무를 본다");
        }
        void WorkHardLately()
        {
            Console.WriteLine("야근을 한다");
        }
        void DoConference()
        {
            Console.WriteLine("회의를 한다");
        }
        void ExitBusiness()
        {
            Console.WriteLine("퇴근을 한다");
        }
        void DoOutting()
        {
            Console.WriteLine("회식을 한다");
        }
    }
}
