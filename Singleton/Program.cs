/**
 * 싱글턴
 * 인스턴스가 하나 뿐인 객체를 만들 수 있게 해주는 패턴
 * 해당 클래스의 인스턴스가 하나만 생성 됨
 * 어디서든 인스턴스에 접근 가능
 * 스레드 풀, 캐시, 대화상자, 사용자 설정, 디바이스 드라이버 등 클래스의 객체가
 * 어플리케이션에서 오직 하나만 생성되는 경우 사용.
 * 
 **/

using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            OldSingleton os1 = OldSingleton.Instance();
            OldSingleton os2 = OldSingleton.Instance();
            os1.Name = "This is old singleton class!!";
            Console.WriteLine(os2.Name);

            NewSingleton ns1 = NewSingleton.Instance();
            NewSingleton ns2 = NewSingleton.Instance();
            ns1.Name = "This is new singleton class!!";
            Console.WriteLine(ns2.Name);

            OptimizeSingleton ops1 = OptimizeSingleton.Instance();
            OptimizeSingleton ops2 = OptimizeSingleton.Instance();
            ops1.Name = "This is new C# optimize singleton class!!";
            Console.WriteLine(ops2.Name);

            Console.ReadKey();
        }
    }
}
