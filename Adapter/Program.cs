/**
 * 어댑터 패턴
 * 
 * 클래스의 인터페이스를 사용자가 원하는 다른 인터페이스로 변환하는 디자인 패턴
 * 서로 호환성이 없는 클래스들 간의 인터페이스를 생성하여 함께 동작할 수 있도록 한다.
 * 
 **/
using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Target target = new Adapter();
            target.Request();

            Console.ReadKey();
        }
    }
}
