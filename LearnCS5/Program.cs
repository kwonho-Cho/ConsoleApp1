using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calclate;


namespace sample
{
    class Arithmatics
    {
        public static int Plus(int a, int b)
        {
            return a + b;
        }
    }
}

namespace LearnCS5
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //    Person man = new Person();
                //    man._Name = "김철수";
                //    man._IsSex = true;
                //    man.Laugh();

                //    Person girl = new Person();
                //    girl._Name = "이영희";
                //    girl._IsSex = false;
                //    girl.Laugh();

                //Person man = null;
                //man = new Person("홍길동", true);
                ////man.ShowInfo();
                ////man._myName = "세종";
                ////man._myName += " 이도";
                ////man.ShowInfo();
                //Console.WriteLine("{0}은 성별이 {1}인 사람입니다", man._myName, man._genderText);

                //객체를 생성하고 할당되는 메모리와 정적(static)변수가 사용되는 메모리는 별개. c#에서는 전역(global)의 개념

                //Arithmatics arisu1 = new Arithmatics();
                //Arithmatics.nNum = 11;
                //arisu1._nNum1 = 22;
                //Console.WriteLine("숫자 = {0}", Arithmatics.nNum);
                //Console.WriteLine("숫자 = {0}", arisu1._nNum1);
                //sample.Arithmatics aaa = new sample.Arithmatics();

                //using으로 지시하는 네임스페이스가 아니라면 네임스페이스까지 써서 구현해줘야한다.

                //using으로 지시하는 서로 다른 네임스페이스에서 동명의 클래스등을 포함하고 있을 경우, 무엇을 쓰고자하는지 모호하기때문에
                //컴파일러에서 에러가 발생한다.
            }

            { 
            //Student student = new Student();
            //WorkMan workMan = new WorkMan();


            //Question.AskUsersJop();
            //while (true)
            //{
            //    Question.AskUsersDoing();

            //    if(Question.typeofTime[Question.select-1] == 999)
            //    {
            //        break;
            //    }

            //    switch (Question.select)
            //    {
            //        case 1:
            //            student.WhatTime(Question.typeofTime[Question.select-1]);
            //            break;
            //        case 2:
            //            workMan.WhatTime(Question.typeofTime[Question.select-1]);
            //            break;
            //    }
            //}


            //WorkMan worker = new WorkMan();
            //Student stu = new Student();

            //eTypeJob job = Question.AskJob();
            //switch (job)
            //{
            //    case eTypeJob.Student:
            //        Question.WhatTime(job, stu);
            //        break;
            //    case eTypeJob.OfficeWorkers:
            //        Question.WhatTime(job, worker);
            //        break;
            //}
        }

            Child man = new Child("홍길동", 18, 171.4f, 71.2f);
            //protected InitData의 경우엔 상속받는 Child클래스 내부에서 마음껏 사용할 수 있지만, Child내에 있는 함수로 취급되지 않기때문에
            //객체를 생성해서 불러 올 수 없다.
           // man.Initialize("홍길동", 18, 171.4f, 71.2f);
            man.ShowInfo();
            //man.ShowBase();
        }
        
        //클래스에는 기본생성자가 내재되어있다. 다만, 프로그래머가 생성자를 설정할 경우가 우선되며 그에따라 내재되는 기본생성자는 무시된다

        //------------------------------------------------------프로퍼티---------------------------------------------------

        //멤버변수를 public처럼 편하게 사용하고 싶어질경우, Get/Set함수를 사용하는것의 대용. 훨씬 간편
        //내용에 함수같은 제어문을 구현할 수 있으나, 프로퍼티는 변수같이 사용을 하는것이 특징


        //----------------------------------------------------네임스페이스-------------------------------------------------

        //성격이나 하는 일이 비슷한 클래스, 구조체, 인터페이스, 델리게이트, 열거형식등을 하나의 이름아래에 묶는 일을 한다.
        //다른 네임스페이스를 지시할때는 using 을 이용. using을 쓰지 않는다면 네임스페이스까지 일일이 써줘야함(System.Console.WriteLine)
        
    }
}
