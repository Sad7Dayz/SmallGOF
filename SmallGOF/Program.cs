/**
 * https://codepump.tistory.com/34?category=672020
 * 브릿지 패턴
 *          
 * 구현부에서 추상층을 분리하여 각자 독립적으로 변형할 수 있게 함
 * 클래스의 내용과 클래스에서 처리 하는 일이 자주 변화할 때 유용
 * 브릿지 패턴은 종종 클래스 어댑터 패턴을 사용해서 구현되기도 함
 * 
 **/
using Bridge;
using System;

namespace SmallGof
{
    class Program
    {
        static void Main(string[] args)
        {
            Abstraction ab = new RefinedAbstraction();

            ab.Implementor = new ConcreteImplementorA();
            ab.Operation();

            ab.Implementor = new ConcreteImplementorB();
            ab.Operation();

            Console.ReadKey();
        }
    }
}
