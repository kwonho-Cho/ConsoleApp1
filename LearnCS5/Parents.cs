using System;

namespace LearnCS5
{
    class Parents
    {
        int age;
        string name;

        public int _age
        {
            get { return age; }
            set { age = value; }
        }
        public string _name
        {
            get { return name; }
        }

        public Parents(string name, int age)
        {
            InitData(name, age);
        }

        //protected는 상속관계에 있는 상대에게도 보임
        protected void InitData(string name, int age)
        {
            //여기서 this = '이 클래스'를 의미. 동명의 변수를 사용했거나, 명확하게 할당하는 바를 명시하고 싶은 경우 사용
            this.name = name;
            this.age = age;
            
        }
        public void ShowBase()
        {
            Console.WriteLine("{0}세 {1}입니다.", _age, _name);
        }
    } 
}
