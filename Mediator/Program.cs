/**
 * 미디에이터
 * 
 * 클래스간의 복잡한 로직을 하나의 클래스에 우임하여 처리
 * 클래스 간 인터페이스의 복잡도를 떨어뜨릴 목적으로 사용
 * 클래스간의 복잡도를 떨어뜨려 유지 보수 및 재사용, 확장등에 유리하다.
 * 
 **/
using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteMediator m = new ConcreteMediator();

            ConcreteColleague1 c1 = new ConcreteColleague1(m);
            ConcreteColleague2 c2 = new ConcreteColleague2(m);

            m.Colleague1 = c1;
            m.Colleague2 = c2;

            c1.Send("How are you?");
            c2.Send("Fine, thanks");

            Console.ReadKey();
        }
    }
}
