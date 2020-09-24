/**
 * 퍼사드 패턴
 * 클래스 라이브럴리 같은 커다란 코드를 사용하기 위한 간략한 인터페이스를 제공
 * 라이브러리 외부 코드가 라이브러리의 안쪽 코드에 의존하는 일을 감소시킨다.
 * 소프트웨어 라이브러리를 쉽게 이해 할수 있게 해준다.
 * 대부분의 외부 코드에서 퍼사드를 이용하기 때문에 시스템을 개발하는데 있어 유연성이 향상된다.
 * 
 **/
using System;

namespace Facede
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();
            facade.MethodA();
            facade.MethodB();

            Console.ReadKey();
        }
    }
}
