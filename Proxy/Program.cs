/**
 * 
 * 프록시 
 * 대리자로써 작업 수행을 요청하면 처리 후 그결과를 알려주는 패턴
 * 클래스안에 처리 과정이 복잡하고 리소스를 많이 차지할 경우 클래스를 생성하여 처리
 * 접근 제한을 둘 수 있기 때문에 원격제어 프로그램 작성시에도 유용
 * 네트워크 연결, 메모리의 객체, 복제할 수 없거나 자주 사용되는 리소스 등의 인터페이스등에 사용
 * 
 **/

using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Proxy proxy = new Proxy();
            proxy.Request();

            Console.ReadKey();
        }
    }
}
