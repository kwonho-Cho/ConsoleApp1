using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calclate
{
    //-------------------------------------------------------정적-------------------------------------------------------

    //클래스 안에서 정적 필드와 정적 함수를 설정하면 클래스의 객체생성을 하지않고 접근하여 사용이 가능하다

    //class Numbers
    //{
    //    public static int a;
    //    public static float b;
    //}

    class Arithmatics
    {
        //정적변수
        public static int nNum;
        public static float fNum;


        public int _nNum1;
        public float _fNum1;

        //정적함수
        public static int Plus(int a, int b)
        {
            return a + b;
        }
        public static int Minus(int a, int b)
        {
            return a - b;
        }
        public float Plus(float a, float b)
        {
            return a + b;
        }
    }
}
