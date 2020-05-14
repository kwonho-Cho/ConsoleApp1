using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS5
{
    class Person
    {
        string _Name;
        public bool _IsSex;

        string _txtGender;


        //Person._myName = "홍길동" //설정
        //string nm = Person._myName; //반환
        public string _myName
        {
            get { return "잘난 " + _Name; }
            set { _Name = value; }
        }
        public bool _gender
        {
            get { return _IsSex; }
            set {
                SettingGenderText(value);
                _IsSex = value; }
        }
        public string _genderText
        {
            get { return _txtGender; }
           
        }

        //생성자 초깃값
        public Person()
        {
            //Console.WriteLine("생성자가 호출 되었습니다!!");
            _Name = "홍길동";
            _IsSex = true;
            
        }

        //생성자 초기화
        public Person(string name, bool gender)
        {
            _Name = name;
            _gender = gender;
            
        }
        //stack메모리는 보통 cpu프로세스당 1mb, 스레드당 1mb.
        //가비지컬렉터는 사용되지않는 스택메모리를 제거하며 참조하고있는 힙메모리도 같이 제거한다
        //가비지컬렉터는 3개의 세대를 가지고, 0세대 -> 1세대 -> 2세대 메모리순으로 적재가 완료될시 정보를 제거 및 이동시킨다.

        //소멸자는 소멸을 하면서 어떤 정보를 넘겨줘야할 때 이용한다
        ~Person()
        {
            Console.WriteLine("소멸자가 호출 되었습니다.");
        }

        //설정 함수(초기화 이후 개별 변수의 설정을 변화시킬때)
       
        //초기화 함수(변수 다수의 값을 초기화할떄)
        public void InitData(string name, bool gender)
        {
            _Name = name;
            _IsSex = gender;

            //gender변수가 반복해서 쓰일경우 받아오는 부분에서 결정시켜준다

            
            //if (_IsSex)
            //{
            //    _txtGender = "남자";
            //}
            //else
            //{
            //    _txtGender = "여자";
            //}
        }
        //public void SetGender(bool gender)
        //{
        //    _IsSex = gender; 
        //    SettingGenderText(gender);
        //}
        //public bool GetGender()
        //{
        //    return _IsSex;
        //}
        public void SettingGenderText(bool gender)
        {
            if (gender)
            {
                _txtGender = "남자";
            }
            else
            {
                _txtGender = "여자";
            }
        }
        public string GettingGenderText()
        {
            return _txtGender;
        }


        public void ShowInfo()
        {
            Console.WriteLine("내 이름은 {0}입니다.", _myName);
            Console.WriteLine("{0}입니다", _txtGender);

        }

        public void Laugh()
        {
            if (_IsSex)
            {
                Console.WriteLine("하하하");
            }
            else
            {
                Console.WriteLine("호호호");
            }
        }

    }
}
