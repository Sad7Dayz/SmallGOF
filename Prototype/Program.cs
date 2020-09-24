/**
 * 프로토타입
 * 생성할 객체들의 타입이 프로토타입인 인스턴스로부터 결정되도록하며, 새 객체를 만들기 위해 자기 자신을
 * 복제한다.
 * 
 * 객체를 생성하는 작업이 매우 클 경우 사용한다.
 **/
using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcretePrototype1 p1 = new ConcretePrototype1("Type 1");
            ConcretePrototype1 c1 = (ConcretePrototype1)p1.Clone();
            Console.WriteLine("Cloned: {0}", c1.Id);

            ConcretePrototype2 p2 = new ConcretePrototype2("Type 2");
            ConcretePrototype2 c2 = (ConcretePrototype2)p2.Clone();
            Console.WriteLine("Cloned: {0}", c2.Id);
        }
    }
}
